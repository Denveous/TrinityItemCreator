namespace TrinityItemCreator
{
    partial class Form_Flags_Extra
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
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonSelectAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxFlagExtraMask = new MyTextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonFinish
            // 
            this.ButtonFinish.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.ButtonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFinish.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFinish.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonFinish.Location = new System.Drawing.Point(354, 8);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(117, 27);
            this.ButtonFinish.TabIndex = 151;
            this.ButtonFinish.Text = "FINISH (ESC)";
            this.ButtonFinish.UseVisualStyleBackColor = false;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.ButtonSelectAll);
            this.panel3.Controls.Add(this.ButtonFinish);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 42);
            this.panel3.TabIndex = 153;
            // 
            // ButtonSelectAll
            // 
            this.ButtonSelectAll.BackColor = System.Drawing.Color.Teal;
            this.ButtonSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSelectAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonSelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.ButtonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSelectAll.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSelectAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSelectAll.Location = new System.Drawing.Point(27, 8);
            this.ButtonSelectAll.Name = "ButtonSelectAll";
            this.ButtonSelectAll.Size = new System.Drawing.Size(164, 27);
            this.ButtonSelectAll.TabIndex = 152;
            this.ButtonSelectAll.Text = "SELECT/UNSELECT ALL";
            this.ButtonSelectAll.UseVisualStyleBackColor = false;
            this.ButtonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 42);
            this.panel1.TabIndex = 152;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(206, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Flag Extra Mask";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "[1] Horde Only",
            "[2] Alliance Only",
            "[4] When item uses ExtendedCost in npc_vendor, gold is also required",
            "[256] Makes need roll for this item disabled",
            "[512] NEED_ROLL_DISABLED",
            "[16384] HAS_NORMAL_PRICE",
            "[131072] BNET_ACCOUNT_BOUND",
            "[2097152] CANNOT_BE_TRANSMOG",
            "[4194304] CANNOT_TRANSMOG",
            "[8388608] CAN_TRANSMOG"});
            this.checkedListBox1.Location = new System.Drawing.Point(27, 66);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(444, 200);
            this.checkedListBox1.TabIndex = 154;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(26, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 6);
            this.panel2.TabIndex = 155;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(471, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 200);
            this.panel4.TabIndex = 156;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(20, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 207);
            this.panel5.TabIndex = 157;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(20, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(458, 6);
            this.panel6.TabIndex = 158;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(0, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 24);
            this.label2.TabIndex = 177;
            this.label2.Text = "Manual flag extra mask input";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxFlagExtraMask
            // 
            this.TextBoxFlagExtraMask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxFlagExtraMask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxFlagExtraMask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFlagExtraMask.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxFlagExtraMask.Location = new System.Drawing.Point(0, 312);
            this.TextBoxFlagExtraMask.MaxLength = 9;
            this.TextBoxFlagExtraMask.Name = "TextBoxFlagExtraMask";
            this.TextBoxFlagExtraMask.Size = new System.Drawing.Size(498, 18);
            this.TextBoxFlagExtraMask.TabIndex = 176;
            this.TextBoxFlagExtraMask.Text = "0";
            this.TextBoxFlagExtraMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxFlagExtraMask.TextChanged += new System.EventHandler(this.TextBoxFlagExtraMask_TextChanged);
            this.TextBoxFlagExtraMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Watermark_myTextBox_KeyPress);
            // 
            // Form_Flags_Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(498, 372);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxFlagExtraMask);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Flags_Extra";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window_FlagExtraMask";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Flags_Extra_FormClosed);
            this.Load += new System.EventHandler(this.Window_FlagExtraMask_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Window_FlagExtraMask_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFinish;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ButtonSelectAll;
        private System.Windows.Forms.Label label2;
        private MyTextBox TextBoxFlagExtraMask;
    }
}