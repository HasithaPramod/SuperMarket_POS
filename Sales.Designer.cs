namespace hasitha
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MyPrintPreviewDialog = new System.Windows.Forms.PageSetupDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemSearchBox = new System.Windows.Forms.TextBox();
            this.dtgrdViewSalesReport = new System.Windows.Forms.DataGridView();
            this.dtReturnEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnGLprint = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDailyPaymentReport = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtReturnStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtSalesItemStart = new System.Windows.Forms.DateTimePicker();
            this.dtSalesItemEND = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdViewSalesReport)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "SalesReport.csv";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(736, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 38);
            this.label6.TabIndex = 74;
            this.label6.Text = "DynamicSoft";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 33);
            this.label8.TabIndex = 73;
            this.label8.Text = " Report ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.txtItemSearchBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dtgrdViewSalesReport);
            this.splitContainer2.Size = new System.Drawing.Size(658, 569);
            this.splitContainer2.SplitterDistance = 62;
            this.splitContainer2.TabIndex = 2;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(202, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search Product Name , Id,  Sales No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtItemSearchBox
            // 
            this.txtItemSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemSearchBox.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.txtItemSearchBox.Location = new System.Drawing.Point(199, 26);
            this.txtItemSearchBox.Name = "txtItemSearchBox";
            this.txtItemSearchBox.Size = new System.Drawing.Size(451, 26);
            this.txtItemSearchBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtItemSearchBox, "Search Sales Item Details \r\n\r\nSearch  by item Name  , Sales No ");
            this.txtItemSearchBox.TextChanged += new System.EventHandler(this.txtItemSearchBox_TextChanged);
            // 
            // dtgrdViewSalesReport
            // 
            this.dtgrdViewSalesReport.AllowUserToAddRows = false;
            this.dtgrdViewSalesReport.AllowUserToDeleteRows = false;
            this.dtgrdViewSalesReport.AllowUserToResizeColumns = false;
            this.dtgrdViewSalesReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtgrdViewSalesReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdViewSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdViewSalesReport.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgrdViewSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdViewSalesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrdViewSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrdViewSalesReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdViewSalesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrdViewSalesReport.Location = new System.Drawing.Point(0, 0);
            this.dtgrdViewSalesReport.Name = "dtgrdViewSalesReport";
            this.dtgrdViewSalesReport.ReadOnly = true;
            this.dtgrdViewSalesReport.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtgrdViewSalesReport.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrdViewSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdViewSalesReport.Size = new System.Drawing.Size(658, 503);
            this.dtgrdViewSalesReport.TabIndex = 1;
            this.dtgrdViewSalesReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdViewSalesReport_CellContentClick);
            // 
            // dtReturnEndDate
            // 
            this.dtReturnEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReturnEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturnEndDate.Location = new System.Drawing.Point(7, 58);
            this.dtReturnEndDate.Name = "dtReturnEndDate";
            this.dtReturnEndDate.Size = new System.Drawing.Size(199, 20);
            this.dtReturnEndDate.TabIndex = 82;
            this.toolTip1.SetToolTip(this.dtReturnEndDate, "Select Date2 to Generate  \r\n                    Daily Return  items Report\r\n \r\nEx" +
        "ample:  2015-10-29\r\nyyyy-mm-dd");
            this.dtReturnEndDate.ValueChanged += new System.EventHandler(this.dtReturnEndDate_ValueChanged);
            // 
            // btnGLprint
            // 
            this.btnGLprint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGLprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGLprint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGLprint.FlatAppearance.BorderSize = 0;
            this.btnGLprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGLprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGLprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnGLprint.Location = new System.Drawing.Point(273, 567);
            this.btnGLprint.Name = "btnGLprint";
            this.btnGLprint.Size = new System.Drawing.Size(26, 37);
            this.btnGLprint.TabIndex = 87;
            this.btnGLprint.Text = "General Ledger Print";
            this.btnGLprint.UseVisualStyleBackColor = false;
            this.btnGLprint.Visible = false;
            this.btnGLprint.Click += new System.EventHandler(this.btnGLprint_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtStartDate);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dtEndDate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(25, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 168);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Report [Overall turnout] ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(7, 90);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(234, 24);
            this.dtStartDate.TabIndex = 82;
            this.toolTip1.SetToolTip(this.dtStartDate, "Please Select  Date 2 \r\n \r\nExample:  2014-10-29\r\nyyyy-mm-dd");
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDailyPaymentReport);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily  Payment Report";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtDailyPaymentReport
            // 
            this.dtDailyPaymentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDailyPaymentReport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDailyPaymentReport.Location = new System.Drawing.Point(6, 20);
            this.dtDailyPaymentReport.Name = "dtDailyPaymentReport";
            this.dtDailyPaymentReport.Size = new System.Drawing.Size(188, 24);
            this.dtDailyPaymentReport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dtDailyPaymentReport, "Please Select Date to Generate  \r\n                    Daily Payment  Report\r\n \r\nE" +
        "xample:  2014-10-29\r\nyyyy-mm-dd");
            this.dtDailyPaymentReport.ValueChanged += new System.EventHandler(this.dtDailyPaymentReport_ValueChanged);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(6, 125);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(235, 24);
            this.dtEndDate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dtEndDate, "Please Select  Date 2 \r\n \r\nExample:  2014-10-29\r\nyyyy-mm-dd");
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 15);
            this.label9.TabIndex = 75;
            this.label9.Text = "Date to Date Payment Report ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dtReturnStartDate
            // 
            this.dtReturnStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtReturnStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReturnStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturnStartDate.Location = new System.Drawing.Point(7, 19);
            this.dtReturnStartDate.Name = "dtReturnStartDate";
            this.dtReturnStartDate.Size = new System.Drawing.Size(199, 22);
            this.dtReturnStartDate.TabIndex = 77;
            this.toolTip1.SetToolTip(this.dtReturnStartDate, "Select Date to Generate  \r\n                    Daily Return  items Report\r\n \r\nExa" +
        "mple:  2015-10-29\r\nyyyy-mm-dd");
            this.dtReturnStartDate.ValueChanged += new System.EventHandler(this.dtReturnStartDate_ValueChanged);
            // 
            // dtSalesItemStart
            // 
            this.dtSalesItemStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtSalesItemStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSalesItemStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesItemStart.Location = new System.Drawing.Point(9, 39);
            this.dtSalesItemStart.Name = "dtSalesItemStart";
            this.dtSalesItemStart.Size = new System.Drawing.Size(232, 22);
            this.dtSalesItemStart.TabIndex = 77;
            this.toolTip1.SetToolTip(this.dtSalesItemStart, "Select Date to Generate  \r\n                    Daily Sales  items Report\r\n \r\nExam" +
        "ple:  2014-10-29\r\nyyyy-mm-dd");
            this.dtSalesItemStart.ValueChanged += new System.EventHandler(this.dtSalesItemStart_ValueChanged);
            // 
            // dtSalesItemEND
            // 
            this.dtSalesItemEND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSalesItemEND.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesItemEND.Location = new System.Drawing.Point(9, 67);
            this.dtSalesItemEND.Name = "dtSalesItemEND";
            this.dtSalesItemEND.Size = new System.Drawing.Size(232, 20);
            this.dtSalesItemEND.TabIndex = 82;
            this.toolTip1.SetToolTip(this.dtSalesItemEND, "Select Date to Generate  \r\n                    Daily Sales  items Report\r\n \r\nExam" +
        "ple:  2015-10-29\r\nyyyy-mm-dd");
            this.dtSalesItemEND.ValueChanged += new System.EventHandler(this.dtSalesItemEND_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Date to Date Sales Report ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtSalesItemStart);
            this.groupBox4.Controls.Add(this.dtSalesItemEND);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(25, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 108);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sales Item Report";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtReturnStartDate);
            this.groupBox2.Controls.Add(this.dtReturnEndDate);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(25, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 97);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return Report";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.btnGLprint);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(975, 569);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 569);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "Sales";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdViewSalesReport)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PageSetupDialog MyPrintPreviewDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemSearchBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dtgrdViewSalesReport;
        private System.Windows.Forms.DateTimePicker dtReturnEndDate;
        private System.Windows.Forms.Button btnGLprint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDailyPaymentReport;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtReturnStartDate;
        private System.Windows.Forms.DateTimePicker dtSalesItemStart;
        private System.Windows.Forms.DateTimePicker dtSalesItemEND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}