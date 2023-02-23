using iTunesSearch.Library;
using iTunesSearch.Library.Models;
using ITunesSearchUtility.Helpers;

namespace ITunesSearchUtility
{
    public partial class ITunesSearchUtility : Form
    {
        readonly iTunesSearchManager _search = new iTunesSearchManager();
        readonly List<Album> _albums = new List<Album>();
        readonly List<Podcast> _podcasts = new List<Podcast>();
        readonly List<TVEpisode> _episodes = new List<TVEpisode>();
        readonly List<TVSeason> _seasons = new List<TVSeason>();
        int _lastTrackedIndex = 0;

        public ITunesSearchUtility()
        {
            InitializeComponent();
        }

        private void ITunesSearchUtility_Load(object sender, EventArgs e)
        {
            CBX_SearchBy.SelectedIndex = 0;
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
                countryCode = TXT_CountryCode.Text.ToUpperInvariant().Substring(0, 2);
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
                    Uri? albumArtistUri;
                    AlbumResult? albumResultByArtistId;
                    if (Uri.TryCreate(TXT_ContentName.Text, UriKind.Absolute, out albumArtistUri) && (albumArtistUri.Scheme == Uri.UriSchemeHttp || albumArtistUri.Scheme == Uri.UriSchemeHttps))
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
                    Uri? podcastUri;
                    if (Uri.TryCreate(TXT_ContentName.Text, UriKind.Absolute, out podcastUri) && (podcastUri.Scheme == Uri.UriSchemeHttp || podcastUri.Scheme == Uri.UriSchemeHttps))
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
                    Uri? seasonUri;
                    if (Uri.TryCreate(TXT_ContentName.Text, UriKind.Absolute, out seasonUri) && (seasonUri.Scheme == Uri.UriSchemeHttp || seasonUri.Scheme == Uri.UriSchemeHttps))
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
            else
            {
                foreach (int index in LVW_CollectionResults.SelectedIndices)
                {
                    break;
                }
                TCTRL_InformationSection.SelectedIndex = 2;
            }
        }

        private void AddAlbums(AlbumResult albumResult)
        {
            _albums.Clear();
            LVW_CollectionResults.Items.Clear();
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
            _episodes.Clear();
            LVW_CollectionResults.Items.Clear();
            foreach (TVSeason season in seasonResult.Seasons)
            {
                if (season.ShowName != null)
                {
                    _seasons.Add(season);
                    ListViewItem item = new ListViewItem(new string[] { season.ShowName, season.SeasonName });
                    LVW_CollectionResults.Items.Add(item);
                }
            }
            TCTRL_InformationSection.SelectedIndex = 2;
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TXT_ContentName.Text = "";
        }
    }
}