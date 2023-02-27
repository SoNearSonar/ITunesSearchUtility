using iTunesSearch.Library;
using iTunesSearch.Library.Models;
using ITunesSearchUtility.Helpers;
using ITunesSearchUtility.Objects;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace ITunesSearchUtility
{
    public partial class ITunesSearchUtility : Form
    {
#pragma warning disable IDE0090 // Use 'new(...)'
        readonly iTunesSearchManager _search = new iTunesSearchManager();
        readonly List<Album> _albums = new List<Album>();
        readonly List<Podcast> _podcasts = new List<Podcast>();
        readonly List<TVEpisode> _episodes = new List<TVEpisode>();
        readonly List<TVSeason> _seasons = new List<TVSeason>();
        readonly static string _directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ITunes Search Utility");
        readonly static string _filePath = Path.Combine(_directoryPath, "SearchHistory.json");

        List<Search>? _searches;
        int _lastTrackedIndex = 0;

        public ITunesSearchUtility()
        {
            InitializeComponent();
        }

        private void ITunesSearchUtility_Load(object sender, EventArgs e)
        {
            CBX_SearchBy.SelectedIndex = 0;

            try
            {
                if (!Directory.Exists(_directoryPath))
                {
                    Directory.CreateDirectory(_directoryPath);
                }
                if (!File.Exists(_filePath))
                {
                    File.Create(_filePath);
                }

                _searches = JsonConvert.DeserializeObject<List<Search>>(File.ReadAllText(_filePath));
                if (_searches != null)
                {
                    foreach (Search search in _searches)
                    {
                        string[] listViewContents =
                        {
                            search.Id,
                            search.GetFavoriteIcon(),
                            search.SearchDate,
                            search.SearchContent,
                            search.SearchType.ToString().Replace("_", " "),
                            search.SearchCount.ToString(),
                            search.SearchCountryCode
                        };
                        ListViewItem item = new ListViewItem(listViewContents);
                        LVW_SearchHistory.Items.Add(item);
                    }
                }
                else
                {
                    _searches = new List<Search>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ITunesSearchUtility_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_searches != null)
                {
                    string searches = JsonConvert.SerializeObject(_searches);
                    File.WriteAllText(_filePath, searches);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void BTN_ContentSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXT_ContentName.Text))
            {
                MessageBox.Show("Please enter in the content name in the input field", "Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int searchLimit = 100;
            if (!string.IsNullOrWhiteSpace(TXT_SearchLimit.Text))
            {
                if (int.TryParse(TXT_SearchLimit.Text, out int limit))
                {
                    searchLimit = limit;
                }
                else
                {
                    MessageBox.Show("Please enter in a proper search limit number", "Search limit error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string countryCode = "us";
            if (!string.IsNullOrWhiteSpace(TXT_CountryCode.Text))
            {
                countryCode = TXT_CountryCode.Text.ToUpperInvariant()[..2];
                if (TXT_CountryCode.Text.Length > 2 || !CountryList.ContainsKey(countryCode))
                {
                    MessageBox.Show("Please enter in a proper country code", "Country code error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                countryCode = countryCode.ToLowerInvariant();
            }

            switch (CBX_SearchBy.SelectedIndex)
            {
                case 0:
                    AlbumResult? albumResultByName = await _search.GetAlbumsAsync(TXT_ContentName.Text, searchLimit, null, countryCode);
                    if (albumResultByName != null)
                    {
                        AddAlbums(albumResultByName);
                    }
                    break;
                case 1:
                    AlbumResult? albumResultByArtistId;
                    if (ContentFormatter.IsValidUri(TXT_ContentName.Text))
                    {
                        albumResultByArtistId = await _search.GetAlbumsByArtistIdAsync(ContentFormatter.FormatArtistUri(TXT_ContentName.Text));
                    }
                    else
                    {
                        albumResultByArtistId = await _search.GetAlbumsAsync(TXT_ContentName.Text, searchLimit, null, countryCode);
                    }
                    if (albumResultByArtistId != null)
                    {
                        AddAlbums(albumResultByArtistId);
                    }
                    break;
                case 2:
                case 3:
                    PodcastListResult? podcastResultsByName;
                    if (ContentFormatter.IsValidUri(TXT_ContentName.Text))
                    {
                        podcastResultsByName = await _search.GetPodcastById(ContentFormatter.FormatUri(TXT_ContentName.Text));
                    }
                    else
                    {
                        podcastResultsByName = await _search.GetPodcasts(TXT_ContentName.Text, searchLimit, countryCode);
                    }

                    if (podcastResultsByName != null)
                    {
                        AddPodcasts(podcastResultsByName);
                    }
                    break;
                case 4:
                    TVEpisodeListResult? tvEpisodesByName;
                    tvEpisodesByName = await _search.GetTVEpisodesForShow(TXT_ContentName.Text);
                    if (tvEpisodesByName != null)
                    {
                        AddTvEpisodes(tvEpisodesByName);
                    }
                    break;
                case 5:
                    TVSeasonListResult? tvSeasonByName;
                    if (ContentFormatter.IsValidUri(TXT_ContentName.Text))
                    {
                        tvSeasonByName = await _search.GetTVSeasonById(ContentFormatter.FormatUri(TXT_ContentName.Text));
                    }
                    else
                    {
                        tvSeasonByName = await _search.GetTVSeasonsForShow(TXT_ContentName.Text, searchLimit, countryCode);
                    }

                    if (tvSeasonByName != null)
                    {
                        AddTvSeasons(tvSeasonByName);
                    }
                    break;
            }
            _lastTrackedIndex = CBX_SearchBy.SelectedIndex;

            if (LVW_CollectionResults.Items.Count == 0)
            {
                MessageBox.Show("There are no results for that search", "No results", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchType searchType = SearchType.Music;
                switch (_lastTrackedIndex)
                {
                    case 1:
                        searchType = SearchType.Artist;
                        break;
                    case 2:
                        searchType = SearchType.Podcast;
                        break;
                    case 3:
                        searchType = SearchType.Audiobook;
                        break;
                    case 4:
                        searchType = SearchType.TV_Episode;
                        break;
                    case 5:
                        searchType = SearchType.TV_Show;
                        break;
                }

                Search search = new Search
                (
                    Guid.NewGuid().ToString(),
                    false,
                    DateTime.Now.ToString(),
                    TXT_ContentName.Text,
                    searchType,
                    int.TryParse(TXT_SearchLimit.Text, out int limit) ? limit : 100,
                    !string.IsNullOrWhiteSpace(TXT_CountryCode.Text) ? TXT_CountryCode.Text.ToUpperInvariant() : "US"
                );

                _searches ??= new List<Search>();
                _searches.Add(search);

                if (string.IsNullOrWhiteSpace(TXT_SearchHistoryInput.Text))
                {
                    AddListViewItem(search);
                }
            }
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TXT_ContentName.Clear();
        }

        private void BTN_UseInfo_Click(object sender, EventArgs e)
        {
            if (LVW_SearchHistory.Items.Count != 0 && LVW_SearchHistory.SelectedItems.Count != 0)
            {
                TXT_ContentName.Text = LVW_SearchHistory.SelectedItems[0].SubItems[3].Text;
                CBX_SearchBy.SelectedIndex = (int)Enum.Parse<SearchType>(LVW_SearchHistory.SelectedItems[0].SubItems[4].Text.Replace(" ", "_"));
                TXT_SearchLimit.Text = LVW_SearchHistory.SelectedItems[0].SubItems[5].Text;
                TXT_CountryCode.Text = LVW_SearchHistory.SelectedItems[0].SubItems[6].Text.ToLowerInvariant();
                TCTRL_Main.SelectedIndex = 0;
                BTN_ContentSearch_Click(sender, e);
            }
        }

        private void BTN_ClearSearches_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to delete all searches?", "Delete all searches", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                LVW_SearchHistory.Clear();
                _searches?.Clear();
            }
        }

        private void BTN_ClearSearch_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LVW_SearchHistory.SelectedItems)
            {
                LVW_SearchHistory.Items.Remove(item);
                Search? search = _searches?.Find(s => s.Id.Equals(item.SubItems[0].Text));
                if (search != null)
                {
                    _ = _searches?.Remove(search);
                }
            }
        }

        private void BTN_ClearSearchInput_Click(object sender, EventArgs e)
        {
            TXT_SearchHistoryInput.Clear();
        }

        private void LVW_CollectionResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lastTrackedIndex <= 1)
            {
                foreach (int index in LVW_CollectionResults.SelectedIndices)
                {
                    TXT_AlbumName.Text = _albums[index].CollectionName;
                    TXT_AlbumArtists.Text = _albums[index].ArtistName;
                    TXT_AlbumArtistID.Text = _albums[index].ArtistId.ToString();
                    TXT_AlbumArtistURL.Text = _albums[index].ArtistViewUrl;
                    TXT_AlbumIsExplicit.Text = _albums[index].CollectionExplicitness.Equals("notExplicit") ? "No" : "Yes";
                    TXT_AlbumReleaseDate.Text = ContentFormatter.FormatDate(_albums[index].ReleaseDate);
                    TXT_AlbumPrimaryGenre.Text = _albums[index].PrimaryGenreName;
                    TXT_AlbumPrice.Text = $"{_albums[index].CollectionPrice} {_albums[index].Currency}";
                    TXT_AlbumID.Text = _albums[index].CollectionId.ToString();
                    TXT_AlbumCountry.Text = _albums[index].Country;
                    TXT_AlbumCopyright.Text = _albums[index].Copyright;
                    TXT_AlbumTrackCount.Text = _albums[index].TrackCount.ToString();
                    break;
                }
                TCTRL_InformationSection.SelectedIndex = 0;
            }
            else if (_lastTrackedIndex > 1 && _lastTrackedIndex < 4)
            {
                foreach (int index in LVW_CollectionResults.SelectedIndices)
                {
                    TXT_PodcastName.Text = _podcasts[index].Name;
                    TXT_PodcastArtists.Text = _podcasts[index].ArtistName;
                    TXT_PodcastArtistID.Text = _podcasts[index].ArtistId != 0 ? _podcasts[index].ArtistId.ToString() : "N/A";
                    TXT_PodcastArtistURL.Text = !string.IsNullOrWhiteSpace(_podcasts[index].ArtistViewUrl) ? _podcasts[index].ArtistViewUrl : "N/A";
                    TXT_PodcastCopyright.Text = !string.IsNullOrWhiteSpace(_podcasts[index].Copyright) ? _podcasts[index].Copyright : "N/A";
                    TXT_PodcastDescription.Text = !string.IsNullOrWhiteSpace(_podcasts[index].Description) ? _podcasts[index].Description : "N/A";
                    TXT_PodcastEpisodeCount.Text = _podcasts[index].EpisodeCount.ToString();
                    TXT_PodcastIsExplicit.Text = _podcasts[index].Explicitness.Equals("notExplicit") ? "No" : "Yes";
                    TXT_PodcastID.Text = _podcasts[index].Id.ToString();
                    TXT_PodcastGenre.Text = _podcasts[index].Genre;
                    TXT_PodcastReleaseDate.Text = ContentFormatter.FormatDate(_podcasts[index].ReleaseDate);
                    TXT_PodcastRating.Text = _podcasts[index].Rating;
                    break;
                }
                TCTRL_InformationSection.SelectedIndex = 1;
            }
            else if (_lastTrackedIndex == 4)
            {
                foreach (int index in LVW_CollectionResults.SelectedIndices)
                {
                    TXT_TVEpisodeName.Text = _episodes[index].SeasonName;
                    TXT_TVEpisodeSeasonNumber.Text = _episodes[index].SeasonNumber.ToString();
                    TXT_TVEpisodeSeasonID.Text = _episodes[index].SeasonId.ToString();
                    TXT_TVEpisodePrice.Text = _episodes[index].SeasonPrice.ToString();
                    TXT_TVEpisodeHDPrice.Text = _episodes[index].SeasonPriceHD.ToString();
                    TXT_TVEpisodeCount.Text = _episodes[index].SeasonEpisodeCount.ToString();
                    TXT_TVEpisodeIsExplicit.Text = _episodes[index].SeasonExplicitness.Equals("notExplicit") ? "No" : "Yes";
                    TXT_TVEpisodeGenre.Text = _episodes[index].Genre;
                    TXT_TVEpisodeRuntime.Text = ContentFormatter.FormatRuntime(_episodes[index].RuntimeInMilliseconds);
                    TXT_TVEpisodeCountry.Text = _episodes[index].Country;
                    TXT_TVEpisodeReleaseDate.Text = ContentFormatter.FormatDate(_episodes[index].ReleaseDate);
                    TXT_TVEpisodeRating.Text = _episodes[index].Rating;
                    break;
                }
                TCTRL_InformationSection.SelectedIndex = 2;
            }
            else if (_lastTrackedIndex == 5)
            {
                foreach (int index in LVW_CollectionResults.SelectedIndices)
                {
                    TXT_TVShowName.Text = _seasons[index].SeasonName;
                    TXT_TVShowSeasonNumber.Text = _seasons[index].SeasonNumber.ToString();
                    TXT_TVShowSeasonID.Text = _seasons[index].SeasonId.ToString();
                    TXT_TVShowPrice.Text = _seasons[index].SeasonPrice.ToString();
                    TXT_TVShowHDPrice.Text = _seasons[index].SeasonPriceHD.ToString();
                    TXT_TVShowEpisodeCount.Text = _seasons[index].SeasonEpisodeCount.ToString();
                    TXT_TVShowIsExplicit.Text = _seasons[index].SeasonExplicitness.Equals("notExplicit") ? "No" : "Yes";
                    TXT_TVShowGenre.Text = _seasons[index].Genre;
                    TXT_TVShowCopyright.Text = _seasons[index].Copyright;
                    TXT_TVShowCountry.Text = _seasons[index].Country;
                    TXT_TVShowReleaseDate.Text = ContentFormatter.FormatDate(_seasons[index].ReleaseDate);
                    TXT_TVShowRating.Text = _seasons[index].Rating;
                    break;
                }
                TCTRL_InformationSection.SelectedIndex = 3;
            }
        }

        private void LVW_SearchHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CHK_ToggleFavoriting.Checked && _searches != null)
            {
                foreach (ListViewItem item in LVW_SearchHistory.SelectedItems)
                {
                    item.SubItems[1].Text = string.IsNullOrWhiteSpace(item.SubItems[1].Text) ? "\u2605" : "";
                    Search? search = _searches.Find(s => s.Id.Equals(item.SubItems[0].Text));
                    if (search != null)
                    {
                        int index = _searches.IndexOf(search);
                        _searches[index].IsFavorite = !_searches[index].IsFavorite;
                        if (CHK_OnlyFavorites.Checked)
                        {
                            LVW_SearchHistory.Items.Remove(item);
                        }
                    }
                }
            }
        }

        private void LVW_SearchHistory_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    e.Cancel = true;
                    e.NewWidth = 0;
                    break;
                case 1:
                    e.Cancel = true;
                    e.NewWidth = 30;
                    break;
            }
        }

        private void TXT_SearchHistoryInput_TextChanged(object sender, EventArgs e)
        {
            LVW_SearchHistory.Items.Clear();
            if (_searches != null)
            {
                if (CHK_OnlyFavorites.Checked)
                {
                    foreach (Search search in _searches.FindAll(s => s.SearchContent.Contains(TXT_SearchHistoryInput.Text, StringComparison.InvariantCultureIgnoreCase) && s.IsFavorite))
                    {
                        AddListViewItem(search);
                    }
                }
                else
                {
                    foreach (Search search in _searches.FindAll(s => s.SearchContent.Contains(TXT_SearchHistoryInput.Text, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        AddListViewItem(search);
                    }
                }
            }
        }

        private void CHK_OnlyFavorites_CheckedChanged(object sender, EventArgs e)
        {
            TXT_SearchHistoryInput_TextChanged(sender, e);
        }

        private void TXT_SearchLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ((char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TXT_CountryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar) || TXT_CountryCode.Text.Length >= 2) && e.KeyChar != ((char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void AddAlbums(AlbumResult albumResult)
        {
            _albums.Clear();
            LVW_CollectionResults.Items.Clear();
            LVW_CollectionResults.Columns[0].Text = "Name";
            LVW_CollectionResults.Columns[1].Text = "Artist Name";
            foreach (Album album in albumResult.Albums)
            {
                if (album.CollectionName != null)
                {
                    _albums.Add(album);
                    ListViewItem item = new ListViewItem(new string[] { album.CollectionName, album.ArtistName });
                    LVW_CollectionResults.Items.Add(item);
                }
            }
            TCTRL_InformationSection.SelectedIndex = 0;
        }

        private void AddPodcasts(PodcastListResult podcastResult)
        {
            _podcasts.Clear();
            LVW_CollectionResults.Items.Clear();
            LVW_CollectionResults.Columns[0].Text = "Name";
            LVW_CollectionResults.Columns[1].Text = "Artist Name";
            foreach (Podcast podcast in podcastResult.Podcasts)
            {
                if (podcast.Name != null)
                {
                    _podcasts.Add(podcast);
                    ListViewItem item = new ListViewItem(new string[] { podcast.Name, podcast.ArtistName });
                    LVW_CollectionResults.Items.Add(item);
                }
            }
            TCTRL_InformationSection.SelectedIndex = 1;
        }

        private void AddTvEpisodes(TVEpisodeListResult episodeResult)
        {
            _episodes.Clear();
            LVW_CollectionResults.Items.Clear();
            LVW_CollectionResults.Columns[0].Text = "Name";
            LVW_CollectionResults.Columns[1].Text = "Season Name";
            foreach (TVEpisode episode in episodeResult.Episodes)
            {
                if (episode.Name != null)
                {
                    _episodes.Add(episode);
                    ListViewItem item = new ListViewItem(new string[] { episode.Name, episode.SeasonName });
                    LVW_CollectionResults.Items.Add(item);
                }
            }
            TCTRL_InformationSection.SelectedIndex = 2;
        }

        private void AddTvSeasons(TVSeasonListResult seasonResult)
        {
            _seasons.Clear();
            LVW_CollectionResults.Items.Clear();
            LVW_CollectionResults.Columns[0].Text = "Show Name";
            LVW_CollectionResults.Columns[1].Text = "Season Name";
            foreach (TVSeason season in seasonResult.Seasons)
            {
                if (season.ShowName != null)
                {
                    _seasons.Add(season);
                    ListViewItem item = new ListViewItem(new string[] { season.ShowName, season.SeasonName });
                    LVW_CollectionResults.Items.Add(item);
                }
            }
            TCTRL_InformationSection.SelectedIndex = 3;
        }

        private void AddListViewItem(Search search)
        {
            string[] listViewContents =
            {
                search.Id,
                search.GetFavoriteIcon(),
                search.SearchDate,
                search.SearchContent,
                search.SearchType.ToString().Replace("_", " "),
                search.SearchCount.ToString(),
                search.SearchCountryCode
            };

            ListViewItem item = new ListViewItem(listViewContents);
            LVW_SearchHistory.Items.Add(item);
        }
    }
}