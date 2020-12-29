namespace TrinityItemCreator
{
    partial class Form_Save_Custom_Template
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.myTextBox2 = new MyTextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.ButtonClose);
            this.panel2.Controls.Add(this.ButtonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 36);
            this.panel2.TabIndex = 31;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(330, 7);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(104, 23);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "Cancel (ESC)";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.CadetBlue;
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSave.Location = new System.Drawing.Point(25, 7);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(104, 23);
            this.ButtonSave.TabIndex = 0;
            this.ButtonSave.Text = "Save (ENTER)";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 36);
            this.panel1.TabIndex = 30;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelTitle.Location = new System.Drawing.Point(179, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(97, 17);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Template Save";
            // 
            // LabelInfo
            // 
            this.LabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabelInfo.Enabled = false;
            this.LabelInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LabelInfo.Location = new System.Drawing.Point(67, 47);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(317, 17);
            this.LabelInfo.TabIndex = 38;
            this.LabelInfo.Text = "Blah";
            this.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelInfo.Visible = false;
            // 
            // LabelWarning
            // 
            this.LabelWarning.BackColor = System.Drawing.Color.Transparent;
            this.LabelWarning.Enabled = false;
            this.LabelWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWarning.ForeColor = System.Drawing.Color.DimGray;
            this.LabelWarning.Location = new System.Drawing.Point(67, 99);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(317, 17);
            this.LabelWarning.TabIndex = 39;
            this.LabelWarning.Text = "(Will be saved in /templates directory)";
            this.LabelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myTextBox2
            // 
            this.myTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.myTextBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.myTextBox2.Location = new System.Drawing.Point(67, 67);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(317, 23);
            this.myTextBox2.TabIndex = 0;
            this.myTextBox2.Tag = "";
            this.myTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.myTextBox2.TextChanged += new System.EventHandler(this.myTextBox2_TextChanged);
            this.myTextBox2.Enter += new System.EventHandler(this.Watermark_myTextBox_Enter);
            this.myTextBox2.Leave += new System.EventHandler(this.Watermark_myTextBox_Leave);
            // 
            // Form_Save_Custom_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(461, 168);
            this.ControlBox = false;
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Save_Custom_Template";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form_Save_Custom_Template_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelInfo;
        public MyTextBox myTextBox2;
        private System.Windows.Forms.Label LabelWarning;
    }
}