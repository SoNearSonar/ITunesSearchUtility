using iTunesSearch.Library;
using iTunesSearch.Library.Models;

namespace ITunesSearchUtility
{
    public partial class ITunesSearchUtility : Form
    {
        readonly iTunesSearchManager _search = new iTunesSearchManager();
        List<Album> _albums = new List<Album>();
        List<Podcast> _podcasts = new List<Podcast>();

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
                MessageBox.Show("Please enter in the required information to continue", "Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (CBX_SearchBy.SelectedIndex)
            {
                case 0:
                    AlbumResult albumResultByName = await _search.GetAlbumsAsync(TXT_ContentName.Text);
                    if (albumResultByName != null)
                    {
                        _albums.Clear();
                        AddAlbums(albumResultByName);
                    }
                    break;
                case 1:
                    AlbumResult albumResultBySongName = await _search.GetAlbumsFromSongAsync(TXT_ContentName.Text);
                    if (albumResultBySongName != null)
                    {
                        _albums.Clear();
                        AddAlbums(albumResultBySongName);
                    }
                    break;
                case 2:
                    if (long.TryParse(TXT_ContentName.Text, out long artistId))
                    {
                        AlbumResult albumResultByArtistId = await _search.GetAlbumsByArtistIdAsync(artistId);
                        if (albumResultByArtistId != null)
                        {
                            _albums.Clear();
                            AddAlbums(albumResultByArtistId);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter in a proper number for the artist ID", "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 3:
                    if (long.TryParse(TXT_ContentName.Text, out long amgArtistId))
                    {
                        AlbumResult albumResultByAmgArtistId = await _search.GetAlbumsByAMGArtistIdAsync(amgArtistId);
                        if (albumResultByAmgArtistId != null)
                        {
                            AddAlbums(albumResultByAmgArtistId);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter in a proper number for the AMG artist ID", "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case 4:
                    if (long.TryParse(TXT_ContentName.Text, out long podcastId))
                    {
                        PodcastListResult podcastResultById = await _search.GetPodcastById(podcastId);
                        if (podcastResultById != null)
                        {
                            AddPodcasts(podcastResultById);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter in a proper number for the AMG artist ID", "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }
            
            if (LVW_CollectionResults.Items.Count == 0) 
            {
                MessageBox.Show("There are no results for that search", "ID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LVW_CollectionResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_SearchBy.SelectedIndex < 4)
            {
                foreach (int index in LVW_CollectionResults.SelectedIndices)
                {
                    TXT_Name.Text = _albums[index].CollectionName;
                    TXT_Artists.Text = _albums[index].ArtistName;
                    TXT_ArtistID.Text = _albums[index].ArtistId.ToString();
                    TXT_ArtistURL.Text = _albums[index].ArtistViewUrl;
                    break;
                }
            }
            else
            {
                foreach (int index in LVW_CollectionResults.SelectedIndices)
                {
                    TXT_Name.Text = _podcasts[index].Name;
                    TXT_Artists.Text = _podcasts[index].ArtistName;
                    TXT_ArtistID.Text = _podcasts[index].ArtistId.ToString();
                    TXT_ArtistURL.Text = _podcasts[index].ArtistViewUrl;
                    break;
                }
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
        }
    }
 }