namespace MusicRentalApp
{
    partial class MusicRentalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.btnListAlbums = new System.Windows.Forms.Button();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.btnRentAlbum = new System.Windows.Forms.Button();
            this.nudUserId = new System.Windows.Forms.NumericUpDown();
            this.lstActiveRentals = new System.Windows.Forms.ListBox();
            this.btnReturnAlbum = new System.Windows.Forms.Button();
            this.btnViewActiveRentals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(120, 60);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(200, 20);
            this.txtArtist.TabIndex = 1;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(120, 90);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(200, 20);
            this.txtGenre.TabIndex = 2;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(120, 120);
            this.nudYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(200, 20);
            this.nudYear.TabIndex = 3;
            this.nudYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(120, 150);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(100, 30);
            this.btnAddAlbum.TabIndex = 4;
            this.btnAddAlbum.Text = "Add Album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // btnListAlbums
            // 
            this.btnListAlbums.Location = new System.Drawing.Point(120, 190);
            this.btnListAlbums.Name = "btnListAlbums";
            this.btnListAlbums.Size = new System.Drawing.Size(100, 30);
            this.btnListAlbums.TabIndex = 5;
            this.btnListAlbums.Text = "List Albums";
            this.btnListAlbums.UseVisualStyleBackColor = true;
            this.btnListAlbums.Click += new System.EventHandler(this.btnListAlbums_Click);
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.Location = new System.Drawing.Point(120, 230);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(200, 95);
            this.lstAlbums.TabIndex = 6;
            // 
            // btnRentAlbum
            // 
            this.btnRentAlbum.Location = new System.Drawing.Point(120, 350);
            this.btnRentAlbum.Name = "btnRentAlbum";
            this.btnRentAlbum.Size = new System.Drawing.Size(100, 30);
            this.btnRentAlbum.TabIndex = 7;
            this.btnRentAlbum.Text = "Rent Album";
            this.btnRentAlbum.UseVisualStyleBackColor = true;
            this.btnRentAlbum.Click += new System.EventHandler(this.btnRentAlbum_Click);
            // 
            // nudUserId
            // 
            this.nudUserId.Location = new System.Drawing.Point(120, 310);
            this.nudUserId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUserId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUserId.Name = "nudUserId";
            this.nudUserId.Size = new System.Drawing.Size(200, 20);
            this.nudUserId.TabIndex = 8;
            this.nudUserId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstActiveRentals
            // 
            this.lstActiveRentals.FormattingEnabled = true;
            this.lstActiveRentals.Location = new System.Drawing.Point(380, 30);
            this.lstActiveRentals.Name = "lstActiveRentals";
            this.lstActiveRentals.Size = new System.Drawing.Size(200, 95);
            this.lstActiveRentals.TabIndex = 9;
            // 
            // btnReturnAlbum
            // 
            this.btnReturnAlbum.Location = new System.Drawing.Point(380, 150);
            this.btnReturnAlbum.Name = "btnReturnAlbum";
            this.btnReturnAlbum.Size = new System.Drawing.Size(100, 30);
            this.btnReturnAlbum.TabIndex = 10;
            this.btnReturnAlbum.Text = "Return Album";
            this.btnReturnAlbum.UseVisualStyleBackColor = true;
            this.btnReturnAlbum.Click += new System.EventHandler(this.btnReturnAlbum_Click);
            // 
            // btnViewActiveRentals
            // 
            this.btnViewActiveRentals.Location = new System.Drawing.Point(380, 190);
            this.btnViewActiveRentals.Name = "btnViewActiveRentals";
            this.btnViewActiveRentals.Size = new System.Drawing.Size(150, 30);
            this.btnViewActiveRentals.TabIndex = 11;
            this.btnViewActiveRentals.Text = "View Active Rentals";
            this.btnViewActiveRentals.UseVisualStyleBackColor = true;
            this.btnViewActiveRentals.Click += new System.EventHandler(this.btnViewActiveRentals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Artist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "User ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Active Rentals:";
            // 
            // MusicRentalForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewActiveRentals);
            this.Controls.Add(this.btnReturnAlbum);
            this.Controls.Add(this.lstActiveRentals);
            this.Controls.Add(this.nudUserId);
            this.Controls.Add(this.btnRentAlbum);
            this.Controls.Add(this.lstAlbums);
            this.Controls.Add(this.btnListAlbums);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Name = "MusicRentalForm";
            this.Text = "Music Rental App";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Button btnListAlbums;
        private System.Windows.Forms.ListBox lstAlbums;
        private System.Windows.Forms.Button btnRentAlbum;
        private System.Windows.Forms.NumericUpDown nudUserId;
        private System.Windows.Forms.ListBox lstActiveRentals;
        private System.Windows.Forms.Button btnReturnAlbum;
        private System.Windows.Forms.Button btnViewActiveRentals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


