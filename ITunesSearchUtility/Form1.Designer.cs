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
            this.GBX_ContentInformation = new System.Windows.Forms.GroupBox();
            this.TXT_ArtistURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_ArtistID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Artists = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBX_ContentResult = new System.Windows.Forms.GroupBox();
            this.LVW_CollectionResults = new System.Windows.Forms.ListView();
            this.CHDR_ContentName = new System.Windows.Forms.ColumnHeader();
            this.CHDR_Artists = new System.Windows.Forms.ColumnHeader();
            this.GBX_SearchInput = new System.Windows.Forms.GroupBox();
            this.CBX_ContentType = new System.Windows.Forms.ComboBox();
            this.TXT_ContentName = new System.Windows.Forms.TextBox();
            this.LBL_ContentType = new System.Windows.Forms.Label();
            this.LBL_ContentName = new System.Windows.Forms.Label();
            this.BTN_ContentSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TCTRL_Main.SuspendLayout();
            this.TPG_Search.SuspendLayout();
            this.GBX_ContentInformation.SuspendLayout();
            this.GBX_ContentResult.SuspendLayout();
            this.GBX_SearchInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCTRL_Main
            // 
            this.TCTRL_Main.Controls.Add(this.TPG_Search);
            this.TCTRL_Main.Controls.Add(this.tabPage2);
            this.TCTRL_Main.Location = new System.Drawing.Point(5, 4);
            this.TCTRL_Main.Name = "TCTRL_Main";
            this.TCTRL_Main.SelectedIndex = 0;
            this.TCTRL_Main.Size = new System.Drawing.Size(821, 477);
            this.TCTRL_Main.TabIndex = 6;
            // 
            // TPG_Search
            // 
            this.TPG_Search.Controls.Add(this.GBX_ContentInformation);
            this.TPG_Search.Controls.Add(this.GBX_ContentResult);
            this.TPG_Search.Controls.Add(this.GBX_SearchInput);
            this.TPG_Search.Location = new System.Drawing.Point(4, 24);
            this.TPG_Search.Name = "TPG_Search";
            this.TPG_Search.Padding = new System.Windows.Forms.Padding(3);
            this.TPG_Search.Size = new System.Drawing.Size(813, 449);
            this.TPG_Search.TabIndex = 0;
            this.TPG_Search.Text = "Search";
            this.TPG_Search.UseVisualStyleBackColor = true;
            // 
            // GBX_ContentInformation
            // 
            this.GBX_ContentInformation.Controls.Add(this.TXT_ArtistURL);
            this.GBX_ContentInformation.Controls.Add(this.label3);
            this.GBX_ContentInformation.Controls.Add(this.TXT_ArtistID);
            this.GBX_ContentInformation.Controls.Add(this.label4);
            this.GBX_ContentInformation.Controls.Add(this.TXT_Artists);
            this.GBX_ContentInformation.Controls.Add(this.label2);
            this.GBX_ContentInformation.Controls.Add(this.TXT_Name);
            this.GBX_ContentInformation.Controls.Add(this.label1);
            this.GBX_ContentInformation.Location = new System.Drawing.Point(414, 2);
            this.GBX_ContentInformation.Name = "GBX_ContentInformation";
            this.GBX_ContentInformation.Size = new System.Drawing.Size(393, 330);
            this.GBX_ContentInformation.TabIndex = 2;
            this.GBX_ContentInformation.TabStop = false;
            this.GBX_ContentInformation.Text = "Content Information";
            // 
            // TXT_ArtistURL
            // 
            this.TXT_ArtistURL.Location = new System.Drawing.Point(103, 120);
            this.TXT_ArtistURL.Name = "TXT_ArtistURL";
            this.TXT_ArtistURL.Size = new System.Drawing.Size(278, 23);
            this.TXT_ArtistURL.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Artist URL:";
            // 
            // TXT_ArtistID
            // 
            this.TXT_ArtistID.Location = new System.Drawing.Point(103, 88);
            this.TXT_ArtistID.Name = "TXT_ArtistID";
            this.TXT_ArtistID.Size = new System.Drawing.Size(278, 23);
            this.TXT_ArtistID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Artist ID:";
            // 
            // TXT_Artists
            // 
            this.TXT_Artists.Location = new System.Drawing.Point(103, 56);
            this.TXT_Artists.Name = "TXT_Artists";
            this.TXT_Artists.Size = new System.Drawing.Size(278, 23);
            this.TXT_Artists.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artists:";
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(103, 24);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(278, 23);
            this.TXT_Name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // GBX_ContentResult
            // 
            this.GBX_ContentResult.Controls.Add(this.LVW_CollectionResults);
            this.GBX_ContentResult.Location = new System.Drawing.Point(7, 100);
            this.GBX_ContentResult.Name = "GBX_ContentResult";
            this.GBX_ContentResult.Size = new System.Drawing.Size(401, 232);
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
            this.LVW_CollectionResults.Location = new System.Drawing.Point(6, 19);
            this.LVW_CollectionResults.MultiSelect = false;
            this.LVW_CollectionResults.Name = "LVW_CollectionResults";
            this.LVW_CollectionResults.Size = new System.Drawing.Size(389, 204);
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
            // GBX_SearchInput
            // 
            this.GBX_SearchInput.Controls.Add(this.CBX_ContentType);
            this.GBX_SearchInput.Controls.Add(this.TXT_ContentName);
            this.GBX_SearchInput.Controls.Add(this.LBL_ContentType);
            this.GBX_SearchInput.Controls.Add(this.LBL_ContentName);
            this.GBX_SearchInput.Controls.Add(this.BTN_ContentSearch);
            this.GBX_SearchInput.Location = new System.Drawing.Point(7, 2);
            this.GBX_SearchInput.Name = "GBX_SearchInput";
            this.GBX_SearchInput.Size = new System.Drawing.Size(401, 95);
            this.GBX_SearchInput.TabIndex = 0;
            this.GBX_SearchInput.TabStop = false;
            this.GBX_SearchInput.Text = "Search Input";
            // 
            // CBX_ContentType
            // 
            this.CBX_ContentType.FormattingEnabled = true;
            this.CBX_ContentType.Items.AddRange(new object[] {
            "Album"});
            this.CBX_ContentType.Location = new System.Drawing.Point(107, 56);
            this.CBX_ContentType.Name = "CBX_ContentType";
            this.CBX_ContentType.Size = new System.Drawing.Size(169, 23);
            this.CBX_ContentType.TabIndex = 4;
            // 
            // TXT_ContentName
            // 
            this.TXT_ContentName.Location = new System.Drawing.Point(107, 23);
            this.TXT_ContentName.Name = "TXT_ContentName";
            this.TXT_ContentName.Size = new System.Drawing.Size(278, 23);
            this.TXT_ContentName.TabIndex = 3;
            // 
            // LBL_ContentType
            // 
            this.LBL_ContentType.AutoSize = true;
            this.LBL_ContentType.Location = new System.Drawing.Point(13, 59);
            this.LBL_ContentType.Name = "LBL_ContentType";
            this.LBL_ContentType.Size = new System.Drawing.Size(80, 15);
            this.LBL_ContentType.TabIndex = 2;
            this.LBL_ContentType.Text = "Content Type:";
            // 
            // LBL_ContentName
            // 
            this.LBL_ContentName.AutoSize = true;
            this.LBL_ContentName.Location = new System.Drawing.Point(13, 27);
            this.LBL_ContentName.Name = "LBL_ContentName";
            this.LBL_ContentName.Size = new System.Drawing.Size(88, 15);
            this.LBL_ContentName.TabIndex = 1;
            this.LBL_ContentName.Text = "Content Name:";
            // 
            // BTN_ContentSearch
            // 
            this.BTN_ContentSearch.Location = new System.Drawing.Point(294, 55);
            this.BTN_ContentSearch.Name = "BTN_ContentSearch";
            this.BTN_ContentSearch.Size = new System.Drawing.Size(91, 24);
            this.BTN_ContentSearch.TabIndex = 0;
            this.BTN_ContentSearch.Text = "Search";
            this.BTN_ContentSearch.UseVisualStyleBackColor = true;
            this.BTN_ContentSearch.Click += new System.EventHandler(this.BTN_ContentSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ITunesSearchUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 485);
            this.Controls.Add(this.TCTRL_Main);
            this.Name = "ITunesSearchUtility";
            this.Text = "ITunes Search Utility";
            this.Load += new System.EventHandler(this.ITunesSearchUtility_Load);
            this.TCTRL_Main.ResumeLayout(false);
            this.TPG_Search.ResumeLayout(false);
            this.GBX_ContentInformation.ResumeLayout(false);
            this.GBX_ContentInformation.PerformLayout();
            this.GBX_ContentResult.ResumeLayout(false);
            this.GBX_SearchInput.ResumeLayout(false);
            this.GBX_SearchInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl TCTRL_Main;
        private TabPage TPG_Search;
        private TabPage tabPage2;
        private GroupBox GBX_ContentInformation;
        private GroupBox GBX_ContentResult;
        private ListView LVW_CollectionResults;
        private GroupBox GBX_SearchInput;
        private ComboBox CBX_ContentType;
        private TextBox TXT_ContentName;
        private Label LBL_ContentType;
        private Label LBL_ContentName;
        private Button BTN_ContentSearch;
        private ColumnHeader CHDR_ContentName;
        private ColumnHeader CHDR_Artists;
        private TextBox TXT_ArtistURL;
        private Label label3;
        private TextBox TXT_ArtistID;
        private Label label4;
        private TextBox TXT_Artists;
        private Label label2;
        private TextBox TXT_Name;
        private Label label1;
    }
}