
namespace FİLM_ARŞİVİ
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxizlendi = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lbllink = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btntamekran = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnfilmekle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnkucult = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbllink);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnfilmekle);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.txtkategori);
            this.panel1.Controls.Add(this.btnkucult);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxizlendi);
            this.panel1.Controls.Add(this.btntamekran);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 778);
            this.panel1.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.BackColor = System.Drawing.Color.Silver;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Location = new System.Drawing.Point(637, 62);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(79, 27);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Watched:";
            // 
            // cbxizlendi
            // 
            this.cbxizlendi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxizlendi.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxizlendi.Checked = false;
            this.cbxizlendi.CheckedOnColor = System.Drawing.Color.Blue;
            this.cbxizlendi.ForeColor = System.Drawing.Color.White;
            this.cbxizlendi.Location = new System.Drawing.Point(610, 64);
            this.cbxizlendi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxizlendi.Name = "cbxizlendi";
            this.cbxizlendi.Size = new System.Drawing.Size(20, 20);
            this.cbxizlendi.TabIndex = 10;
            this.cbxizlendi.OnChange += new System.EventHandler(this.cbxizlendi_OnChange);
            // 
            // txtkategori
            // 
            this.txtkategori.BackColor = System.Drawing.Color.Black;
            this.txtkategori.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkategori.ForeColor = System.Drawing.Color.White;
            this.txtkategori.Location = new System.Drawing.Point(344, 62);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(169, 25);
            this.txtkategori.TabIndex = 9;
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.Color.Black;
            this.txtad.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.ForeColor = System.Drawing.Color.White;
            this.txtad.Location = new System.Drawing.Point(147, 62);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(191, 25);
            this.txtad.TabIndex = 8;
            // 
            // lbllink
            // 
            this.lbllink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbllink.AutoSize = true;
            this.lbllink.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllink.ForeColor = System.Drawing.Color.DimGray;
            this.lbllink.Location = new System.Drawing.Point(174, 2);
            this.lbllink.Name = "lbllink";
            this.lbllink.Size = new System.Drawing.Size(0, 16);
            this.lbllink.TabIndex = 7;
            this.lbllink.Visible = false;
            // 
            // btntamekran
            // 
            this.btntamekran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btntamekran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntamekran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntamekran.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntamekran.ForeColor = System.Drawing.Color.White;
            this.btntamekran.Image = ((System.Drawing.Image)(resources.GetObject("btntamekran.Image")));
            this.btntamekran.Location = new System.Drawing.Point(947, 57);
            this.btntamekran.Name = "btntamekran";
            this.btntamekran.Size = new System.Drawing.Size(36, 36);
            this.btntamekran.TabIndex = 6;
            this.btntamekran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntamekran.UseVisualStyleBackColor = true;
            this.btntamekran.Click += new System.EventHandler(this.btntamekran_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.Location = new System.Drawing.Point(1174, 57);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(119, 36);
            this.btnrefresh.TabIndex = 5;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnfilmekle
            // 
            this.btnfilmekle.ActiveBorderThickness = 1;
            this.btnfilmekle.ActiveCornerRadius = 20;
            this.btnfilmekle.ActiveFillColor = System.Drawing.Color.Indigo;
            this.btnfilmekle.ActiveForecolor = System.Drawing.Color.White;
            this.btnfilmekle.ActiveLineColor = System.Drawing.Color.Black;
            this.btnfilmekle.BackColor = System.Drawing.Color.Transparent;
            this.btnfilmekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfilmekle.BackgroundImage")));
            this.btnfilmekle.ButtonText = "Add Movies";
            this.btnfilmekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfilmekle.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfilmekle.ForeColor = System.Drawing.Color.Gold;
            this.btnfilmekle.IdleBorderThickness = 1;
            this.btnfilmekle.IdleCornerRadius = 20;
            this.btnfilmekle.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnfilmekle.IdleForecolor = System.Drawing.Color.Black;
            this.btnfilmekle.IdleLineColor = System.Drawing.Color.Black;
            this.btnfilmekle.Location = new System.Drawing.Point(9, 53);
            this.btnfilmekle.Margin = new System.Windows.Forms.Padding(5);
            this.btnfilmekle.Name = "btnfilmekle";
            this.btnfilmekle.Size = new System.Drawing.Size(130, 41);
            this.btnfilmekle.TabIndex = 4;
            this.btnfilmekle.Tag = "";
            this.btnfilmekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnfilmekle.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(372, 729);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(584, 16);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Copyright 2021 Aydemir NET All Rights Reserved | Desing by Kadir Aydemir";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.ForeColor = System.Drawing.Color.LightSalmon;
            this.groupBox2.Location = new System.Drawing.Point(1001, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 596);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MOVIE LIST";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(286, 570);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1308, 36);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1227, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 27);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1269, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Location = new System.Drawing.Point(9, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SCREEN";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(968, 570);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnkucult
            // 
            this.btnkucult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkucult.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnkucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkucult.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkucult.ForeColor = System.Drawing.Color.White;
            this.btnkucult.Image = ((System.Drawing.Image)(resources.GetObject("btnkucult.Image")));
            this.btnkucult.Location = new System.Drawing.Point(905, 57);
            this.btnkucult.Name = "btnkucult";
            this.btnkucult.Size = new System.Drawing.Size(36, 36);
            this.btnkucult.TabIndex = 13;
            this.btnkucult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkucult.UseVisualStyleBackColor = true;
            this.btnkucult.Visible = false;
            this.btnkucult.Click += new System.EventHandler(this.btnkucult_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.RosyBrown;
            this.linkLabel1.Location = new System.Drawing.Point(546, 753);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About Me";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnkucult;
            this.ClientSize = new System.Drawing.Size(1308, 778);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnfilmekle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btntamekran;
        private Bunifu.Framework.UI.BunifuCustomLabel lbllink;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox cbxizlendi;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnkucult;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

