namespace ITunesSearchUtility
{
    partial class ITunesSearchUtility
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TCTRL_Main = new System.Windows.Forms.TabControl();
            this.TPG_Search = new System.Windows.Forms.TabPage();
            this.GBX_ContentResult = new System.Windows.Forms.GroupBox();
            this.LVW_CollectionResults = new System.Windows.Forms.ListView();
            this.CHDR_ContentName = new System.Windows.Forms.ColumnHeader();
            this.CHDR_Artists = new System.Windows.Forms.ColumnHeader();
            this.GBX_ContentInformation = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPG_Album = new System.Windows.Forms.TabPage();
            this.TXT_AlbumTrackCount = new System.Windows.Forms.TextBox();
            this.LBL_AlbumTrackCount = new System.Windows.Forms.Label();
            this.TXT_AlbumPrice = new System.Windows.Forms.TextBox();
            this.LBL_AlbumPrice = new System.Windows.Forms.Label();
            this.TXT_AlbumCopyright = new System.Windows.Forms.TextBox();
            this.LBL_AlbumCopyright = new System.Windows.Forms.Label();
            this.TXT_AlbumCurrency = new System.Windows.Forms.TextBox();
            this.LBL_AlbumCurrency = new System.Windows.Forms.Label();
            this.TXT_AlbumPrimaryGenre = new System.Windows.Forms.TextBox();
            this.TXT_AlbumName = new System.Windows.Forms.TextBox();
            this.LBL_AlbumPrimaryGenre = new System.Windows.Forms.Label();
            this.LBL_AlbumName = new System.Windows.Forms.Label();
            this.TXT_AlbumReleaseDate = new System.Windows.Forms.TextBox();
            this.LBL_AlbumArtists = new System.Windows.Forms.Label();
            this.LBL_AlbumReleaseDate = new System.Windows.Forms.Label();
            this.TXT_AlbumArtists = new System.Windows.Forms.TextBox();
            this.TXT_AlbumIsExplicit = new System.Windows.Forms.TextBox();
            this.LBL_AlbumArtistID = new System.Windows.Forms.Label();
            this.LBL_AlbumIsExplicit = new System.Windows.Forms.Label();
            this.TXT_AlbumArtistID = new System.Windows.Forms.TextBox();
            this.TXT_AlbumArtistURL = new System.Windows.Forms.TextBox();
            this.LBL_AlbumArtistURL = new System.Windows.Forms.Label();
            this.TPG_Podcast = new System.Windows.Forms.TabPage();
            this.GBX_SearchInput = new System.Windows.Forms.GroupBox();
            this.TXT_SearchLimit = new System.Windows.Forms.TextBox();
            this.LBL_CountryCode = new System.Windows.Forms.Label();
            this.LBL_SearchLimit = new System.Windows.Forms.Label();
            this.CBX_SearchBy = new System.Windows.Forms.ComboBox();
            this.TXT_ContentName = new System.Windows.Forms.TextBox();
            this.LBL_SearchBy = new System.Windows.Forms.Label();
            this.LBL_ContentName = new System.Windows.Forms.Label();
            this.BTN_ContentSearch = new System.Windows.Forms.Button();
            this.TPG_History = new System.Windows.Forms.TabPage();
            this.TXT_CountryCode = new System.Windows.Forms.TextBox();
            this.TCTRL_Main.SuspendLayout();
            this.TPG_Search.SuspendLayout();
            this.GBX_ContentResult.SuspendLayout();
            this.GBX_ContentInformation.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TPG_Album.SuspendLayout();
            this.GBX_SearchInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCTRL_Main
            // 
            this.TCTRL_Main.Controls.Add(this.TPG_Search);
            this.TCTRL_Main.Controls.Add(this.TPG_History);
            this.TCTRL_Main.Location = new System.Drawing.Point(5, 4);
            this.TCTRL_Main.Name = "TCTRL_Main";
            this.TCTRL_Main.SelectedIndex = 0;
            this.TCTRL_Main.Size = new System.Drawing.Size(821, 454);
            this.TCTRL_Main.TabIndex = 6;
            // 
            // TPG_Search
            // 
            this.TPG_Search.Controls.Add(this.GBX_ContentResult);
            this.TPG_Search.Controls.Add(this.GBX_ContentInformation);
            this.TPG_Search.Controls.Add(this.GBX_SearchInput);
            this.TPG_Search.Location = new System.Drawing.Point(4, 24);
            this.TPG_Search.Name = "TPG_Search";
            this.TPG_Search.Padding = new System.Windows.Forms.Padding(3);
            this.TPG_Search.Size = new System.Drawing.Size(813, 426);
            this.TPG_Search.TabIndex = 0;
            this.TPG_Search.Text = "Search";
            this.TPG_Search.UseVisualStyleBackColor = true;
            // 
            // GBX_ContentResult
            // 
            this.GBX_ContentResult.Controls.Add(this.LVW_CollectionResults);
            this.GBX_ContentResult.Location = new System.Drawing.Point(7, 152);
            this.GBX_ContentResult.Name = "GBX_ContentResult";
            this.GBX_ContentResult.Size = new System.Drawing.Size(401, 268);
            this.GBX_ContentResult.TabIndex = 1;
            this.GBX_ContentResult.TabStop = false;
            this.GBX_ContentResult.Text = "Result";
            // 
            // LVW_CollectionResults
            // 
            this.LVW_CollectionResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHDR_ContentName,
            this.CHDR_Artists});
            this.LVW_CollectionResults.FullRowSelect = true;
            this.LVW_CollectionResults.Location = new System.Drawing.Point(6, 22);
            this.LVW_CollectionResults.MultiSelect = false;
            this.LVW_CollectionResults.Name = "LVW_CollectionResults";
            this.LVW_CollectionResults.Size = new System.Drawing.Size(389, 240);
            this.LVW_CollectionResults.TabIndex = 0;
            this.LVW_CollectionResults.UseCompatibleStateImageBehavior = false;
            this.LVW_CollectionResults.View = System.Windows.Forms.View.Details;
            this.LVW_CollectionResults.SelectedIndexChanged += new System.EventHandler(this.LVW_CollectionResults_SelectedIndexChanged);
            // 
            // CHDR_ContentName
            // 
            this.CHDR_ContentName.Text = "Content Name";
            this.CHDR_ContentName.Width = 180;
            // 
            // CHDR_Artists
            // 
            this.CHDR_Artists.Text = "Artists(s)";
            this.CHDR_Artists.Width = 180;
            // 
            // GBX_ContentInformation
            // 
            this.GBX_ContentInformation.Controls.Add(this.tabControl1);
            this.GBX_ContentInformation.Location = new System.Drawing.Point(413, 2);
            this.GBX_ContentInformation.Name = "GBX_ContentInformation";
            this.GBX_ContentInformation.Size = new System.Drawing.Size(393, 418);
            this.GBX_ContentInformation.TabIndex = 2;
            this.GBX_ContentInformation.TabStop = false;
            this.GBX_ContentInformation.Text = "Content Information";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPG_Album);
            this.tabControl1.Controls.Add(this.TPG_Podcast);
            this.tabControl1.Location = new System.Drawing.Point(7, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 393);
            this.tabControl1.TabIndex = 7;
            // 
            // TPG_Album
            // 
            this.TPG_Album.Controls.Add(this.TXT_AlbumTrackCount);
            this.TPG_Album.Controls.Add(this.LBL_AlbumTrackCount);
            this.TPG_Album.Controls.Add(this.TXT_AlbumPrice);
            this.TPG_Album.Controls.Add(this.LBL_AlbumPrice);
            this.TPG_Album.Controls.Add(this.TXT_AlbumCopyright);
            this.TPG_Album.Controls.Add(this.LBL_AlbumCopyright);
            this.TPG_Album.Controls.Add(this.TXT_AlbumCurrency);
            this.TPG_Album.Controls.Add(this.LBL_AlbumCurrency);
            this.TPG_Album.Controls.Add(this.TXT_AlbumPrimaryGenre);
            this.TPG_Album.Controls.Add(this.TXT_AlbumName);
            this.TPG_Album.Controls.Add(this.LBL_AlbumPrimaryGenre);
            this.TPG_Album.Controls.Add(this.LBL_AlbumName);
            this.TPG_Album.Controls.Add(this.TXT_AlbumReleaseDate);
            this.TPG_Album.Controls.Add(this.LBL_AlbumArtists);
            this.TPG_Album.Controls.Add(this.LBL_AlbumReleaseDate);
            this.TPG_Album.Controls.Add(this.TXT_AlbumArtists);
            this.TPG_Album.Controls.Add(this.TXT_AlbumIsExplicit);
            this.TPG_Album.Controls.Add(this.LBL_AlbumArtistID);
            this.TPG_Album.Controls.Add(this.LBL_AlbumIsExplicit);
            this.TPG_Album.Controls.Add(this.TXT_AlbumArtistID);
            this.TPG_Album.Controls.Add(this.TXT_AlbumArtistURL);
            this.TPG_Album.Controls.Add(this.LBL_AlbumArtistURL);
            this.TPG_Album.Location = new System.Drawing.Point(4, 24);
            this.TPG_Album.Name = "TPG_Album";
            this.TPG_Album.Padding = new System.Windows.Forms.Padding(3);
            this.TPG_Album.Size = new System.Drawing.Size(373, 365);
            this.TPG_Album.TabIndex = 0;
            this.TPG_Album.Text = "Album";
            this.TPG_Album.UseVisualStyleBackColor = true;
            // 
            // TXT_AlbumTrackCount
            // 
            this.TXT_AlbumTrackCount.Location = new System.Drawing.Point(104, 330);
            this.TXT_AlbumTrackCount.Name = "TXT_AlbumTrackCount";
            this.TXT_AlbumTrackCount.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumTrackCount.TabIndex = 26;
            // 
            // LBL_AlbumTrackCount
            // 
            this.LBL_AlbumTrackCount.AutoSize = true;
            this.LBL_AlbumTrackCount.Location = new System.Drawing.Point(10, 333);
            this.LBL_AlbumTrackCount.Name = "LBL_AlbumTrackCount";
            this.LBL_AlbumTrackCount.Size = new System.Drawing.Size(73, 15);
            this.LBL_AlbumTrackCount.TabIndex = 25;
            this.LBL_AlbumTrackCount.Text = "Track Count:";
            // 
            // TXT_AlbumPrice
            // 
            this.TXT_AlbumPrice.Location = new System.Drawing.Point(104, 234);
            this.TXT_AlbumPrice.Name = "TXT_AlbumPrice";
            this.TXT_AlbumPrice.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumPrice.TabIndex = 24;
            // 
            // LBL_AlbumPrice
            // 
            this.LBL_AlbumPrice.AutoSize = true;
            this.LBL_AlbumPrice.Location = new System.Drawing.Point(10, 237);
            this.LBL_AlbumPrice.Name = "LBL_AlbumPrice";
            this.LBL_AlbumPrice.Size = new System.Drawing.Size(36, 15);
            this.LBL_AlbumPrice.TabIndex = 23;
            this.LBL_AlbumPrice.Text = "Price:";
            // 
            // TXT_AlbumCopyright
            // 
            this.TXT_AlbumCopyright.Location = new System.Drawing.Point(104, 298);
            this.TXT_AlbumCopyright.Name = "TXT_AlbumCopyright";
            this.TXT_AlbumCopyright.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumCopyright.TabIndex = 22;
            // 
            // LBL_AlbumCopyright
            // 
            this.LBL_AlbumCopyright.AutoSize = true;
            this.LBL_AlbumCopyright.Location = new System.Drawing.Point(10, 301);
            this.LBL_AlbumCopyright.Name = "LBL_AlbumCopyright";
            this.LBL_AlbumCopyright.Size = new System.Drawing.Size(63, 15);
            this.LBL_AlbumCopyright.TabIndex = 21;
            this.LBL_AlbumCopyright.Text = "Copyright:";
            // 
            // TXT_AlbumCurrency
            // 
            this.TXT_AlbumCurrency.Location = new System.Drawing.Point(105, 266);
            this.TXT_AlbumCurrency.Name = "TXT_AlbumCurrency";
            this.TXT_AlbumCurrency.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumCurrency.TabIndex = 20;
            // 
            // LBL_AlbumCurrency
            // 
            this.LBL_AlbumCurrency.AutoSize = true;
            this.LBL_AlbumCurrency.Location = new System.Drawing.Point(11, 269);
            this.LBL_AlbumCurrency.Name = "LBL_AlbumCurrency";
            this.LBL_AlbumCurrency.Size = new System.Drawing.Size(58, 15);
            this.LBL_AlbumCurrency.TabIndex = 19;
            this.LBL_AlbumCurrency.Text = "Currency:";
            // 
            // TXT_AlbumPrimaryGenre
            // 
            this.TXT_AlbumPrimaryGenre.Location = new System.Drawing.Point(105, 202);
            this.TXT_AlbumPrimaryGenre.Name = "TXT_AlbumPrimaryGenre";
            this.TXT_AlbumPrimaryGenre.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumPrimaryGenre.TabIndex = 18;
            // 
            // TXT_AlbumName
            // 
            this.TXT_AlbumName.Location = new System.Drawing.Point(104, 10);
            this.TXT_AlbumName.Name = "TXT_AlbumName";
            this.TXT_AlbumName.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumName.TabIndex = 6;
            // 
            // LBL_AlbumPrimaryGenre
            // 
            this.LBL_AlbumPrimaryGenre.AutoSize = true;
            this.LBL_AlbumPrimaryGenre.Location = new System.Drawing.Point(11, 205);
            this.LBL_AlbumPrimaryGenre.Name = "LBL_AlbumPrimaryGenre";
            this.LBL_AlbumPrimaryGenre.Size = new System.Drawing.Size(85, 15);
            this.LBL_AlbumPrimaryGenre.TabIndex = 17;
            this.LBL_AlbumPrimaryGenre.Text = "Primary Genre:";
            // 
            // LBL_AlbumName
            // 
            this.LBL_AlbumName.AutoSize = true;
            this.LBL_AlbumName.Location = new System.Drawing.Point(10, 13);
            this.LBL_AlbumName.Name = "LBL_AlbumName";
            this.LBL_AlbumName.Size = new System.Drawing.Size(42, 15);
            this.LBL_AlbumName.TabIndex = 5;
            this.LBL_AlbumName.Text = "Name:";
            // 
            // TXT_AlbumReleaseDate
            // 
            this.TXT_AlbumReleaseDate.Location = new System.Drawing.Point(105, 170);
            this.TXT_AlbumReleaseDate.Name = "TXT_AlbumReleaseDate";
            this.TXT_AlbumReleaseDate.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumReleaseDate.TabIndex = 16;
            // 
            // LBL_AlbumArtists
            // 
            this.LBL_AlbumArtists.AutoSize = true;
            this.LBL_AlbumArtists.Location = new System.Drawing.Point(10, 45);
            this.LBL_AlbumArtists.Name = "LBL_AlbumArtists";
            this.LBL_AlbumArtists.Size = new System.Drawing.Size(43, 15);
            this.LBL_AlbumArtists.TabIndex = 7;
            this.LBL_AlbumArtists.Text = "Artists:";
            // 
            // LBL_AlbumReleaseDate
            // 
            this.LBL_AlbumReleaseDate.AutoSize = true;
            this.LBL_AlbumReleaseDate.Location = new System.Drawing.Point(11, 174);
            this.LBL_AlbumReleaseDate.Name = "LBL_AlbumReleaseDate";
            this.LBL_AlbumReleaseDate.Size = new System.Drawing.Size(76, 15);
            this.LBL_AlbumReleaseDate.TabIndex = 15;
            this.LBL_AlbumReleaseDate.Text = "Release Date:";
            // 
            // TXT_AlbumArtists
            // 
            this.TXT_AlbumArtists.Location = new System.Drawing.Point(104, 42);
            this.TXT_AlbumArtists.Name = "TXT_AlbumArtists";
            this.TXT_AlbumArtists.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumArtists.TabIndex = 8;
            // 
            // TXT_AlbumIsExplicit
            // 
            this.TXT_AlbumIsExplicit.Location = new System.Drawing.Point(105, 138);
            this.TXT_AlbumIsExplicit.Name = "TXT_AlbumIsExplicit";
            this.TXT_AlbumIsExplicit.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumIsExplicit.TabIndex = 14;
            // 
            // LBL_AlbumArtistID
            // 
            this.LBL_AlbumArtistID.AutoSize = true;
            this.LBL_AlbumArtistID.Location = new System.Drawing.Point(10, 77);
            this.LBL_AlbumArtistID.Name = "LBL_AlbumArtistID";
            this.LBL_AlbumArtistID.Size = new System.Drawing.Size(52, 15);
            this.LBL_AlbumArtistID.TabIndex = 9;
            this.LBL_AlbumArtistID.Text = "Artist ID:";
            // 
            // LBL_AlbumIsExplicit
            // 
            this.LBL_AlbumIsExplicit.AutoSize = true;
            this.LBL_AlbumIsExplicit.Location = new System.Drawing.Point(11, 142);
            this.LBL_AlbumIsExplicit.Name = "LBL_AlbumIsExplicit";
            this.LBL_AlbumIsExplicit.Size = new System.Drawing.Size(59, 15);
            this.LBL_AlbumIsExplicit.TabIndex = 13;
            this.LBL_AlbumIsExplicit.Text = "Is Explicit:";
            // 
            // TXT_AlbumArtistID
            // 
            this.TXT_AlbumArtistID.Location = new System.Drawing.Point(104, 74);
            this.TXT_AlbumArtistID.Name = "TXT_AlbumArtistID";
            this.TXT_AlbumArtistID.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumArtistID.TabIndex = 10;
            // 
            // TXT_AlbumArtistURL
            // 
            this.TXT_AlbumArtistURL.Location = new System.Drawing.Point(104, 106);
            this.TXT_AlbumArtistURL.Name = "TXT_AlbumArtistURL";
            this.TXT_AlbumArtistURL.Size = new System.Drawing.Size(252, 23);
            this.TXT_AlbumArtistURL.TabIndex = 12;
            // 
            // LBL_AlbumArtistURL
            // 
            this.LBL_AlbumArtistURL.AutoSize = true;
            this.LBL_AlbumArtistURL.Location = new System.Drawing.Point(10, 109);
            this.LBL_AlbumArtistURL.Name = "LBL_AlbumArtistURL";
            this.LBL_AlbumArtistURL.Size = new System.Drawing.Size(62, 15);
            this.LBL_AlbumArtistURL.TabIndex = 11;
            this.LBL_AlbumArtistURL.Text = "Artist URL:";
            // 
            // TPG_Podcast
            // 
            this.TPG_Podcast.Location = new System.Drawing.Point(4, 24);
            this.TPG_Podcast.Name = "TPG_Podcast";
            this.TPG_Podcast.Padding = new System.Windows.Forms.Padding(3);
            this.TPG_Podcast.Size = new System.Drawing.Size(373, 365);
            this.TPG_Podcast.TabIndex = 1;
            this.TPG_Podcast.Text = "Podcast";
            this.TPG_Podcast.UseVisualStyleBackColor = true;
            // 
            // GBX_SearchInput
            // 
            this.GBX_SearchInput.Controls.Add(this.TXT_CountryCode);
            this.GBX_SearchInput.Controls.Add(this.TXT_SearchLimit);
            this.GBX_SearchInput.Controls.Add(this.LBL_CountryCode);
            this.GBX_SearchInput.Controls.Add(this.LBL_SearchLimit);
            this.GBX_SearchInput.Controls.Add(this.CBX_SearchBy);
            this.GBX_SearchInput.Controls.Add(this.TXT_ContentName);
            this.GBX_SearchInput.Controls.Add(this.LBL_SearchBy);
            this.GBX_SearchInput.Controls.Add(this.LBL_ContentName);
            this.GBX_SearchInput.Controls.Add(this.BTN_ContentSearch);
            this.GBX_SearchInput.Location = new System.Drawing.Point(7, 2);
            this.GBX_SearchInput.Name = "GBX_SearchInput";
            this.GBX_SearchInput.Size = new System.Drawing.Size(401, 151);
            this.GBX_SearchInput.TabIndex = 0;
            this.GBX_SearchInput.TabStop = false;
            this.GBX_SearchInput.Text = "Search Input";
            // 
            // TXT_SearchLimit
            // 
            this.TXT_SearchLimit.Location = new System.Drawing.Point(103, 87);
            this.TXT_SearchLimit.Name = "TXT_SearchLimit";
            this.TXT_SearchLimit.Size = new System.Drawing.Size(173, 23);
            this.TXT_SearchLimit.TabIndex = 8;
            // 
            // LBL_CountryCode
            // 
            this.LBL_CountryCode.AutoSize = true;
            this.LBL_CountryCode.Location = new System.Drawing.Point(13, 122);
            this.LBL_CountryCode.Name = "LBL_CountryCode";
            this.LBL_CountryCode.Size = new System.Drawing.Size(84, 15);
            this.LBL_CountryCode.TabIndex = 7;
            this.LBL_CountryCode.Text = "Country Code:";
            // 
            // LBL_SearchLimit
            // 
            this.LBL_SearchLimit.AutoSize = true;
            this.LBL_SearchLimit.Location = new System.Drawing.Point(13, 90);
            this.LBL_SearchLimit.Name = "LBL_SearchLimit";
            this.LBL_SearchLimit.Size = new System.Drawing.Size(75, 15);
            this.LBL_SearchLimit.TabIndex = 5;
            this.LBL_SearchLimit.Text = "Search Limit:";
            // 
            // CBX_SearchBy
            // 
            this.CBX_SearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_SearchBy.FormattingEnabled = true;
            this.CBX_SearchBy.Items.AddRange(new object[] {
            "Album Name",
            "Song Name",
            "Artist ID",
            "Podcast ID"});
            this.CBX_SearchBy.Location = new System.Drawing.Point(103, 55);
            this.CBX_SearchBy.Name = "CBX_SearchBy";
            this.CBX_SearchBy.Size = new System.Drawing.Size(173, 23);
            this.CBX_SearchBy.TabIndex = 4;
            // 
            // TXT_ContentName
            // 
            this.TXT_ContentName.Location = new System.Drawing.Point(103, 23);
            this.TXT_ContentName.Name = "TXT_ContentName";
            this.TXT_ContentName.Size = new System.Drawing.Size(282, 23);
            this.TXT_ContentName.TabIndex = 3;
            // 
            // LBL_SearchBy
            // 
            this.LBL_SearchBy.AutoSize = true;
            this.LBL_SearchBy.Location = new System.Drawing.Point(13, 59);
            this.LBL_SearchBy.Name = "LBL_SearchBy";
            this.LBL_SearchBy.Size = new System.Drawing.Size(61, 15);
            this.LBL_SearchBy.TabIndex = 2;
            this.LBL_SearchBy.Text = "Search By:";
            // 
            // LBL_ContentName
            // 
            this.LBL_ContentName.AutoSize = true;
            this.LBL_ContentName.Location = new System.Drawing.Point(13, 27);
            this.LBL_ContentName.Name = "LBL_ContentName";
            this.LBL_ContentName.Size = new System.Drawing.Size(38, 15);
            this.LBL_ContentName.TabIndex = 1;
            this.LBL_ContentName.Text = "Input:";
            // 
            // BTN_ContentSearch
            // 
            this.BTN_ContentSearch.Location = new System.Drawing.Point(294, 86);
            this.BTN_ContentSearch.Name = "BTN_ContentSearch";
            this.BTN_ContentSearch.Size = new System.Drawing.Size(91, 24);
            this.BTN_ContentSearch.TabIndex = 0;
            this.BTN_ContentSearch.Text = "Search";
            this.BTN_ContentSearch.UseVisualStyleBackColor = true;
            this.BTN_ContentSearch.Click += new System.EventHandler(this.BTN_ContentSearch_Click);
            // 
            // TPG_History
            // 
            this.TPG_History.Location = new System.Drawing.Point(4, 24);
            this.TPG_History.Name = "TPG_History";
            this.TPG_History.Padding = new System.Windows.Forms.Padding(3);
            this.TPG_History.Size = new System.Drawing.Size(813, 426);
            this.TPG_History.TabIndex = 1;
            this.TPG_History.Text = "History";
            this.TPG_History.UseVisualStyleBackColor = true;
            // 
            // TXT_CountryCode
            // 
            this.TXT_CountryCode.Location = new System.Drawing.Point(103, 119);
            this.TXT_CountryCode.Name = "TXT_CountryCode";
            this.TXT_CountryCode.Size = new System.Drawing.Size(173, 23);
            this.TXT_CountryCode.TabIndex = 9;
            // 
            // ITunesSearchUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 463);
            this.Controls.Add(this.TCTRL_Main);
            this.Name = "ITunesSearchUtility";
            this.Text = "ITunes Search Utility";
            this.Load += new System.EventHandler(this.ITunesSearchUtility_Load);
            this.TCTRL_Main.ResumeLayout(false);
            this.TPG_Search.ResumeLayout(false);
            this.GBX_ContentResult.ResumeLayout(false);
            this.GBX_ContentInformation.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TPG_Album.ResumeLayout(false);
            this.TPG_Album.PerformLayout();
            this.GBX_SearchInput.ResumeLayout(false);
            this.GBX_SearchInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl TCTRL_Main;
        private TabPage TPG_Search;
        private TabPage TPG_History;
        private GroupBox GBX_ContentInformation;
        private GroupBox GBX_ContentResult;
        private ListView LVW_CollectionResults;
        private GroupBox GBX_SearchInput;
        private ComboBox CBX_SearchBy;
        private TextBox TXT_ContentName;
        private Label LBL_SearchBy;
        private Label LBL_ContentName;
        private Button BTN_ContentSearch;
        private ColumnHeader CHDR_ContentName;
        private ColumnHeader CHDR_Artists;
        private TextBox TXT_AlbumArtistURL;
        private Label LBL_AlbumArtistURL;
        private TextBox TXT_AlbumArtistID;
        private Label LBL_AlbumArtistID;
        private TextBox TXT_AlbumArtists;
        private Label LBL_AlbumArtists;
        private TextBox TXT_AlbumName;
        private Label LBL_AlbumName;
        private TextBox TXT_AlbumPrimaryGenre;
        private Label LBL_AlbumPrimaryGenre;
        private TextBox TXT_AlbumReleaseDate;
        private Label LBL_AlbumReleaseDate;
        private TextBox TXT_AlbumIsExplicit;
        private Label LBL_AlbumIsExplicit;
        private TabControl tabControl1;
        private TabPage TPG_Album;
        private TabPage TPG_Podcast;
        private TextBox TXT_AlbumCopyright;
        private Label LBL_AlbumCopyright;
        private TextBox TXT_AlbumCurrency;
        private Label LBL_AlbumCurrency;
        private TextBox TXT_AlbumPrice;
        private Label LBL_AlbumPrice;
        private TextBox TXT_AlbumTrackCount;
        private Label LBL_AlbumTrackCount;
        private TextBox TXT_SearchLimit;
        private Label LBL_CountryCode;
        private Label LBL_SearchLimit;
        private TextBox TXT_CountryCode;
    }
}