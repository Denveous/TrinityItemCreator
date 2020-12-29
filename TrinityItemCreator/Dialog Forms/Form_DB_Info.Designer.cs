namespace TrinityItemCreator.Dialog_Forms
{
    partial class Form_DB_Info
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxDB = new MyTextBox();
            this.TextBoxPass = new MyTextBox();
            this.TextBoxUser = new MyTextBox();
            this.TextBoxPort = new MyTextBox();
            this.TextBoxAddress = new MyTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 36);
            this.panel1.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(96, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Database Connection Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.ButtonCancel);
            this.panel2.Controls.Add(this.ButtonApply);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 39);
            this.panel2.TabIndex = 35;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(270, 8);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(104, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "CANCEL (ESC)";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonApply.BackColor = System.Drawing.Color.CadetBlue;
            this.ButtonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonApply.ForeColor = System.Drawing.Color.White;
            this.ButtonApply.Location = new System.Drawing.Point(12, 8);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(104, 23);
            this.ButtonApply.TabIndex = 0;
            this.ButtonApply.Text = "Save (ENTER)";
            this.ButtonApply.UseVisualStyleBackColor = false;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(251, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(22, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(251, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.CadetBlue;
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "*  Notice: This information will be saved in plain text in the config file!";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TextBoxDB
            // 
            this.TextBoxDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDB.Location = new System.Drawing.Point(242, 129);
            this.TextBoxDB.Name = "TextBoxDB";
            this.TextBoxDB.Size = new System.Drawing.Size(132, 20);
            this.TextBoxDB.TabIndex = 77;
            this.TextBoxDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxDB.TextChanged += new System.EventHandler(this.TextBoxDB_TextChanged);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPass.Location = new System.Drawing.Point(16, 179);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.Size = new System.Drawing.Size(221, 20);
            this.TextBoxPass.TabIndex = 74;
            this.TextBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.Location = new System.Drawing.Point(15, 129);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(221, 20);
            this.TextBoxUser.TabIndex = 72;
            this.TextBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxUser.TextChanged += new System.EventHandler(this.TextBoxUser_TextChanged);
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPort.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxPort.Location = new System.Drawing.Point(243, 73);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(131, 20);
            this.TextBoxPort.TabIndex = 71;
            this.TextBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPort.TextChanged += new System.EventHandler(this.TextBoxPort_TextChanged);
            this.TextBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Watermark_myTextBox_KeyPress);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAddress.Location = new System.Drawing.Point(15, 73);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(222, 20);
            this.TextBoxAddress.TabIndex = 36;
            this.TextBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxAddress.TextChanged += new System.EventHandler(this.TextBoxAddress_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(255, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_DB_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DB_Info";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_DB_Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_DB_Info_FormClosed);
            this.Load += new System.EventHandler(this.Form_DB_Info_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_DB_Info_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonApply;
        private MyTextBox TextBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public MyTextBox TextBoxPort;
        private System.Windows.Forms.Label label3;
        private MyTextBox TextBoxUser;
        private System.Windows.Forms.Label label4;
        private MyTextBox TextBoxPass;
        private System.Windows.Forms.Label label5;
        private MyTextBox TextBoxDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}