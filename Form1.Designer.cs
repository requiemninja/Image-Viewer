namespace Imageviewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblIcon = new System.Windows.Forms.Label();
            this.pIcon = new System.Windows.Forms.PictureBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Main = new System.Windows.Forms.TabControl();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIcon)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnBrowse);
            this.tabPage5.Controls.Add(this.btnSave);
            this.tabPage5.Controls.Add(this.lblIcon);
            this.tabPage5.Controls.Add(this.pIcon);
            this.tabPage5.Controls.Add(this.txtFilename);
            this.tabPage5.Controls.Add(this.lblFilename);
            this.tabPage5.Controls.Add(this.listView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(986, 591);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Icon<->Image";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(746, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 22);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(512, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save As Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(509, 46);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(90, 16);
            this.lblIcon.TabIndex = 11;
            this.lblIcon.Text = "Selected Icon";
            // 
            // pIcon
            // 
            this.pIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pIcon.Location = new System.Drawing.Point(512, 72);
            this.pIcon.Name = "pIcon";
            this.pIcon.Size = new System.Drawing.Size(100, 100);
            this.pIcon.TabIndex = 10;
            this.pIcon.TabStop = false;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(569, 14);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(171, 22);
            this.txtFilename.TabIndex = 9;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(500, 14);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(73, 16);
            this.lblFilename.TabIndex = 8;
            this.lblFilename.Text = "File Name:";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.ShowItemToolTips = true;
            this.listView2.Size = new System.Drawing.Size(287, 585);
            this.listView2.TabIndex = 7;
            this.listView2.TileSize = new System.Drawing.Size(168, 168);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.VirtualListSize = 10;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(986, 591);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Image Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 578);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Information";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Location = new System.Drawing.Point(6, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(964, 551);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.menuStrip1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 591);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Viewer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(980, 561);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.tabPage1);
            this.Main.Controls.Add(this.tabPage3);
            this.Main.Controls.Add(this.tabPage4);
            this.Main.Controls.Add(this.tabPage5);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(994, 617);
            this.Main.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Main.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(994, 617);
            this.Controls.Add(this.Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pIcon)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.PictureBox pIcon;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Main;

    }
}

