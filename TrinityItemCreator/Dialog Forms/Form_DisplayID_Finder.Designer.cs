namespace TrinityItemCreator
{
    partial class Form_DisplayID_Finder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ColumnItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisplayID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnItemPreview = new System.Windows.Forms.DataGridViewLinkColumn();
            this.TextBoxSearch = new MyTextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.ButtonCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 36);
            this.panel2.TabIndex = 31;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(679, 7);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(104, 23);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "CANCEL (ESC)";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 36);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(233, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Search Item Display ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemID,
            this.ColumnItemName,
            this.ColumnDisplayID,
            this.ColumnItemPreview});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(806, 413);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellMouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(22, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 17);
            this.label6.TabIndex = 161;
            this.label6.Text = "Search by item entry or name (min 3 char)";
            // 
            // ColumnItemID
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColumnItemID.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnItemID.Frozen = true;
            this.ColumnItemID.HeaderText = "Item Entry";
            this.ColumnItemID.Name = "ColumnItemID";
            this.ColumnItemID.ReadOnly = true;
            // 
            // ColumnItemName
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ColumnItemName.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnItemName.Frozen = true;
            this.ColumnItemName.HeaderText = "Item Name";
            this.ColumnItemName.Name = "ColumnItemName";
            this.ColumnItemName.ReadOnly = true;
            this.ColumnItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnItemName.Width = 395;
            // 
            // ColumnDisplayID
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.MistyRose;
            this.ColumnDisplayID.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnDisplayID.HeaderText = "Display ID";
            this.ColumnDisplayID.Name = "ColumnDisplayID";
            this.ColumnDisplayID.ReadOnly = true;
            this.ColumnDisplayID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDisplayID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDisplayID.Width = 105;
            // 
            // ColumnItemPreview
            // 
            this.ColumnItemPreview.HeaderText = "Url";
            this.ColumnItemPreview.Name = "ColumnItemPreview";
            this.ColumnItemPreview.ReadOnly = true;
            this.ColumnItemPreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnItemPreview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxSearch.Location = new System.Drawing.Point(294, 477);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(426, 20);
            this.TextBoxSearch.TabIndex = 0;
            this.TextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // Form_DisplayID_Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 547);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DisplayID_Finder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Window_DisplayIdFinder_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        public MyTextBox TextBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDisplayID;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnItemPreview;
    }
}