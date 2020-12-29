namespace TrinityItemCreator
{
    partial class Form_Allowable_Race
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UncheckAllButton = new System.Windows.Forms.Button();
            this.ButtonFinish = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 36);
            this.panel1.TabIndex = 150;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(193, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Allowed Race";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 17);
            this.label1.TabIndex = 165;
            this.label1.Text = "Checkbox behaviour, just click on the class(s) you want to allow";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(25, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 5);
            this.panel2.TabIndex = 167;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.UncheckAllButton);
            this.panel3.Controls.Add(this.ButtonFinish);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 42);
            this.panel3.TabIndex = 151;
            // 
            // UncheckAllButton
            // 
            this.UncheckAllButton.BackColor = System.Drawing.Color.Teal;
            this.UncheckAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UncheckAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.UncheckAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.UncheckAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UncheckAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UncheckAllButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UncheckAllButton.Location = new System.Drawing.Point(25, 8);
            this.UncheckAllButton.Name = "UncheckAllButton";
            this.UncheckAllButton.Size = new System.Drawing.Size(164, 27);
            this.UncheckAllButton.TabIndex = 0;
            this.UncheckAllButton.Text = "UNSELECT ALL";
            this.UncheckAllButton.UseVisualStyleBackColor = false;
            this.UncheckAllButton.Click += new System.EventHandler(this.UncheckAll_Click);
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
            this.ButtonFinish.Location = new System.Drawing.Point(328, 8);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new System.Drawing.Size(117, 27);
            this.ButtonFinish.TabIndex = 1;
            this.ButtonFinish.Text = "FINISH (ESC)";
            this.ButtonFinish.UseVisualStyleBackColor = false;
            this.ButtonFinish.Click += new System.EventHandler(this.ButtonFinish_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox4.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_nightelf_female;
            this.checkBox4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Location = new System.Drawing.Point(25, 125);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(136, 30);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Tag = "8";
            this.checkBox4.Text = "Nightelf";
            this.checkBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox9.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox9.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox9.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_bloodelf_female;
            this.checkBox9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox9.Location = new System.Drawing.Point(309, 161);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(136, 30);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Tag = "512";
            this.checkBox9.Text = "Bloodelf";
            this.checkBox9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox8.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox8.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_troll_male;
            this.checkBox8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox8.Location = new System.Drawing.Point(167, 161);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(136, 30);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Tag = "128";
            this.checkBox8.Text = "Troll";
            this.checkBox8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox7.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox7.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_gnome_male;
            this.checkBox7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox7.Location = new System.Drawing.Point(25, 161);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(136, 30);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Tag = "64";
            this.checkBox7.Text = "Gnome";
            this.checkBox7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox6.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_tauren_male;
            this.checkBox6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Location = new System.Drawing.Point(309, 125);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(136, 30);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Tag = "32";
            this.checkBox6.Text = "Tauren";
            this.checkBox6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox10.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox10.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox10.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox10.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox10.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_draenei_female;
            this.checkBox10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox10.Location = new System.Drawing.Point(167, 197);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(136, 30);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Tag = "1024";
            this.checkBox10.Text = "Draenei";
            this.checkBox10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox5.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_undead_male;
            this.checkBox5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Location = new System.Drawing.Point(167, 125);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(136, 30);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Tag = "16";
            this.checkBox5.Text = "Undead";
            this.checkBox5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox3.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_dwarf_male;
            this.checkBox3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(309, 89);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(136, 30);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Tag = "4";
            this.checkBox3.Text = "Dwar";
            this.checkBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox2.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_orc_male;
            this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(167, 89);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 30);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Tag = "2";
            this.checkBox2.Text = "Orc";
            this.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Image = global::TrinityItemCreator.Properties.Resources.small_achievement_character_human_female;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(25, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 30);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "1";
            this.checkBox1.Text = "Human";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Form_Allowable_Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(474, 286);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Allowable_Race";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Window_RaceMask";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Allowable_Race_FormClosed);
            this.Load += new System.EventHandler(this.Form_Allowable_Race_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Allowable_Race_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button UncheckAllButton;
        private System.Windows.Forms.Button ButtonFinish;
    }
}