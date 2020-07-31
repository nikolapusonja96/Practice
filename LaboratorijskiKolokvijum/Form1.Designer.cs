namespace LaboratorijskiKolokvijum
{
    partial class Form1
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
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbComposer = new System.Windows.Forms.TextBox();
            this.songPrice = new System.Windows.Forms.NumericUpDown();
            this.ddlAlbum = new System.Windows.Forms.ComboBox();
            this.ddlMediaType = new System.Windows.Forms.ComboBox();
            this.ddlGenre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(28, 12);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.RowHeadersWidth = 51;
            this.dgvSongs.RowTemplate.Height = 24;
            this.dgvSongs.Size = new System.Drawing.Size(760, 223);
            this.dgvSongs.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Song Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Song Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Media Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Genre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Composer";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(533, 306);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(137, 189);
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(54, 335);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 22);
            this.tbName.TabIndex = 9;
            // 
            // tbComposer
            // 
            this.tbComposer.Location = new System.Drawing.Point(265, 473);
            this.tbComposer.Name = "tbComposer";
            this.tbComposer.Size = new System.Drawing.Size(200, 22);
            this.tbComposer.TabIndex = 10;
            // 
            // songPrice
            // 
            this.songPrice.Location = new System.Drawing.Point(54, 404);
            this.songPrice.Name = "songPrice";
            this.songPrice.Size = new System.Drawing.Size(178, 22);
            this.songPrice.TabIndex = 11;
            // 
            // ddlAlbum
            // 
            this.ddlAlbum.FormattingEnabled = true;
            this.ddlAlbum.Location = new System.Drawing.Point(54, 473);
            this.ddlAlbum.Name = "ddlAlbum";
            this.ddlAlbum.Size = new System.Drawing.Size(178, 24);
            this.ddlAlbum.TabIndex = 12;
            // 
            // ddlMediaType
            // 
            this.ddlMediaType.FormattingEnabled = true;
            this.ddlMediaType.Location = new System.Drawing.Point(265, 335);
            this.ddlMediaType.Name = "ddlMediaType";
            this.ddlMediaType.Size = new System.Drawing.Size(200, 24);
            this.ddlMediaType.TabIndex = 13;
            // 
            // ddlGenre
            // 
            this.ddlGenre.FormattingEnabled = true;
            this.ddlGenre.Location = new System.Drawing.Point(265, 404);
            this.ddlGenre.Name = "ddlGenre";
            this.ddlGenre.Size = new System.Drawing.Size(200, 24);
            this.ddlGenre.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.ddlGenre);
            this.Controls.Add(this.ddlMediaType);
            this.Controls.Add(this.ddlAlbum);
            this.Controls.Add(this.songPrice);
            this.Controls.Add(this.tbComposer);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvSongs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbComposer;
        private System.Windows.Forms.NumericUpDown songPrice;
        private System.Windows.Forms.ComboBox ddlAlbum;
        private System.Windows.Forms.ComboBox ddlMediaType;
        private System.Windows.Forms.ComboBox ddlGenre;
    }
}

