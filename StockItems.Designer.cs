namespace hasitha
{
    partial class StockItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockItems));
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblRows = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblMinimized = new System.Windows.Forms.Label();
            this.combCategory = new System.Windows.Forms.ComboBox();
            this.txtItemSearchBar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelUserList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(951, 520);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(73, 56);
            this.btnAddNew.TabIndex = 166;
            this.btnAddNew.Text = "Add New ";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(5, 545);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(13, 13);
            this.lblRows.TabIndex = 165;
            this.lblRows.Text = "0";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 39000;
            this.toolTip1.InitialDelay = 9;
            this.toolTip1.ReshowDelay = 9;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lblMinimized
            // 
            this.lblMinimized.AutoSize = true;
            this.lblMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblMinimized.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinimized.Location = new System.Drawing.Point(1111, 2);
            this.lblMinimized.Name = "lblMinimized";
            this.lblMinimized.Size = new System.Drawing.Size(19, 25);
            this.lblMinimized.TabIndex = 38;
            this.lblMinimized.Text = "-";
            this.toolTip1.SetToolTip(this.lblMinimized, "Minimize");
            // 
            // combCategory
            // 
            this.combCategory.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.combCategory.FormattingEnabled = true;
            this.combCategory.Location = new System.Drawing.Point(829, 57);
            this.combCategory.Name = "combCategory";
            this.combCategory.Size = new System.Drawing.Size(328, 23);
            this.combCategory.TabIndex = 164;
            this.toolTip1.SetToolTip(this.combCategory, "Please Select Item category");
            // 
            // txtItemSearchBar
            // 
            this.txtItemSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtItemSearchBar.Location = new System.Drawing.Point(8, 58);
            this.txtItemSearchBar.Name = "txtItemSearchBar";
            this.txtItemSearchBar.Size = new System.Drawing.Size(815, 21);
            this.txtItemSearchBar.TabIndex = 155;
            this.toolTip1.SetToolTip(this.txtItemSearchBar, "Search by Product Code / Barcode OR  Name ");
            this.txtItemSearchBar.TextChanged += new System.EventHandler(this.txtItemSearchBar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(8, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Stock Item";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label24.Location = new System.Drawing.Point(826, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 14);
            this.label24.TabIndex = 163;
            this.label24.Text = "Select Category";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanelUserList);
            this.panel3.Location = new System.Drawing.Point(10, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1154, 422);
            this.panel3.TabIndex = 162;
            // 
            // flowLayoutPanelUserList
            // 
            this.flowLayoutPanelUserList.AutoScroll = true;
            this.flowLayoutPanelUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUserList.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelUserList.Name = "flowLayoutPanelUserList";
            this.flowLayoutPanelUserList.Size = new System.Drawing.Size(1154, 422);
            this.flowLayoutPanelUserList.TabIndex = 5;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.Control;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Desktop;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.Location = new System.Drawing.Point(1032, 519);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(102, 58);
            this.btnImport.TabIndex = 161;
            this.btnImport.Text = "Import Item";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(-4, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 22);
            this.panel2.TabIndex = 160;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblMinimized);
            this.panel1.Location = new System.Drawing.Point(-4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 30);
            this.panel1.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 158;
            this.label6.Text = "Search Product";
            // 
            // StockItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 600);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.combCategory);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemSearchBar);
            this.Name = "StockItems";
            this.Text = "StockItems";
            this.Load += new System.EventHandler(this.StockItems_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblMinimized;
        private System.Windows.Forms.ComboBox combCategory;
        private System.Windows.Forms.TextBox txtItemSearchBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserList;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}