namespace DesingSellPoint.FormsSellPoint
{
    partial class FrmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.pBSplash = new System.Windows.Forms.ProgressBar();
            this.tmSplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pBSplash
            // 
            this.pBSplash.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pBSplash.Location = new System.Drawing.Point(199, 252);
            this.pBSplash.Name = "pBSplash";
            this.pBSplash.Size = new System.Drawing.Size(254, 23);
            this.pBSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBSplash.TabIndex = 0;
            // 
            // tmSplash
            // 
            this.tmSplash.Enabled = true;
            this.tmSplash.Tick += new System.EventHandler(this.tmSplash_Tick_1);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 326);
            this.Controls.Add(this.pBSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar pBSplash;
        private System.Windows.Forms.Timer tmSplash;
    }
}