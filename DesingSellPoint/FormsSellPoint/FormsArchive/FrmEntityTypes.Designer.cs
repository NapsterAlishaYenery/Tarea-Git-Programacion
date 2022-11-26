namespace DesingSellPoint.FormsSellPoint.FormsArchive
{
    partial class FrmEntityTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntityTypes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEntityTypes = new System.Windows.Forms.Label();
            this.dgvEntityTypes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntityTypes)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.lblEntityTypes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvEntityTypes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.67793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.67291F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 505);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblEntityTypes
            // 
            this.lblEntityTypes.AutoSize = true;
            this.lblEntityTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntityTypes.Font = new System.Drawing.Font("Damion", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEntityTypes.ForeColor = System.Drawing.Color.Snow;
            this.lblEntityTypes.Location = new System.Drawing.Point(57, 0);
            this.lblEntityTypes.Name = "lblEntityTypes";
            this.lblEntityTypes.Size = new System.Drawing.Size(568, 94);
            this.lblEntityTypes.TabIndex = 0;
            this.lblEntityTypes.Text = "Entity Types\r\n";
            this.lblEntityTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEntityTypes
            // 
            this.dgvEntityTypes.AllowUserToAddRows = false;
            this.dgvEntityTypes.AllowUserToDeleteRows = false;
            this.dgvEntityTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dgvEntityTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntityTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntityTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dgvEntityTypes.Location = new System.Drawing.Point(57, 97);
            this.dgvEntityTypes.MultiSelect = false;
            this.dgvEntityTypes.Name = "dgvEntityTypes";
            this.dgvEntityTypes.ReadOnly = true;
            this.dgvEntityTypes.RowTemplate.Height = 25;
            this.dgvEntityTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntityTypes.Size = new System.Drawing.Size(568, 325);
            this.dgvEntityTypes.TabIndex = 1;
            this.dgvEntityTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntityTypes_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeselect, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleted, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(57, 428);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 74);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnDeselect
            // 
            this.btnDeselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeselect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeselect.FlatAppearance.BorderSize = 0;
            this.btnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeselect.ForeColor = System.Drawing.Color.Snow;
            this.btnDeselect.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselect.Image")));
            this.btnDeselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeselect.Location = new System.Drawing.Point(287, 3);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(278, 31);
            this.btnDeselect.TabIndex = 0;
            this.btnDeselect.Text = "Deselect";
            this.btnDeselect.UseVisualStyleBackColor = false;
            this.btnDeselect.Click += new System.EventHandler(this.btnDeselect_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDeleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleted.FlatAppearance.BorderSize = 0;
            this.btnDeleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleted.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleted.Image")));
            this.btnDeleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleted.Location = new System.Drawing.Point(287, 40);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(278, 31);
            this.btnDeleted.TabIndex = 1;
            this.btnDeleted.Text = "Deleted";
            this.btnDeleted.UseVisualStyleBackColor = false;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Snow;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(278, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Snow;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(3, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(278, 31);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmEntityTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntityTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.FrmEntityTypes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntityTypes)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblEntityTypes;
        private DataGridView dgvEntityTypes;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnDeselect;
        private Button btnDeleted;
        private Button btnAdd;
        private Button btnEdit;
    }
}