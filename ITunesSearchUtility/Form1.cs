using iTunesSearch.Library;
using iTunesSearch.Library.Models;

namespace ITunesSearchUtility
{
    public partial class ITunesSearchUtility : Form
    {
        readonly iTunesSearchManager _search = new iTunesSearchManager();
        List<Album> _albums = new List<Album>();

        public ITunesSearchUtility()
        {
            InitializeComponent();
        }

        private void ITunesSearchUtility_Load(object sender, EventArgs e)
        {
            CBX_ContentType.SelectedIndex = 0;
        }

        private async void BTN_ContentSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXT_ContentName.Text))
            {
                MessageBox.Show("Please enter in a name to continue", "Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AlbumResult albumResult = await _search.GetAlbumsAsync(TXT_ContentName.Text);
            MessageBox.Show(albumResult != null ? "True" : "False");
            if (albumResult != null)
            {
                _albums.Clear();
                LVW_CollectionResults.Items.Clear();
                foreach (Album album in albumResult.Albums)
                {
                    _albums.Add(album);
                    ListViewItem item = new ListViewItem(new string[] { album.CollectionName, album.ArtistName });
                    LVW_CollectionResults.Items.Add(item);
                }
            }
        }

        private void LVW_CollectionResults_SelectedIndexChanged(object sender, EventArgs e)
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
    }
 }