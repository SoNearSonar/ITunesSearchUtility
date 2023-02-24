﻿namespace ITunesSearchUtility
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
            TCTRL_Main = new TabControl();
            TPG_Search = new TabPage();
            GBX_ContentResult = new GroupBox();
            LVW_CollectionResults = new ListView();
            CHDR_ContentName = new ColumnHeader();
            CHDR_Artists = new ColumnHeader();
            GBX_ContentInformation = new GroupBox();
            TCTRL_InformationSection = new TabControl();
            TPG_Album = new TabPage();
            TXT_AlbumCountry = new TextBox();
            LBL_AlbumCountry = new Label();
            TXT_AlbumTrackCount = new TextBox();
            LBL_AlbumTrackCount = new Label();
            TXT_AlbumPrice = new TextBox();
            LBL_AlbumPrice = new Label();
            TXT_AlbumReleaseDate = new TextBox();
            LBL_AlbumReleaseDate = new Label();
            TXT_AlbumID = new TextBox();
            LBL_AlbumID = new Label();
            TXT_AlbumPrimaryGenre = new TextBox();
            TXT_AlbumName = new TextBox();
            LBL_AlbumPrimaryGenre = new Label();
            LBL_AlbumName = new Label();
            TXT_AlbumCopyright = new TextBox();
            LBL_AlbumArtists = new Label();
            LBL_AlbumCopyright = new Label();
            TXT_AlbumArtists = new TextBox();
            TXT_AlbumIsExplicit = new TextBox();
            LBL_AlbumArtistID = new Label();
            LBL_AlbumIsExplicit = new Label();
            TXT_AlbumArtistID = new TextBox();
            TXT_AlbumArtistURL = new TextBox();
            LBL_AlbumArtistURL = new Label();
            TPG_Podcast = new TabPage();
            TXT_PodcastID = new TextBox();
            TXT_PodcastEpisodeCount = new TextBox();
            LBL_PodcastEpisodeCount = new Label();
            TXT_PodcastGenre = new TextBox();
            LBL_PodcastGenre = new Label();
            TXT_PodcastDescription = new TextBox();
            LBL_PodcastDecription = new Label();
            TXT_PodcastCopyright = new TextBox();
            LBL_PodcastCopyright = new Label();
            TXT_PodcastIsExplicit = new TextBox();
            LBL_PodcastIsExplicit = new Label();
            LBL_PodcastID = new Label();
            TXT_PodcastRating = new TextBox();
            LBL_PodcastRating = new Label();
            TXT_PodcastReleaseDate = new TextBox();
            LBL_PodcastReleaseDate = new Label();
            TXT_PodcastName = new TextBox();
            LBL_PodcastName = new Label();
            LBL_PodcastArtists = new Label();
            TXT_PodcastArtists = new TextBox();
            LBL_PodcastArtistID = new Label();
            TXT_PodcastArtistID = new TextBox();
            TXT_PodcastArtistURL = new TextBox();
            LBL_PodcastArtistURL = new Label();
            TPG_TVShow = new TabPage();
            TXT_TVShowCountry = new TextBox();
            LBL_TVShowCountry = new Label();
            TXT_TVShowRating = new TextBox();
            LBL_TVShowRating = new Label();
            TXT_TVShowGenre = new TextBox();
            LBL_TVShowGenre = new Label();
            TXT_TVShowReleaseDate = new TextBox();
            LBL_TVShowReleaseDate = new Label();
            TXT_TVShowCopyright = new TextBox();
            LBL_TVShowCopyright = new Label();
            TXT_TVShowIsExplicit = new TextBox();
            TXT_TVShowName = new TextBox();
            LBL_TVShowIsExplicit = new Label();
            LBL_TVShowName = new Label();
            TXT_TVShowEpisodeCount = new TextBox();
            LBL_TVShowSeasonNumber = new Label();
            LBL_TVShowEpisodeCount = new Label();
            TXT_TVShowSeasonNumber = new TextBox();
            TXT_TVShowHDPrice = new TextBox();
            LBL_TVShowSeasonID = new Label();
            LBL_TVShowHDPrice = new Label();
            TXT_TVShowSeasonID = new TextBox();
            TXT_TVShowPrice = new TextBox();
            LBL_TVShowPrice = new Label();
            GBX_SearchInformation = new GroupBox();
            BTN_Clear = new Button();
            TXT_CountryCode = new TextBox();
            TXT_SearchLimit = new TextBox();
            LBL_CountryCode = new Label();
            LBL_SearchLimit = new Label();
            CBX_SearchBy = new ComboBox();
            TXT_ContentName = new TextBox();
            LBL_SearchBy = new Label();
            LBL_ContentName = new Label();
            BTN_ContentSearch = new Button();
            TPG_History = new TabPage();
            GBX_History = new GroupBox();
            listView1 = new ListView();
            GBX_SearchActions = new GroupBox();
            GBX_HistorySearchInformation = new GroupBox();
            TCTRL_Main.SuspendLayout();
            TPG_Search.SuspendLayout();
            GBX_ContentResult.SuspendLayout();
            GBX_ContentInformation.SuspendLayout();
            TCTRL_InformationSection.SuspendLayout();
            TPG_Album.SuspendLayout();
            TPG_Podcast.SuspendLayout();
            TPG_TVShow.SuspendLayout();
            GBX_SearchInformation.SuspendLayout();
            TPG_History.SuspendLayout();
            GBX_History.SuspendLayout();
            SuspendLayout();
            // 
            // TCTRL_Main
            // 
            TCTRL_Main.Controls.Add(TPG_Search);
            TCTRL_Main.Controls.Add(TPG_History);
            TCTRL_Main.Location = new Point(5, 4);
            TCTRL_Main.Name = "TCTRL_Main";
            TCTRL_Main.SelectedIndex = 0;
            TCTRL_Main.Size = new Size(843, 483);
            TCTRL_Main.TabIndex = 6;
            // 
            // TPG_Search
            // 
            TPG_Search.Controls.Add(GBX_ContentResult);
            TPG_Search.Controls.Add(GBX_ContentInformation);
            TPG_Search.Controls.Add(GBX_SearchInformation);
            TPG_Search.Location = new Point(4, 24);
            TPG_Search.Name = "TPG_Search";
            TPG_Search.Padding = new Padding(3);
            TPG_Search.Size = new Size(835, 455);
            TPG_Search.TabIndex = 0;
            TPG_Search.Text = "Search";
            TPG_Search.UseVisualStyleBackColor = true;
            // 
            // GBX_ContentResult
            // 
            GBX_ContentResult.Controls.Add(LVW_CollectionResults);
            GBX_ContentResult.Location = new Point(7, 152);
            GBX_ContentResult.Name = "GBX_ContentResult";
            GBX_ContentResult.Size = new Size(401, 297);
            GBX_ContentResult.TabIndex = 1;
            GBX_ContentResult.TabStop = false;
            GBX_ContentResult.Text = "Result";
            // 
            // LVW_CollectionResults
            // 
            LVW_CollectionResults.Columns.AddRange(new ColumnHeader[] { CHDR_ContentName, CHDR_Artists });
            LVW_CollectionResults.FullRowSelect = true;
            LVW_CollectionResults.Location = new Point(6, 23);
            LVW_CollectionResults.MultiSelect = false;
            LVW_CollectionResults.Name = "LVW_CollectionResults";
            LVW_CollectionResults.Size = new Size(389, 265);
            LVW_CollectionResults.TabIndex = 0;
            LVW_CollectionResults.UseCompatibleStateImageBehavior = false;
            LVW_CollectionResults.View = View.Details;
            LVW_CollectionResults.SelectedIndexChanged += LVW_CollectionResults_SelectedIndexChanged;
            // 
            // CHDR_ContentName
            // 
            CHDR_ContentName.Text = "Content Name";
            CHDR_ContentName.Width = 180;
            // 
            // CHDR_Artists
            // 
            CHDR_Artists.Text = "Artists(s)";
            CHDR_Artists.Width = 180;
            // 
            // GBX_ContentInformation
            // 
            GBX_ContentInformation.Controls.Add(TCTRL_InformationSection);
            GBX_ContentInformation.Location = new Point(413, 2);
            GBX_ContentInformation.Name = "GBX_ContentInformation";
            GBX_ContentInformation.Size = new Size(416, 447);
            GBX_ContentInformation.TabIndex = 2;
            GBX_ContentInformation.TabStop = false;
            GBX_ContentInformation.Text = "Content Information";
            // 
            // TCTRL_InformationSection
            // 
            TCTRL_InformationSection.Controls.Add(TPG_Album);
            TCTRL_InformationSection.Controls.Add(TPG_Podcast);
            TCTRL_InformationSection.Controls.Add(TPG_TVShow);
            TCTRL_InformationSection.Location = new Point(7, 19);
            TCTRL_InformationSection.Name = "TCTRL_InformationSection";
            TCTRL_InformationSection.SelectedIndex = 0;
            TCTRL_InformationSection.Size = new Size(403, 422);
            TCTRL_InformationSection.TabIndex = 7;
            // 
            // TPG_Album
            // 
            TPG_Album.Controls.Add(TXT_AlbumCountry);
            TPG_Album.Controls.Add(LBL_AlbumCountry);
            TPG_Album.Controls.Add(TXT_AlbumTrackCount);
            TPG_Album.Controls.Add(LBL_AlbumTrackCount);
            TPG_Album.Controls.Add(TXT_AlbumPrice);
            TPG_Album.Controls.Add(LBL_AlbumPrice);
            TPG_Album.Controls.Add(TXT_AlbumReleaseDate);
            TPG_Album.Controls.Add(LBL_AlbumReleaseDate);
            TPG_Album.Controls.Add(TXT_AlbumID);
            TPG_Album.Controls.Add(LBL_AlbumID);
            TPG_Album.Controls.Add(TXT_AlbumPrimaryGenre);
            TPG_Album.Controls.Add(TXT_AlbumName);
            TPG_Album.Controls.Add(LBL_AlbumPrimaryGenre);
            TPG_Album.Controls.Add(LBL_AlbumName);
            TPG_Album.Controls.Add(TXT_AlbumCopyright);
            TPG_Album.Controls.Add(LBL_AlbumArtists);
            TPG_Album.Controls.Add(LBL_AlbumCopyright);
            TPG_Album.Controls.Add(TXT_AlbumArtists);
            TPG_Album.Controls.Add(TXT_AlbumIsExplicit);
            TPG_Album.Controls.Add(LBL_AlbumArtistID);
            TPG_Album.Controls.Add(LBL_AlbumIsExplicit);
            TPG_Album.Controls.Add(TXT_AlbumArtistID);
            TPG_Album.Controls.Add(TXT_AlbumArtistURL);
            TPG_Album.Controls.Add(LBL_AlbumArtistURL);
            TPG_Album.Location = new Point(4, 24);
            TPG_Album.Name = "TPG_Album";
            TPG_Album.Padding = new Padding(3);
            TPG_Album.Size = new Size(395, 394);
            TPG_Album.TabIndex = 0;
            TPG_Album.Text = "Album";
            TPG_Album.UseVisualStyleBackColor = true;
            // 
            // TXT_AlbumCountry
            // 
            TXT_AlbumCountry.Location = new Point(106, 298);
            TXT_AlbumCountry.Name = "TXT_AlbumCountry";
            TXT_AlbumCountry.Size = new Size(274, 23);
            TXT_AlbumCountry.TabIndex = 28;
            // 
            // LBL_AlbumCountry
            // 
            LBL_AlbumCountry.AutoSize = true;
            LBL_AlbumCountry.Location = new Point(10, 301);
            LBL_AlbumCountry.Name = "LBL_AlbumCountry";
            LBL_AlbumCountry.Size = new Size(53, 15);
            LBL_AlbumCountry.TabIndex = 27;
            LBL_AlbumCountry.Text = "Country:";
            // 
            // TXT_AlbumTrackCount
            // 
            TXT_AlbumTrackCount.Location = new Point(106, 362);
            TXT_AlbumTrackCount.Name = "TXT_AlbumTrackCount";
            TXT_AlbumTrackCount.Size = new Size(274, 23);
            TXT_AlbumTrackCount.TabIndex = 26;
            // 
            // LBL_AlbumTrackCount
            // 
            LBL_AlbumTrackCount.AutoSize = true;
            LBL_AlbumTrackCount.Location = new Point(10, 365);
            LBL_AlbumTrackCount.Name = "LBL_AlbumTrackCount";
            LBL_AlbumTrackCount.Size = new Size(73, 15);
            LBL_AlbumTrackCount.TabIndex = 25;
            LBL_AlbumTrackCount.Text = "Track Count:";
            // 
            // TXT_AlbumPrice
            // 
            TXT_AlbumPrice.Location = new Point(106, 234);
            TXT_AlbumPrice.Name = "TXT_AlbumPrice";
            TXT_AlbumPrice.Size = new Size(274, 23);
            TXT_AlbumPrice.TabIndex = 24;
            // 
            // LBL_AlbumPrice
            // 
            LBL_AlbumPrice.AutoSize = true;
            LBL_AlbumPrice.Location = new Point(9, 237);
            LBL_AlbumPrice.Name = "LBL_AlbumPrice";
            LBL_AlbumPrice.Size = new Size(36, 15);
            LBL_AlbumPrice.TabIndex = 23;
            LBL_AlbumPrice.Text = "Price:";
            // 
            // TXT_AlbumReleaseDate
            // 
            TXT_AlbumReleaseDate.Location = new Point(106, 330);
            TXT_AlbumReleaseDate.Name = "TXT_AlbumReleaseDate";
            TXT_AlbumReleaseDate.Size = new Size(274, 23);
            TXT_AlbumReleaseDate.TabIndex = 22;
            // 
            // LBL_AlbumReleaseDate
            // 
            LBL_AlbumReleaseDate.AutoSize = true;
            LBL_AlbumReleaseDate.Location = new Point(10, 333);
            LBL_AlbumReleaseDate.Name = "LBL_AlbumReleaseDate";
            LBL_AlbumReleaseDate.Size = new Size(76, 15);
            LBL_AlbumReleaseDate.TabIndex = 21;
            LBL_AlbumReleaseDate.Text = "Release Date:";
            // 
            // TXT_AlbumID
            // 
            TXT_AlbumID.Location = new Point(106, 266);
            TXT_AlbumID.Name = "TXT_AlbumID";
            TXT_AlbumID.Size = new Size(274, 23);
            TXT_AlbumID.TabIndex = 20;
            // 
            // LBL_AlbumID
            // 
            LBL_AlbumID.AutoSize = true;
            LBL_AlbumID.Location = new Point(10, 269);
            LBL_AlbumID.Name = "LBL_AlbumID";
            LBL_AlbumID.Size = new Size(21, 15);
            LBL_AlbumID.TabIndex = 19;
            LBL_AlbumID.Text = "ID:";
            // 
            // TXT_AlbumPrimaryGenre
            // 
            TXT_AlbumPrimaryGenre.Location = new Point(106, 202);
            TXT_AlbumPrimaryGenre.Name = "TXT_AlbumPrimaryGenre";
            TXT_AlbumPrimaryGenre.Size = new Size(274, 23);
            TXT_AlbumPrimaryGenre.TabIndex = 18;
            // 
            // TXT_AlbumName
            // 
            TXT_AlbumName.Location = new Point(105, 10);
            TXT_AlbumName.Name = "TXT_AlbumName";
            TXT_AlbumName.Size = new Size(274, 23);
            TXT_AlbumName.TabIndex = 6;
            // 
            // LBL_AlbumPrimaryGenre
            // 
            LBL_AlbumPrimaryGenre.AutoSize = true;
            LBL_AlbumPrimaryGenre.Location = new Point(10, 205);
            LBL_AlbumPrimaryGenre.Name = "LBL_AlbumPrimaryGenre";
            LBL_AlbumPrimaryGenre.Size = new Size(85, 15);
            LBL_AlbumPrimaryGenre.TabIndex = 17;
            LBL_AlbumPrimaryGenre.Text = "Primary Genre:";
            // 
            // LBL_AlbumName
            // 
            LBL_AlbumName.AutoSize = true;
            LBL_AlbumName.Location = new Point(9, 13);
            LBL_AlbumName.Name = "LBL_AlbumName";
            LBL_AlbumName.Size = new Size(42, 15);
            LBL_AlbumName.TabIndex = 5;
            LBL_AlbumName.Text = "Name:";
            // 
            // TXT_AlbumCopyright
            // 
            TXT_AlbumCopyright.Location = new Point(106, 170);
            TXT_AlbumCopyright.Name = "TXT_AlbumCopyright";
            TXT_AlbumCopyright.Size = new Size(274, 23);
            TXT_AlbumCopyright.TabIndex = 16;
            // 
            // LBL_AlbumArtists
            // 
            LBL_AlbumArtists.AutoSize = true;
            LBL_AlbumArtists.Location = new Point(9, 45);
            LBL_AlbumArtists.Name = "LBL_AlbumArtists";
            LBL_AlbumArtists.Size = new Size(43, 15);
            LBL_AlbumArtists.TabIndex = 7;
            LBL_AlbumArtists.Text = "Artists:";
            // 
            // LBL_AlbumCopyright
            // 
            LBL_AlbumCopyright.AutoSize = true;
            LBL_AlbumCopyright.Location = new Point(10, 174);
            LBL_AlbumCopyright.Name = "LBL_AlbumCopyright";
            LBL_AlbumCopyright.Size = new Size(63, 15);
            LBL_AlbumCopyright.TabIndex = 15;
            LBL_AlbumCopyright.Text = "Copyright:";
            // 
            // TXT_AlbumArtists
            // 
            TXT_AlbumArtists.Location = new Point(105, 42);
            TXT_AlbumArtists.Name = "TXT_AlbumArtists";
            TXT_AlbumArtists.Size = new Size(274, 23);
            TXT_AlbumArtists.TabIndex = 8;
            // 
            // TXT_AlbumIsExplicit
            // 
            TXT_AlbumIsExplicit.Location = new Point(106, 138);
            TXT_AlbumIsExplicit.Name = "TXT_AlbumIsExplicit";
            TXT_AlbumIsExplicit.Size = new Size(274, 23);
            TXT_AlbumIsExplicit.TabIndex = 14;
            // 
            // LBL_AlbumArtistID
            // 
            LBL_AlbumArtistID.AutoSize = true;
            LBL_AlbumArtistID.Location = new Point(9, 77);
            LBL_AlbumArtistID.Name = "LBL_AlbumArtistID";
            LBL_AlbumArtistID.Size = new Size(52, 15);
            LBL_AlbumArtistID.TabIndex = 9;
            LBL_AlbumArtistID.Text = "Artist ID:";
            // 
            // LBL_AlbumIsExplicit
            // 
            LBL_AlbumIsExplicit.AutoSize = true;
            LBL_AlbumIsExplicit.Location = new Point(10, 142);
            LBL_AlbumIsExplicit.Name = "LBL_AlbumIsExplicit";
            LBL_AlbumIsExplicit.Size = new Size(59, 15);
            LBL_AlbumIsExplicit.TabIndex = 13;
            LBL_AlbumIsExplicit.Text = "Is Explicit:";
            // 
            // TXT_AlbumArtistID
            // 
            TXT_AlbumArtistID.Location = new Point(105, 74);
            TXT_AlbumArtistID.Name = "TXT_AlbumArtistID";
            TXT_AlbumArtistID.Size = new Size(274, 23);
            TXT_AlbumArtistID.TabIndex = 10;
            // 
            // TXT_AlbumArtistURL
            // 
            TXT_AlbumArtistURL.Location = new Point(105, 106);
            TXT_AlbumArtistURL.Name = "TXT_AlbumArtistURL";
            TXT_AlbumArtistURL.Size = new Size(274, 23);
            TXT_AlbumArtistURL.TabIndex = 12;
            // 
            // LBL_AlbumArtistURL
            // 
            LBL_AlbumArtistURL.AutoSize = true;
            LBL_AlbumArtistURL.Location = new Point(9, 109);
            LBL_AlbumArtistURL.Name = "LBL_AlbumArtistURL";
            LBL_AlbumArtistURL.Size = new Size(62, 15);
            LBL_AlbumArtistURL.TabIndex = 11;
            LBL_AlbumArtistURL.Text = "Artist URL:";
            // 
            // TPG_Podcast
            // 
            TPG_Podcast.Controls.Add(TXT_PodcastID);
            TPG_Podcast.Controls.Add(TXT_PodcastEpisodeCount);
            TPG_Podcast.Controls.Add(LBL_PodcastEpisodeCount);
            TPG_Podcast.Controls.Add(TXT_PodcastGenre);
            TPG_Podcast.Controls.Add(LBL_PodcastGenre);
            TPG_Podcast.Controls.Add(TXT_PodcastDescription);
            TPG_Podcast.Controls.Add(LBL_PodcastDecription);
            TPG_Podcast.Controls.Add(TXT_PodcastCopyright);
            TPG_Podcast.Controls.Add(LBL_PodcastCopyright);
            TPG_Podcast.Controls.Add(TXT_PodcastIsExplicit);
            TPG_Podcast.Controls.Add(LBL_PodcastIsExplicit);
            TPG_Podcast.Controls.Add(LBL_PodcastID);
            TPG_Podcast.Controls.Add(TXT_PodcastRating);
            TPG_Podcast.Controls.Add(LBL_PodcastRating);
            TPG_Podcast.Controls.Add(TXT_PodcastReleaseDate);
            TPG_Podcast.Controls.Add(LBL_PodcastReleaseDate);
            TPG_Podcast.Controls.Add(TXT_PodcastName);
            TPG_Podcast.Controls.Add(LBL_PodcastName);
            TPG_Podcast.Controls.Add(LBL_PodcastArtists);
            TPG_Podcast.Controls.Add(TXT_PodcastArtists);
            TPG_Podcast.Controls.Add(LBL_PodcastArtistID);
            TPG_Podcast.Controls.Add(TXT_PodcastArtistID);
            TPG_Podcast.Controls.Add(TXT_PodcastArtistURL);
            TPG_Podcast.Controls.Add(LBL_PodcastArtistURL);
            TPG_Podcast.Location = new Point(4, 24);
            TPG_Podcast.Name = "TPG_Podcast";
            TPG_Podcast.Padding = new Padding(3);
            TPG_Podcast.Size = new Size(395, 394);
            TPG_Podcast.TabIndex = 1;
            TPG_Podcast.Text = "Podcast / Audiobook";
            TPG_Podcast.UseVisualStyleBackColor = true;
            // 
            // TXT_PodcastID
            // 
            TXT_PodcastID.Location = new Point(106, 266);
            TXT_PodcastID.Name = "TXT_PodcastID";
            TXT_PodcastID.Size = new Size(274, 23);
            TXT_PodcastID.TabIndex = 52;
            // 
            // TXT_PodcastEpisodeCount
            // 
            TXT_PodcastEpisodeCount.Location = new Point(106, 298);
            TXT_PodcastEpisodeCount.Name = "TXT_PodcastEpisodeCount";
            TXT_PodcastEpisodeCount.Size = new Size(274, 23);
            TXT_PodcastEpisodeCount.TabIndex = 42;
            // 
            // LBL_PodcastEpisodeCount
            // 
            LBL_PodcastEpisodeCount.AutoSize = true;
            LBL_PodcastEpisodeCount.Location = new Point(10, 301);
            LBL_PodcastEpisodeCount.Name = "LBL_PodcastEpisodeCount";
            LBL_PodcastEpisodeCount.Size = new Size(87, 15);
            LBL_PodcastEpisodeCount.TabIndex = 41;
            LBL_PodcastEpisodeCount.Text = "Episode Count:";
            // 
            // TXT_PodcastGenre
            // 
            TXT_PodcastGenre.Location = new Point(106, 202);
            TXT_PodcastGenre.Name = "TXT_PodcastGenre";
            TXT_PodcastGenre.Size = new Size(274, 23);
            TXT_PodcastGenre.TabIndex = 44;
            // 
            // LBL_PodcastGenre
            // 
            LBL_PodcastGenre.AutoSize = true;
            LBL_PodcastGenre.Location = new Point(10, 205);
            LBL_PodcastGenre.Name = "LBL_PodcastGenre";
            LBL_PodcastGenre.Size = new Size(85, 15);
            LBL_PodcastGenre.TabIndex = 43;
            LBL_PodcastGenre.Text = "Primary Genre:";
            // 
            // TXT_PodcastDescription
            // 
            TXT_PodcastDescription.Location = new Point(106, 234);
            TXT_PodcastDescription.Name = "TXT_PodcastDescription";
            TXT_PodcastDescription.Size = new Size(274, 23);
            TXT_PodcastDescription.TabIndex = 40;
            // 
            // LBL_PodcastDecription
            // 
            LBL_PodcastDecription.AutoSize = true;
            LBL_PodcastDecription.Location = new Point(10, 238);
            LBL_PodcastDecription.Name = "LBL_PodcastDecription";
            LBL_PodcastDecription.Size = new Size(70, 15);
            LBL_PodcastDecription.TabIndex = 39;
            LBL_PodcastDecription.Text = "Description:";
            // 
            // TXT_PodcastCopyright
            // 
            TXT_PodcastCopyright.Location = new Point(106, 170);
            TXT_PodcastCopyright.Name = "TXT_PodcastCopyright";
            TXT_PodcastCopyright.Size = new Size(274, 23);
            TXT_PodcastCopyright.TabIndex = 38;
            // 
            // LBL_PodcastCopyright
            // 
            LBL_PodcastCopyright.AutoSize = true;
            LBL_PodcastCopyright.Location = new Point(10, 174);
            LBL_PodcastCopyright.Name = "LBL_PodcastCopyright";
            LBL_PodcastCopyright.Size = new Size(63, 15);
            LBL_PodcastCopyright.TabIndex = 37;
            LBL_PodcastCopyright.Text = "Copyright:";
            // 
            // TXT_PodcastIsExplicit
            // 
            TXT_PodcastIsExplicit.Location = new Point(106, 138);
            TXT_PodcastIsExplicit.Name = "TXT_PodcastIsExplicit";
            TXT_PodcastIsExplicit.Size = new Size(274, 23);
            TXT_PodcastIsExplicit.TabIndex = 48;
            // 
            // LBL_PodcastIsExplicit
            // 
            LBL_PodcastIsExplicit.AutoSize = true;
            LBL_PodcastIsExplicit.Location = new Point(10, 142);
            LBL_PodcastIsExplicit.Name = "LBL_PodcastIsExplicit";
            LBL_PodcastIsExplicit.Size = new Size(59, 15);
            LBL_PodcastIsExplicit.TabIndex = 47;
            LBL_PodcastIsExplicit.Text = "Is Explicit:";
            // 
            // LBL_PodcastID
            // 
            LBL_PodcastID.AutoSize = true;
            LBL_PodcastID.Location = new Point(10, 269);
            LBL_PodcastID.Name = "LBL_PodcastID";
            LBL_PodcastID.Size = new Size(21, 15);
            LBL_PodcastID.TabIndex = 51;
            LBL_PodcastID.Text = "ID:";
            // 
            // TXT_PodcastRating
            // 
            TXT_PodcastRating.Location = new Point(106, 362);
            TXT_PodcastRating.Name = "TXT_PodcastRating";
            TXT_PodcastRating.Size = new Size(274, 23);
            TXT_PodcastRating.TabIndex = 50;
            // 
            // LBL_PodcastRating
            // 
            LBL_PodcastRating.AutoSize = true;
            LBL_PodcastRating.Location = new Point(10, 365);
            LBL_PodcastRating.Name = "LBL_PodcastRating";
            LBL_PodcastRating.Size = new Size(44, 15);
            LBL_PodcastRating.TabIndex = 49;
            LBL_PodcastRating.Text = "Rating:";
            // 
            // TXT_PodcastReleaseDate
            // 
            TXT_PodcastReleaseDate.Location = new Point(106, 330);
            TXT_PodcastReleaseDate.Name = "TXT_PodcastReleaseDate";
            TXT_PodcastReleaseDate.Size = new Size(274, 23);
            TXT_PodcastReleaseDate.TabIndex = 46;
            // 
            // LBL_PodcastReleaseDate
            // 
            LBL_PodcastReleaseDate.AutoSize = true;
            LBL_PodcastReleaseDate.Location = new Point(10, 333);
            LBL_PodcastReleaseDate.Name = "LBL_PodcastReleaseDate";
            LBL_PodcastReleaseDate.Size = new Size(76, 15);
            LBL_PodcastReleaseDate.TabIndex = 45;
            LBL_PodcastReleaseDate.Text = "Release Date:";
            // 
            // TXT_PodcastName
            // 
            TXT_PodcastName.Location = new Point(105, 10);
            TXT_PodcastName.Name = "TXT_PodcastName";
            TXT_PodcastName.Size = new Size(274, 23);
            TXT_PodcastName.TabIndex = 30;
            // 
            // LBL_PodcastName
            // 
            LBL_PodcastName.AutoSize = true;
            LBL_PodcastName.Location = new Point(9, 13);
            LBL_PodcastName.Name = "LBL_PodcastName";
            LBL_PodcastName.Size = new Size(42, 15);
            LBL_PodcastName.TabIndex = 29;
            LBL_PodcastName.Text = "Name:";
            // 
            // LBL_PodcastArtists
            // 
            LBL_PodcastArtists.AutoSize = true;
            LBL_PodcastArtists.Location = new Point(9, 45);
            LBL_PodcastArtists.Name = "LBL_PodcastArtists";
            LBL_PodcastArtists.Size = new Size(43, 15);
            LBL_PodcastArtists.TabIndex = 31;
            LBL_PodcastArtists.Text = "Artists:";
            // 
            // TXT_PodcastArtists
            // 
            TXT_PodcastArtists.Location = new Point(105, 42);
            TXT_PodcastArtists.Name = "TXT_PodcastArtists";
            TXT_PodcastArtists.Size = new Size(274, 23);
            TXT_PodcastArtists.TabIndex = 32;
            // 
            // LBL_PodcastArtistID
            // 
            LBL_PodcastArtistID.AutoSize = true;
            LBL_PodcastArtistID.Location = new Point(9, 77);
            LBL_PodcastArtistID.Name = "LBL_PodcastArtistID";
            LBL_PodcastArtistID.Size = new Size(52, 15);
            LBL_PodcastArtistID.TabIndex = 33;
            LBL_PodcastArtistID.Text = "Artist ID:";
            // 
            // TXT_PodcastArtistID
            // 
            TXT_PodcastArtistID.Location = new Point(105, 74);
            TXT_PodcastArtistID.Name = "TXT_PodcastArtistID";
            TXT_PodcastArtistID.Size = new Size(274, 23);
            TXT_PodcastArtistID.TabIndex = 34;
            // 
            // TXT_PodcastArtistURL
            // 
            TXT_PodcastArtistURL.Location = new Point(105, 106);
            TXT_PodcastArtistURL.Name = "TXT_PodcastArtistURL";
            TXT_PodcastArtistURL.Size = new Size(274, 23);
            TXT_PodcastArtistURL.TabIndex = 36;
            // 
            // LBL_PodcastArtistURL
            // 
            LBL_PodcastArtistURL.AutoSize = true;
            LBL_PodcastArtistURL.Location = new Point(9, 109);
            LBL_PodcastArtistURL.Name = "LBL_PodcastArtistURL";
            LBL_PodcastArtistURL.Size = new Size(62, 15);
            LBL_PodcastArtistURL.TabIndex = 35;
            LBL_PodcastArtistURL.Text = "Artist URL:";
            // 
            // TPG_TVShow
            // 
            TPG_TVShow.Controls.Add(TXT_TVShowCountry);
            TPG_TVShow.Controls.Add(LBL_TVShowCountry);
            TPG_TVShow.Controls.Add(TXT_TVShowRating);
            TPG_TVShow.Controls.Add(LBL_TVShowRating);
            TPG_TVShow.Controls.Add(TXT_TVShowGenre);
            TPG_TVShow.Controls.Add(LBL_TVShowGenre);
            TPG_TVShow.Controls.Add(TXT_TVShowReleaseDate);
            TPG_TVShow.Controls.Add(LBL_TVShowReleaseDate);
            TPG_TVShow.Controls.Add(TXT_TVShowCopyright);
            TPG_TVShow.Controls.Add(LBL_TVShowCopyright);
            TPG_TVShow.Controls.Add(TXT_TVShowIsExplicit);
            TPG_TVShow.Controls.Add(TXT_TVShowName);
            TPG_TVShow.Controls.Add(LBL_TVShowIsExplicit);
            TPG_TVShow.Controls.Add(LBL_TVShowName);
            TPG_TVShow.Controls.Add(TXT_TVShowEpisodeCount);
            TPG_TVShow.Controls.Add(LBL_TVShowSeasonNumber);
            TPG_TVShow.Controls.Add(LBL_TVShowEpisodeCount);
            TPG_TVShow.Controls.Add(TXT_TVShowSeasonNumber);
            TPG_TVShow.Controls.Add(TXT_TVShowHDPrice);
            TPG_TVShow.Controls.Add(LBL_TVShowSeasonID);
            TPG_TVShow.Controls.Add(LBL_TVShowHDPrice);
            TPG_TVShow.Controls.Add(TXT_TVShowSeasonID);
            TPG_TVShow.Controls.Add(TXT_TVShowPrice);
            TPG_TVShow.Controls.Add(LBL_TVShowPrice);
            TPG_TVShow.Location = new Point(4, 24);
            TPG_TVShow.Name = "TPG_TVShow";
            TPG_TVShow.Padding = new Padding(3);
            TPG_TVShow.Size = new Size(395, 394);
            TPG_TVShow.TabIndex = 2;
            TPG_TVShow.Text = "TV Show";
            TPG_TVShow.UseVisualStyleBackColor = true;
            // 
            // TXT_TVShowCountry
            // 
            TXT_TVShowCountry.Location = new Point(106, 298);
            TXT_TVShowCountry.Name = "TXT_TVShowCountry";
            TXT_TVShowCountry.Size = new Size(274, 23);
            TXT_TVShowCountry.TabIndex = 52;
            // 
            // LBL_TVShowCountry
            // 
            LBL_TVShowCountry.AutoSize = true;
            LBL_TVShowCountry.Location = new Point(10, 301);
            LBL_TVShowCountry.Name = "LBL_TVShowCountry";
            LBL_TVShowCountry.Size = new Size(53, 15);
            LBL_TVShowCountry.TabIndex = 51;
            LBL_TVShowCountry.Text = "Country:";
            // 
            // TXT_TVShowRating
            // 
            TXT_TVShowRating.Location = new Point(106, 362);
            TXT_TVShowRating.Name = "TXT_TVShowRating";
            TXT_TVShowRating.Size = new Size(274, 23);
            TXT_TVShowRating.TabIndex = 50;
            // 
            // LBL_TVShowRating
            // 
            LBL_TVShowRating.AutoSize = true;
            LBL_TVShowRating.Location = new Point(10, 365);
            LBL_TVShowRating.Name = "LBL_TVShowRating";
            LBL_TVShowRating.Size = new Size(44, 15);
            LBL_TVShowRating.TabIndex = 49;
            LBL_TVShowRating.Text = "Rating:";
            // 
            // TXT_TVShowGenre
            // 
            TXT_TVShowGenre.Location = new Point(106, 234);
            TXT_TVShowGenre.Name = "TXT_TVShowGenre";
            TXT_TVShowGenre.Size = new Size(274, 23);
            TXT_TVShowGenre.TabIndex = 48;
            // 
            // LBL_TVShowGenre
            // 
            LBL_TVShowGenre.AutoSize = true;
            LBL_TVShowGenre.Location = new Point(9, 237);
            LBL_TVShowGenre.Name = "LBL_TVShowGenre";
            LBL_TVShowGenre.Size = new Size(41, 15);
            LBL_TVShowGenre.TabIndex = 47;
            LBL_TVShowGenre.Text = "Genre:";
            // 
            // TXT_TVShowReleaseDate
            // 
            TXT_TVShowReleaseDate.Location = new Point(106, 330);
            TXT_TVShowReleaseDate.Name = "TXT_TVShowReleaseDate";
            TXT_TVShowReleaseDate.Size = new Size(274, 23);
            TXT_TVShowReleaseDate.TabIndex = 46;
            // 
            // LBL_TVShowReleaseDate
            // 
            LBL_TVShowReleaseDate.AutoSize = true;
            LBL_TVShowReleaseDate.Location = new Point(10, 333);
            LBL_TVShowReleaseDate.Name = "LBL_TVShowReleaseDate";
            LBL_TVShowReleaseDate.Size = new Size(76, 15);
            LBL_TVShowReleaseDate.TabIndex = 45;
            LBL_TVShowReleaseDate.Text = "Release Date:";
            // 
            // TXT_TVShowCopyright
            // 
            TXT_TVShowCopyright.Location = new Point(106, 266);
            TXT_TVShowCopyright.Name = "TXT_TVShowCopyright";
            TXT_TVShowCopyright.Size = new Size(274, 23);
            TXT_TVShowCopyright.TabIndex = 44;
            // 
            // LBL_TVShowCopyright
            // 
            LBL_TVShowCopyright.AutoSize = true;
            LBL_TVShowCopyright.Location = new Point(10, 269);
            LBL_TVShowCopyright.Name = "LBL_TVShowCopyright";
            LBL_TVShowCopyright.Size = new Size(63, 15);
            LBL_TVShowCopyright.TabIndex = 43;
            LBL_TVShowCopyright.Text = "Copyright:";
            // 
            // TXT_TVShowIsExplicit
            // 
            TXT_TVShowIsExplicit.Location = new Point(106, 202);
            TXT_TVShowIsExplicit.Name = "TXT_TVShowIsExplicit";
            TXT_TVShowIsExplicit.Size = new Size(274, 23);
            TXT_TVShowIsExplicit.TabIndex = 42;
            // 
            // TXT_TVShowName
            // 
            TXT_TVShowName.Location = new Point(105, 10);
            TXT_TVShowName.Name = "TXT_TVShowName";
            TXT_TVShowName.Size = new Size(274, 23);
            TXT_TVShowName.TabIndex = 30;
            // 
            // LBL_TVShowIsExplicit
            // 
            LBL_TVShowIsExplicit.AutoSize = true;
            LBL_TVShowIsExplicit.Location = new Point(10, 205);
            LBL_TVShowIsExplicit.Name = "LBL_TVShowIsExplicit";
            LBL_TVShowIsExplicit.Size = new Size(59, 15);
            LBL_TVShowIsExplicit.TabIndex = 41;
            LBL_TVShowIsExplicit.Text = "Is Explicit:";
            // 
            // LBL_TVShowName
            // 
            LBL_TVShowName.AutoSize = true;
            LBL_TVShowName.Location = new Point(9, 13);
            LBL_TVShowName.Name = "LBL_TVShowName";
            LBL_TVShowName.Size = new Size(42, 15);
            LBL_TVShowName.TabIndex = 29;
            LBL_TVShowName.Text = "Name:";
            // 
            // TXT_TVShowEpisodeCount
            // 
            TXT_TVShowEpisodeCount.Location = new Point(106, 170);
            TXT_TVShowEpisodeCount.Name = "TXT_TVShowEpisodeCount";
            TXT_TVShowEpisodeCount.Size = new Size(274, 23);
            TXT_TVShowEpisodeCount.TabIndex = 40;
            // 
            // LBL_TVShowSeasonNumber
            // 
            LBL_TVShowSeasonNumber.AutoSize = true;
            LBL_TVShowSeasonNumber.Location = new Point(9, 45);
            LBL_TVShowSeasonNumber.Name = "LBL_TVShowSeasonNumber";
            LBL_TVShowSeasonNumber.Size = new Size(94, 15);
            LBL_TVShowSeasonNumber.TabIndex = 31;
            LBL_TVShowSeasonNumber.Text = "Season Number:";
            // 
            // LBL_TVShowEpisodeCount
            // 
            LBL_TVShowEpisodeCount.AutoSize = true;
            LBL_TVShowEpisodeCount.Location = new Point(10, 174);
            LBL_TVShowEpisodeCount.Name = "LBL_TVShowEpisodeCount";
            LBL_TVShowEpisodeCount.Size = new Size(87, 15);
            LBL_TVShowEpisodeCount.TabIndex = 39;
            LBL_TVShowEpisodeCount.Text = "Episode Count:";
            // 
            // TXT_TVShowSeasonNumber
            // 
            TXT_TVShowSeasonNumber.Location = new Point(105, 42);
            TXT_TVShowSeasonNumber.Name = "TXT_TVShowSeasonNumber";
            TXT_TVShowSeasonNumber.Size = new Size(274, 23);
            TXT_TVShowSeasonNumber.TabIndex = 32;
            // 
            // TXT_TVShowHDPrice
            // 
            TXT_TVShowHDPrice.Location = new Point(106, 138);
            TXT_TVShowHDPrice.Name = "TXT_TVShowHDPrice";
            TXT_TVShowHDPrice.Size = new Size(274, 23);
            TXT_TVShowHDPrice.TabIndex = 38;
            // 
            // LBL_TVShowSeasonID
            // 
            LBL_TVShowSeasonID.AutoSize = true;
            LBL_TVShowSeasonID.Location = new Point(9, 77);
            LBL_TVShowSeasonID.Name = "LBL_TVShowSeasonID";
            LBL_TVShowSeasonID.Size = new Size(61, 15);
            LBL_TVShowSeasonID.TabIndex = 33;
            LBL_TVShowSeasonID.Text = "Season ID:";
            // 
            // LBL_TVShowHDPrice
            // 
            LBL_TVShowHDPrice.AutoSize = true;
            LBL_TVShowHDPrice.Location = new Point(10, 142);
            LBL_TVShowHDPrice.Name = "LBL_TVShowHDPrice";
            LBL_TVShowHDPrice.Size = new Size(56, 15);
            LBL_TVShowHDPrice.TabIndex = 37;
            LBL_TVShowHDPrice.Text = "HD Price:";
            // 
            // TXT_TVShowSeasonID
            // 
            TXT_TVShowSeasonID.Location = new Point(105, 74);
            TXT_TVShowSeasonID.Name = "TXT_TVShowSeasonID";
            TXT_TVShowSeasonID.Size = new Size(274, 23);
            TXT_TVShowSeasonID.TabIndex = 34;
            // 
            // TXT_TVShowPrice
            // 
            TXT_TVShowPrice.Location = new Point(105, 106);
            TXT_TVShowPrice.Name = "TXT_TVShowPrice";
            TXT_TVShowPrice.Size = new Size(274, 23);
            TXT_TVShowPrice.TabIndex = 36;
            // 
            // LBL_TVShowPrice
            // 
            LBL_TVShowPrice.AutoSize = true;
            LBL_TVShowPrice.Location = new Point(9, 109);
            LBL_TVShowPrice.Name = "LBL_TVShowPrice";
            LBL_TVShowPrice.Size = new Size(36, 15);
            LBL_TVShowPrice.TabIndex = 35;
            LBL_TVShowPrice.Text = "Price:";
            // 
            // GBX_SearchInformation
            // 
            GBX_SearchInformation.Controls.Add(BTN_Clear);
            GBX_SearchInformation.Controls.Add(TXT_CountryCode);
            GBX_SearchInformation.Controls.Add(TXT_SearchLimit);
            GBX_SearchInformation.Controls.Add(LBL_CountryCode);
            GBX_SearchInformation.Controls.Add(LBL_SearchLimit);
            GBX_SearchInformation.Controls.Add(CBX_SearchBy);
            GBX_SearchInformation.Controls.Add(TXT_ContentName);
            GBX_SearchInformation.Controls.Add(LBL_SearchBy);
            GBX_SearchInformation.Controls.Add(LBL_ContentName);
            GBX_SearchInformation.Controls.Add(BTN_ContentSearch);
            GBX_SearchInformation.Location = new Point(7, 2);
            GBX_SearchInformation.Name = "GBX_SearchInformation";
            GBX_SearchInformation.Size = new Size(401, 151);
            GBX_SearchInformation.TabIndex = 0;
            GBX_SearchInformation.TabStop = false;
            GBX_SearchInformation.Text = "Search Information";
            // 
            // BTN_Clear
            // 
            BTN_Clear.Location = new Point(295, 21);
            BTN_Clear.Name = "BTN_Clear";
            BTN_Clear.Size = new Size(91, 24);
            BTN_Clear.TabIndex = 10;
            BTN_Clear.Text = "Clear";
            BTN_Clear.UseVisualStyleBackColor = true;
            BTN_Clear.Click += BTN_Clear_Click;
            // 
            // TXT_CountryCode
            // 
            TXT_CountryCode.Location = new Point(104, 118);
            TXT_CountryCode.Name = "TXT_CountryCode";
            TXT_CountryCode.Size = new Size(182, 23);
            TXT_CountryCode.TabIndex = 9;
            // 
            // TXT_SearchLimit
            // 
            TXT_SearchLimit.Location = new Point(104, 86);
            TXT_SearchLimit.Name = "TXT_SearchLimit";
            TXT_SearchLimit.Size = new Size(182, 23);
            TXT_SearchLimit.TabIndex = 8;
            // 
            // LBL_CountryCode
            // 
            LBL_CountryCode.AutoSize = true;
            LBL_CountryCode.Location = new Point(14, 121);
            LBL_CountryCode.Name = "LBL_CountryCode";
            LBL_CountryCode.Size = new Size(84, 15);
            LBL_CountryCode.TabIndex = 7;
            LBL_CountryCode.Text = "Country Code:";
            // 
            // LBL_SearchLimit
            // 
            LBL_SearchLimit.AutoSize = true;
            LBL_SearchLimit.Location = new Point(14, 89);
            LBL_SearchLimit.Name = "LBL_SearchLimit";
            LBL_SearchLimit.Size = new Size(75, 15);
            LBL_SearchLimit.TabIndex = 5;
            LBL_SearchLimit.Text = "Search Limit:";
            // 
            // CBX_SearchBy
            // 
            CBX_SearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_SearchBy.FormattingEnabled = true;
            CBX_SearchBy.Items.AddRange(new object[] { "Music", "Artist", "Podcast", "Audiobook", "TV Episode", "TV Show" });
            CBX_SearchBy.Location = new Point(104, 54);
            CBX_SearchBy.Name = "CBX_SearchBy";
            CBX_SearchBy.Size = new Size(182, 23);
            CBX_SearchBy.TabIndex = 4;
            // 
            // TXT_ContentName
            // 
            TXT_ContentName.Location = new Point(104, 22);
            TXT_ContentName.Name = "TXT_ContentName";
            TXT_ContentName.Size = new Size(182, 23);
            TXT_ContentName.TabIndex = 3;
            // 
            // LBL_SearchBy
            // 
            LBL_SearchBy.AutoSize = true;
            LBL_SearchBy.Location = new Point(14, 58);
            LBL_SearchBy.Name = "LBL_SearchBy";
            LBL_SearchBy.Size = new Size(61, 15);
            LBL_SearchBy.TabIndex = 2;
            LBL_SearchBy.Text = "Search By:";
            // 
            // LBL_ContentName
            // 
            LBL_ContentName.AutoSize = true;
            LBL_ContentName.Location = new Point(14, 26);
            LBL_ContentName.Name = "LBL_ContentName";
            LBL_ContentName.Size = new Size(38, 15);
            LBL_ContentName.TabIndex = 1;
            LBL_ContentName.Text = "Input:";
            // 
            // BTN_ContentSearch
            // 
            BTN_ContentSearch.Location = new Point(295, 53);
            BTN_ContentSearch.Name = "BTN_ContentSearch";
            BTN_ContentSearch.Size = new Size(91, 24);
            BTN_ContentSearch.TabIndex = 0;
            BTN_ContentSearch.Text = "Search";
            BTN_ContentSearch.UseVisualStyleBackColor = true;
            BTN_ContentSearch.Click += BTN_ContentSearch_Click;
            // 
            // TPG_History
            // 
            TPG_History.Controls.Add(GBX_History);
            TPG_History.Controls.Add(GBX_SearchActions);
            TPG_History.Controls.Add(GBX_HistorySearchInformation);
            TPG_History.Location = new Point(4, 24);
            TPG_History.Name = "TPG_History";
            TPG_History.Padding = new Padding(3);
            TPG_History.Size = new Size(835, 455);
            TPG_History.TabIndex = 1;
            TPG_History.Text = "History";
            TPG_History.UseVisualStyleBackColor = true;
            // 
            // GBX_History
            // 
            GBX_History.Controls.Add(listView1);
            GBX_History.Location = new Point(7, 85);
            GBX_History.Name = "GBX_History";
            GBX_History.Size = new Size(822, 364);
            GBX_History.TabIndex = 1;
            GBX_History.TabStop = false;
            GBX_History.Text = "History";
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 21);
            listView1.Name = "listView1";
            listView1.Size = new Size(810, 336);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // GBX_SearchActions
            // 
            GBX_SearchActions.Location = new Point(381, 2);
            GBX_SearchActions.Name = "GBX_SearchActions";
            GBX_SearchActions.Size = new Size(368, 77);
            GBX_SearchActions.TabIndex = 1;
            GBX_SearchActions.TabStop = false;
            GBX_SearchActions.Text = "Search Actions";
            // 
            // GBX_HistorySearchInformation
            // 
            GBX_HistorySearchInformation.Location = new Point(7, 2);
            GBX_HistorySearchInformation.Name = "GBX_HistorySearchInformation";
            GBX_HistorySearchInformation.Size = new Size(368, 77);
            GBX_HistorySearchInformation.TabIndex = 0;
            GBX_HistorySearchInformation.TabStop = false;
            GBX_HistorySearchInformation.Text = "Search Information";
            // 
            // ITunesSearchUtility
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(854, 493);
            Controls.Add(TCTRL_Main);
            Name = "ITunesSearchUtility";
            Text = "ITunes Search Utility";
            Load += ITunesSearchUtility_Load;
            TCTRL_Main.ResumeLayout(false);
            TPG_Search.ResumeLayout(false);
            GBX_ContentResult.ResumeLayout(false);
            GBX_ContentInformation.ResumeLayout(false);
            TCTRL_InformationSection.ResumeLayout(false);
            TPG_Album.ResumeLayout(false);
            TPG_Album.PerformLayout();
            TPG_Podcast.ResumeLayout(false);
            TPG_Podcast.PerformLayout();
            TPG_TVShow.ResumeLayout(false);
            TPG_TVShow.PerformLayout();
            GBX_SearchInformation.ResumeLayout(false);
            GBX_SearchInformation.PerformLayout();
            TPG_History.ResumeLayout(false);
            GBX_History.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl TCTRL_Main;
        private TabPage TPG_Search;
        private TabPage TPG_History;
        private GroupBox GBX_ContentInformation;
        private GroupBox GBX_ContentResult;
        private ListView LVW_CollectionResults;
        private GroupBox GBX_SearchInformation;
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
        private TextBox TXT_AlbumCopyright;
        private Label LBL_AlbumCopyright;
        private TextBox TXT_AlbumIsExplicit;
        private Label LBL_AlbumIsExplicit;
        private TabControl TCTRL_InformationSection;
        private TabPage TPG_Album;
        private TabPage TPG_Podcast;
        private TextBox TXT_AlbumReleaseDate;
        private Label LBL_AlbumReleaseDate;
        private TextBox TXT_AlbumID;
        private Label LBL_AlbumID;
        private TextBox TXT_AlbumPrice;
        private Label LBL_AlbumPrice;
        private TextBox TXT_AlbumTrackCount;
        private Label LBL_AlbumTrackCount;
        private TextBox TXT_SearchLimit;
        private Label LBL_CountryCode;
        private Label LBL_SearchLimit;
        private TextBox TXT_CountryCode;
        private TextBox TXT_AlbumCountry;
        private Label LBL_AlbumCountry;
        private TextBox TXT_PodcastID;
        private Label LBL_PodcastID;
        private TextBox TXT_PodcastRating;
        private Label LBL_PodcastRating;
        private TextBox TXT_PodcastIsExplicit;
        private Label LBL_PodcastIsExplicit;
        private TextBox TXT_PodcastReleaseDate;
        private Label LBL_PodcastReleaseDate;
        private TextBox TXT_PodcastGenre;
        private Label LBL_PodcastGenre;
        private TextBox TXT_PodcastEpisodeCount;
        private TextBox TXT_PodcastName;
        private Label LBL_PodcastEpisodeCount;
        private Label LBL_PodcastName;
        private TextBox TXT_PodcastDescription;
        private Label LBL_PodcastArtists;
        private Label LBL_PodcastDecription;
        private TextBox TXT_PodcastArtists;
        private TextBox TXT_PodcastCopyright;
        private Label LBL_PodcastArtistID;
        private Label LBL_PodcastCopyright;
        private TextBox TXT_PodcastArtistID;
        private TextBox TXT_PodcastArtistURL;
        private Label LBL_PodcastArtistURL;
        private Button BTN_Clear;
        private GroupBox GBX_HistorySearchInformation;
        private GroupBox GBX_History;
        private ListView listView1;
        private GroupBox GBX_SearchActions;
        private TabPage TPG_TVShow;
        private TextBox TXT_TVShowCountry;
        private Label LBL_TVShowCountry;
        private TextBox TXT_TVShowRating;
        private Label LBL_TVShowRating;
        private TextBox TXT_TVShowGenre;
        private Label LBL_TVShowGenre;
        private TextBox TXT_TVShowReleaseDate;
        private Label LBL_TVShowReleaseDate;
        private TextBox TXT_TVShowCopyright;
        private Label LBL_TVShowCopyright;
        private TextBox TXT_TVShowIsExplicit;
        private TextBox TXT_TVShowName;
        private Label LBL_TVShowIsExplicit;
        private Label LBL_TVShowName;
        private TextBox TXT_TVShowEpisodeCount;
        private Label LBL_TVShowSeasonNumber;
        private Label LBL_TVShowEpisodeCount;
        private TextBox TXT_TVShowSeasonNumber;
        private TextBox TXT_TVShowHDPrice;
        private Label LBL_TVShowSeasonID;
        private Label LBL_TVShowHDPrice;
        private TextBox TXT_TVShowSeasonID;
        private TextBox TXT_TVShowPrice;
        private Label LBL_TVShowPrice;
    }
}