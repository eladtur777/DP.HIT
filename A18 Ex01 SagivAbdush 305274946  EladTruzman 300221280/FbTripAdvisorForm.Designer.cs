﻿namespace A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280
{
    partial class FbTripAdvisorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewLocationsFriends = new System.Windows.Forms.DataGridView();
            this.Friend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewFriendsComments = new System.Windows.Forms.DataGridView();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearchResults = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBoxSearchFromList = new System.Windows.Forms.CheckBox();
            this.checkBoxFreeTextSearch = new System.Windows.Forms.CheckBox();
            this.txtBoxFreeText = new System.Windows.Forms.TextBox();
            this.btnFreeText = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocationsFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendsComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(127, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your trip location/s and found out the hottest places by your friends on F" +
    "aceBook";
            // 
            // dataGridViewLocationsFriends
            // 
            this.dataGridViewLocationsFriends.AllowUserToDeleteRows = false;
            this.dataGridViewLocationsFriends.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewLocationsFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocationsFriends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Friend,
            this.Location,
            this.Post});
            this.dataGridViewLocationsFriends.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLocationsFriends.Name = "dataGridViewLocationsFriends";
            this.dataGridViewLocationsFriends.ReadOnly = true;
            this.dataGridViewLocationsFriends.Size = new System.Drawing.Size(343, 319);
            this.dataGridViewLocationsFriends.TabIndex = 6;
            this.dataGridViewLocationsFriends.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocationsFriends_CellContentClick);
            // 
            // Friend
            // 
            this.Friend.HeaderText = "Friend";
            this.Friend.Name = "Friend";
            this.Friend.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.HeaderText = "Post";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(29, 40);
            this.txtBoxSearch.MaxLength = 50;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(203, 20);
            this.txtBoxSearch.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 193);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewLocationsFriends);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewFriendsComments);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(891, 319);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 10;
            // 
            // dataGridViewFriendsComments
            // 
            this.dataGridViewFriendsComments.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewFriendsComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriendsComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comments});
            this.dataGridViewFriendsComments.Location = new System.Drawing.Point(3, 171);
            this.dataGridViewFriendsComments.Name = "dataGridViewFriendsComments";
            this.dataGridViewFriendsComments.Size = new System.Drawing.Size(343, 148);
            this.dataGridViewFriendsComments.TabIndex = 11;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.Width = 300;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.Properties.Resources.Map;
            this.pictureBox3.Location = new System.Drawing.Point(360, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Friends Comments";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(430, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 70);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // comboBoxSearchResults
            // 
            this.comboBoxSearchResults.AllowDrop = true;
            this.comboBoxSearchResults.BackColor = System.Drawing.Color.White;
            this.comboBoxSearchResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchResults.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxSearchResults.FormattingEnabled = true;
            this.comboBoxSearchResults.ItemHeight = 13;
            this.comboBoxSearchResults.Location = new System.Drawing.Point(3, 69);
            this.comboBoxSearchResults.MaxDropDownItems = 15;
            this.comboBoxSearchResults.Name = "comboBoxSearchResults";
            this.comboBoxSearchResults.Size = new System.Drawing.Size(229, 21);
            this.comboBoxSearchResults.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 20);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.Properties.Resources.SearchIcon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(2, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "GO!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkBoxSearchFromList
            // 
            this.checkBoxSearchFromList.AutoSize = true;
            this.checkBoxSearchFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSearchFromList.ForeColor = System.Drawing.Color.White;
            this.checkBoxSearchFromList.Location = new System.Drawing.Point(3, 13);
            this.checkBoxSearchFromList.Name = "checkBoxSearchFromList";
            this.checkBoxSearchFromList.Size = new System.Drawing.Size(141, 21);
            this.checkBoxSearchFromList.TabIndex = 15;
            this.checkBoxSearchFromList.Text = "Search from list";
            this.checkBoxSearchFromList.UseVisualStyleBackColor = true;
            this.checkBoxSearchFromList.CheckedChanged += new System.EventHandler(this.checkBoxSearchFromList_CheckedChanged);
            // 
            // checkBoxFreeTextSearch
            // 
            this.checkBoxFreeTextSearch.AutoSize = true;
            this.checkBoxFreeTextSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFreeTextSearch.ForeColor = System.Drawing.Color.White;
            this.checkBoxFreeTextSearch.Location = new System.Drawing.Point(3, 13);
            this.checkBoxFreeTextSearch.Name = "checkBoxFreeTextSearch";
            this.checkBoxFreeTextSearch.Size = new System.Drawing.Size(145, 21);
            this.checkBoxFreeTextSearch.TabIndex = 16;
            this.checkBoxFreeTextSearch.Text = "Free text search";
            this.checkBoxFreeTextSearch.UseVisualStyleBackColor = true;
            this.checkBoxFreeTextSearch.CheckedChanged += new System.EventHandler(this.checkBoxFreeTextSearch_CheckedChanged);
            // 
            // txtBoxFreeText
            // 
            this.txtBoxFreeText.Location = new System.Drawing.Point(3, 40);
            this.txtBoxFreeText.Name = "txtBoxFreeText";
            this.txtBoxFreeText.Size = new System.Drawing.Size(190, 20);
            this.txtBoxFreeText.TabIndex = 17;
            // 
            // btnFreeText
            // 
            this.btnFreeText.Location = new System.Drawing.Point(3, 97);
            this.btnFreeText.Name = "btnFreeText";
            this.btnFreeText.Size = new System.Drawing.Size(75, 23);
            this.btnFreeText.TabIndex = 18;
            this.btnFreeText.Text = "GO!";
            this.btnFreeText.UseVisualStyleBackColor = true;
            this.btnFreeText.Click += new System.EventHandler(this.btnFreeText_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(318, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 35);
            this.label8.TabIndex = 19;
            this.label8.Text = "FaceBook TripAdvisor";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(1, 51);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxSearchResults);
            this.splitContainer2.Panel1.Controls.Add(this.txtBoxSearch);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxSearchFromList);
            this.splitContainer2.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer2.Panel2.Controls.Add(this.checkBoxFreeTextSearch);
            this.splitContainer2.Panel2.Controls.Add(this.txtBoxFreeText);
            this.splitContainer2.Panel2.Controls.Add(this.btnFreeText);
            this.splitContainer2.Size = new System.Drawing.Size(891, 123);
            this.splitContainer2.SplitterDistance = 345;
            this.splitContainer2.TabIndex = 20;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::A18_Ex01_SagivAbdush_305274946__EladTruzman_300221280.Properties.Resources.TripAdvisorLogo;
            this.pictureBox4.Location = new System.Drawing.Point(212, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // FbTripAdvisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(892, 513);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FbTripAdvisorForm";
            this.Text = "FaceBook Trip Advisor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocationsFriends)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendsComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewLocationsFriends;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBoxSearchResults;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewImageColumn Post;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewFriendsComments;
        private System.Windows.Forms.CheckBox checkBoxSearchFromList;
        private System.Windows.Forms.CheckBox checkBoxFreeTextSearch;
        private System.Windows.Forms.TextBox txtBoxFreeText;
        private System.Windows.Forms.Button btnFreeText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}