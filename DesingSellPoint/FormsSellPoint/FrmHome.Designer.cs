namespace DesingSellPoint.FormsSellPoint
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlSystem = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.PnlArchive = new System.Windows.Forms.Panel();
            this.btnEntities = new System.Windows.Forms.Button();
            this.btnEntityTypes = new System.Windows.Forms.Button();
            this.btnGroupEntities = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ptbHome = new System.Windows.Forms.PictureBox();
            this.pnlChildren = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PnlSystem.SuspendLayout();
            this.PnlArchive.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.PnlSystem);
            this.panel1.Controls.Add(this.btnSystem);
            this.panel1.Controls.Add(this.PnlArchive);
            this.panel1.Controls.Add(this.btnArchive);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.ptbHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 544);
            this.panel1.TabIndex = 1;
            // 
            // PnlSystem
            // 
            this.PnlSystem.Controls.Add(this.btnExit);
            this.PnlSystem.Controls.Add(this.btnLogin);
            this.PnlSystem.Controls.Add(this.btnAbout);
            this.PnlSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSystem.Location = new System.Drawing.Point(0, 353);
            this.PnlSystem.Name = "PnlSystem";
            this.PnlSystem.Size = new System.Drawing.Size(218, 118);
            this.PnlSystem.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(0, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(218, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Snow;
            this.btnLogin.Location = new System.Drawing.Point(0, 37);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(218, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.Snow;
            this.btnAbout.Location = new System.Drawing.Point(0, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(218, 37);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About...\r\n";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.ForeColor = System.Drawing.Color.Snow;
            this.btnSystem.Image = ((System.Drawing.Image)(resources.GetObject("btnSystem.Image")));
            this.btnSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.Location = new System.Drawing.Point(0, 316);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSystem.Size = new System.Drawing.Size(218, 37);
            this.btnSystem.TabIndex = 5;
            this.btnSystem.Text = "          System";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click_1);
            // 
            // PnlArchive
            // 
            this.PnlArchive.Controls.Add(this.btnEntities);
            this.PnlArchive.Controls.Add(this.btnEntityTypes);
            this.PnlArchive.Controls.Add(this.btnGroupEntities);
            this.PnlArchive.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArchive.Location = new System.Drawing.Point(0, 201);
            this.PnlArchive.Name = "PnlArchive";
            this.PnlArchive.Size = new System.Drawing.Size(218, 115);
            this.PnlArchive.TabIndex = 1;
            // 
            // btnEntities
            // 
            this.btnEntities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEntities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntities.FlatAppearance.BorderSize = 0;
            this.btnEntities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntities.ForeColor = System.Drawing.Color.Snow;
            this.btnEntities.Location = new System.Drawing.Point(0, 74);
            this.btnEntities.Name = "btnEntities";
            this.btnEntities.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEntities.Size = new System.Drawing.Size(218, 37);
            this.btnEntities.TabIndex = 3;
            this.btnEntities.Text = "Entities";
            this.btnEntities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntities.UseVisualStyleBackColor = false;
            this.btnEntities.Click += new System.EventHandler(this.btnEntities_Click);
            // 
            // btnEntityTypes
            // 
            this.btnEntityTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEntityTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntityTypes.FlatAppearance.BorderSize = 0;
            this.btnEntityTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntityTypes.ForeColor = System.Drawing.Color.Snow;
            this.btnEntityTypes.Location = new System.Drawing.Point(0, 37);
            this.btnEntityTypes.Name = "btnEntityTypes";
            this.btnEntityTypes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEntityTypes.Size = new System.Drawing.Size(218, 37);
            this.btnEntityTypes.TabIndex = 2;
            this.btnEntityTypes.Text = "Entity Types";
            this.btnEntityTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntityTypes.UseVisualStyleBackColor = false;
            this.btnEntityTypes.Click += new System.EventHandler(this.btnEntityTypes_Click);
            // 
            // btnGroupEntities
            // 
            this.btnGroupEntities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnGroupEntities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGroupEntities.FlatAppearance.BorderSize = 0;
            this.btnGroupEntities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupEntities.ForeColor = System.Drawing.Color.Snow;
            this.btnGroupEntities.Location = new System.Drawing.Point(0, 0);
            this.btnGroupEntities.Name = "btnGroupEntities";
            this.btnGroupEntities.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGroupEntities.Size = new System.Drawing.Size(218, 37);
            this.btnGroupEntities.TabIndex = 1;
            this.btnGroupEntities.Text = "Group Entities";
            this.btnGroupEntities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroupEntities.UseVisualStyleBackColor = false;
            this.btnGroupEntities.Click += new System.EventHandler(this.btnGroupEntities_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchive.FlatAppearance.BorderSize = 0;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.ForeColor = System.Drawing.Color.Snow;
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(0, 164);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnArchive.Size = new System.Drawing.Size(218, 37);
            this.btnArchive.TabIndex = 4;
            this.btnArchive.Text = "          Archive";
            this.btnArchive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLabelDate,
            this.stsLabelTime,
            this.stsLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(218, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsLabelDate
            // 
            this.stsLabelDate.ForeColor = System.Drawing.Color.Snow;
            this.stsLabelDate.Name = "stsLabelDate";
            this.stsLabelDate.Size = new System.Drawing.Size(31, 17);
            this.stsLabelDate.Text = "Date";
            // 
            // stsLabelTime
            // 
            this.stsLabelTime.ForeColor = System.Drawing.Color.Snow;
            this.stsLabelTime.Name = "stsLabelTime";
            this.stsLabelTime.Size = new System.Drawing.Size(33, 17);
            this.stsLabelTime.Text = "Time";
            // 
            // stsLabelUser
            // 
            this.stsLabelUser.ForeColor = System.Drawing.Color.Snow;
            this.stsLabelUser.Name = "stsLabelUser";
            this.stsLabelUser.Size = new System.Drawing.Size(30, 17);
            this.stsLabelUser.Text = "User";
            this.stsLabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ptbHome
            // 
            this.ptbHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbHome.Image = ((System.Drawing.Image)(resources.GetObject("ptbHome.Image")));
            this.ptbHome.Location = new System.Drawing.Point(0, 0);
            this.ptbHome.Name = "ptbHome";
            this.ptbHome.Size = new System.Drawing.Size(218, 164);
            this.ptbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbHome.TabIndex = 0;
            this.ptbHome.TabStop = false;
            // 
            // pnlChildren
            // 
            this.pnlChildren.AutoSize = true;
            this.pnlChildren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildren.Location = new System.Drawing.Point(218, 0);
            this.pnlChildren.Name = "pnlChildren";
            this.pnlChildren.Size = new System.Drawing.Size(695, 544);
            this.pnlChildren.TabIndex = 2;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 544);
            this.Controls.Add(this.pnlChildren);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlSystem.ResumeLayout(false);
            this.PnlArchive.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stsLabelDate;
        private ToolStripStatusLabel stsLabelTime;
        private Panel PnlSystem;
        private Button btnExit;
        private Button btnLogin;
        private Button btnAbout;
        private Panel PnlArchive;
        private Button btnEntities;
        private Button btnEntityTypes;
        private Button btnGroupEntities;
        private PictureBox ptbHome;
        private Panel pnlChildren;
        private Button btnSystem;
        private Button btnArchive;
        private ToolStripStatusLabel stsLabelUser;
    }
}