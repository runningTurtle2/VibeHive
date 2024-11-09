namespace AlbumInventoryClient
{
    partial class Form_Album_Inventory
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
            btn_AddAlbum = new Button();
            btn_UpdateAlbum = new Button();
            btn_DeleteAlbum = new Button();
            textBox_Title = new TextBox();
            textBox_Genre = new TextBox();
            textBox_Year = new TextBox();
            textBox_ID = new TextBox();
            label1_Add = new Label();
            label2_Add = new Label();
            label3_Add = new Label();
            label1_Delete = new Label();
            listView1 = new ListView();
            ch_Id = new ColumnHeader();
            ch_Title = new ColumnHeader();
            ch_Genre = new ColumnHeader();
            ch_Year = new ColumnHeader();
            ch_Available = new ColumnHeader();
            SuspendLayout();
            // 
            // btn_AddAlbum
            // 
            btn_AddAlbum.Location = new Point(44, 87);
            btn_AddAlbum.Name = "btn_AddAlbum";
            btn_AddAlbum.Size = new Size(85, 23);
            btn_AddAlbum.TabIndex = 0;
            btn_AddAlbum.Text = "Add";
            btn_AddAlbum.UseVisualStyleBackColor = true;
            btn_AddAlbum.Click += btn_AddAlbum_Click;
            // 
            // btn_UpdateAlbum
            // 
            btn_UpdateAlbum.Location = new Point(44, 197);
            btn_UpdateAlbum.Name = "btn_UpdateAlbum";
            btn_UpdateAlbum.Size = new Size(85, 23);
            btn_UpdateAlbum.TabIndex = 2;
            btn_UpdateAlbum.Text = "Update";
            btn_UpdateAlbum.UseVisualStyleBackColor = true;
            btn_UpdateAlbum.Click += btn_UpdateAlbum_Click;
            // 
            // btn_DeleteAlbum
            // 
            btn_DeleteAlbum.Location = new Point(44, 360);
            btn_DeleteAlbum.Name = "btn_DeleteAlbum";
            btn_DeleteAlbum.Size = new Size(85, 23);
            btn_DeleteAlbum.TabIndex = 3;
            btn_DeleteAlbum.Text = "Delete";
            btn_DeleteAlbum.UseVisualStyleBackColor = true;
            btn_DeleteAlbum.Click += btn_DeleteAlbum_Click;
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(162, 87);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(100, 23);
            textBox_Title.TabIndex = 4;
            // 
            // textBox_Genre
            // 
            textBox_Genre.Location = new Point(162, 146);
            textBox_Genre.Name = "textBox_Genre";
            textBox_Genre.Size = new Size(100, 23);
            textBox_Genre.TabIndex = 5;
            // 
            // textBox_Year
            // 
            textBox_Year.Location = new Point(162, 198);
            textBox_Year.Name = "textBox_Year";
            textBox_Year.Size = new Size(100, 23);
            textBox_Year.TabIndex = 6;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(162, 360);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(100, 23);
            textBox_ID.TabIndex = 10;
            // 
            // label1_Add
            // 
            label1_Add.AutoSize = true;
            label1_Add.Location = new Point(162, 69);
            label1_Add.Name = "label1_Add";
            label1_Add.Size = new Size(29, 15);
            label1_Add.TabIndex = 11;
            label1_Add.Text = "Title";
            // 
            // label2_Add
            // 
            label2_Add.AutoSize = true;
            label2_Add.Location = new Point(162, 128);
            label2_Add.Name = "label2_Add";
            label2_Add.Size = new Size(38, 15);
            label2_Add.TabIndex = 12;
            label2_Add.Text = "Genre";
            // 
            // label3_Add
            // 
            label3_Add.AutoSize = true;
            label3_Add.Location = new Point(162, 180);
            label3_Add.Name = "label3_Add";
            label3_Add.Size = new Size(29, 15);
            label3_Add.TabIndex = 13;
            label3_Add.Text = "Year";
            // 
            // label1_Delete
            // 
            label1_Delete.AutoSize = true;
            label1_Delete.Location = new Point(162, 342);
            label1_Delete.Name = "label1_Delete";
            label1_Delete.Size = new Size(18, 15);
            label1_Delete.TabIndex = 17;
            label1_Delete.Text = "ID";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ch_Id, ch_Title, ch_Genre, ch_Year, ch_Available });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(317, 69);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(425, 355);
            listView1.TabIndex = 18;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ch_Id
            // 
            ch_Id.Text = "Id";
            // 
            // ch_Title
            // 
            ch_Title.Text = "Title";
            // 
            // ch_Genre
            // 
            ch_Genre.Text = "Genre";
            // 
            // ch_Year
            // 
            ch_Year.Text = "Year";
            // 
            // ch_Available
            // 
            ch_Available.Text = "Available";
            // 
            // Form_Album_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 453);
            Controls.Add(listView1);
            Controls.Add(label1_Delete);
            Controls.Add(label3_Add);
            Controls.Add(label2_Add);
            Controls.Add(label1_Add);
            Controls.Add(textBox_ID);
            Controls.Add(textBox_Year);
            Controls.Add(textBox_Genre);
            Controls.Add(textBox_Title);
            Controls.Add(btn_DeleteAlbum);
            Controls.Add(btn_UpdateAlbum);
            Controls.Add(btn_AddAlbum);
            Name = "Form_Album_Inventory";
            Text = "Album Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddAlbum;
        private Button btn_UpdateAlbum;
        private Button btn_DeleteAlbum;
        private TextBox textBox_Title;
        private TextBox textBox_Genre;
        private TextBox textBox_Year;
        private TextBox textBox_ID;
        private Label label1_Add;
        private Label label2_Add;
        private Label label3_Add;
        private Label label1_Delete;
        private ListView listView1;
        private ColumnHeader ch_Id;
        private ColumnHeader ch_Title;
        private ColumnHeader ch_Genre;
        private ColumnHeader ch_Year;
        private ColumnHeader ch_Available;
    }
}
