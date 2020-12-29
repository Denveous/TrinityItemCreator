namespace TrinityItemCreator
{
    partial class Form_Flags
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonSelectAll = new System.Windows.Forms.Button();
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxFlagMask = new MyTextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.ButtonSelectAll);
            this.panel3.Controls.Add(this.ButtonFinish);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 42);
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
            this.ButtonSelectAll.Location = new System.Drawing.Point(26, 8);
            this.ButtonSelectAll.Name = "ButtonSelectAll";
            this.ButtonSelectAll.Size = new System.Drawing.Size(164, 27);
            this.ButtonSelectAll.TabIndex = 155;
            this.ButtonSelectAll.Text = "SELECT/UNSELECT ALL";
            this.ButtonSelectAll.UseVisualStyleBackColor = false;
            this.ButtonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
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
            this.ButtonFinish.Location = new System.Drawing.Point(591, 8);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(117, 27);
            this.ButtonFinish.TabIndex = 154;
            this.ButtonFinish.Text = "FINISH (ESC)";
            this.ButtonFinish.UseVisualStyleBackColor = false;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 42);
            this.panel1.TabIndex = 152;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(338, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Flag Mask";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "[1] UNK1",
            "[2] Conjured item",
            "[4] Openable (can be opened by right-click)",
            "[8] Makes green \"Heroic\" text appear on item",
            "[16] Deprecated Item",
            "[32] Item can not be destroyed, except by using spell (item can be reagent for sp" +
                "ell)",
            "[64] UNK2",
            "[128] No default 30 seconds cooldown when equipped",
            "[256] UNK3",
            "[512] Wrapper : Item can wrap other items",
            "[1024] UNK4",
            "[2048] Item is party loot and can be looted by all",
            "[4096] Item is refundable",
            "[8192] Charter (Arena or Guild)",
            "[16384] UNK5 // comment in code : Only readable items have this (but not all)",
            "[32768] UNK6",
            "[65536] UNK7",
            "[131072] UNK8",
            "[262144] Item can be prospected",
            "[524288] Unique equipped (player can only have one equipped at the same time)",
            "[1048576] UNK9",
            "[2097152] Item can be used during arena match",
            "[4194304] Throwable (for tooltip ingame)",
            "[8388608] Item can be used in shapeshift forms",
            "[16777216] UNK10",
            "[33554432] Profession recipes: can only be looted if you meet requirements and do" +
                "n\'t already know it",
            "[67108864] Item cannot be used in arena",
            "[134217728] Bind to Account (Also needs Quality = 7 set)",
            "[268435456] Spell is cast with triggered flag",
            "[536870912] Millable",
            "[1073741824] UNK11",
            "[2147483648] Bind on Pickup tradeable"});
            this.checkedListBox1.Location = new System.Drawing.Point(27, 66);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(681, 320);
            this.checkedListBox1.TabIndex = 154;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(26, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 6);
            this.panel2.TabIndex = 155;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(708, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 326);
            this.panel4.TabIndex = 156;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(20, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 326);
            this.panel5.TabIndex = 157;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(20, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(694, 6);
            this.panel6.TabIndex = 158;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(0, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(733, 24);
            this.label2.TabIndex = 179;
            this.label2.Text = "Manual flag mask input";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxFlagMask
            // 
            this.TextBoxFlagMask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxFlagMask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBoxFlagMask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFlagMask.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxFlagMask.Location = new System.Drawing.Point(0, 427);
            this.TextBoxFlagMask.MaxLength = 9;
            this.TextBoxFlagMask.Name = "TextBoxFlagMask";
            this.TextBoxFlagMask.Size = new System.Drawing.Size(733, 18);
            this.TextBoxFlagMask.TabIndex = 178;
            this.TextBoxFlagMask.Text = "0";
            this.TextBoxFlagMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxFlagMask.TextChanged += new System.EventHandler(this.TextBoxFlagMask_TextChanged);
            this.TextBoxFlagMask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Watermark_myTextBox_KeyPress);
            // 
            // Form_Flags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(733, 487);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxFlagMask);
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
            this.Name = "Form_Flags";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window_FlagMask";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Flags_FormClosed);
            this.Load += new System.EventHandler(this.Window_FlagMask_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Window_FlagMask_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ButtonSelectAll;
        private System.Windows.Forms.Button ButtonFinish;
        private System.Windows.Forms.Label label2;
        private MyTextBox TextBoxFlagMask;
    }
}