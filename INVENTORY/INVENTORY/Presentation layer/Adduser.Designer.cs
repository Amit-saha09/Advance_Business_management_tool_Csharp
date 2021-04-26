namespace INVENTORY.Presentation_layer
{
    partial class Adduser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userpicbox = new System.Windows.Forms.PictureBox();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.namebox = new MetroFramework.Controls.MetroTextBox();
            this.passbox = new MetroFramework.Controls.MetroTextBox();
            this.confirmpassbox = new MetroFramework.Controls.MetroTextBox();
            this.typebox = new MetroFramework.Controls.MetroTextBox();
            this.emailbox = new MetroFramework.Controls.MetroTextBox();
            this.addressbox = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.addressbox);
            this.panel1.Controls.Add(this.emailbox);
            this.panel1.Controls.Add(this.typebox);
            this.panel1.Controls.Add(this.confirmpassbox);
            this.panel1.Controls.Add(this.passbox);
            this.panel1.Controls.Add(this.namebox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Closebtn);
            this.panel1.Controls.Add(this.Submitbtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 290);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Uploadbtn);
            this.groupBox1.Controls.Add(this.userpicbox);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // userpicbox
            // 
            this.userpicbox.Location = new System.Drawing.Point(22, 19);
            this.userpicbox.Name = "userpicbox";
            this.userpicbox.Size = new System.Drawing.Size(189, 171);
            this.userpicbox.TabIndex = 0;
            this.userpicbox.TabStop = false;
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(75, 214);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(75, 23);
            this.Uploadbtn.TabIndex = 1;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(247, 255);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 1;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(389, 255);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(75, 23);
            this.Closebtn.TabIndex = 1;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Type";
            // 
            // namebox
            // 
            // 
            // 
            // 
            this.namebox.CustomButton.Image = null;
            this.namebox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.namebox.CustomButton.Name = "";
            this.namebox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.namebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namebox.CustomButton.TabIndex = 1;
            this.namebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namebox.CustomButton.UseSelectable = true;
            this.namebox.CustomButton.Visible = false;
            this.namebox.Lines = new string[0];
            this.namebox.Location = new System.Drawing.Point(327, 12);
            this.namebox.MaxLength = 32767;
            this.namebox.Name = "namebox";
            this.namebox.PasswordChar = '\0';
            this.namebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namebox.SelectedText = "";
            this.namebox.SelectionLength = 0;
            this.namebox.SelectionStart = 0;
            this.namebox.ShortcutsEnabled = true;
            this.namebox.Size = new System.Drawing.Size(137, 23);
            this.namebox.TabIndex = 3;
            this.namebox.UseSelectable = true;
            this.namebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passbox
            // 
            // 
            // 
            // 
            this.passbox.CustomButton.Image = null;
            this.passbox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.passbox.CustomButton.Name = "";
            this.passbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passbox.CustomButton.TabIndex = 1;
            this.passbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passbox.CustomButton.UseSelectable = true;
            this.passbox.CustomButton.Visible = false;
            this.passbox.Lines = new string[0];
            this.passbox.Location = new System.Drawing.Point(327, 46);
            this.passbox.MaxLength = 32767;
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '\0';
            this.passbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passbox.SelectedText = "";
            this.passbox.SelectionLength = 0;
            this.passbox.SelectionStart = 0;
            this.passbox.ShortcutsEnabled = true;
            this.passbox.Size = new System.Drawing.Size(137, 23);
            this.passbox.TabIndex = 3;
            this.passbox.UseSelectable = true;
            this.passbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmpassbox
            // 
            // 
            // 
            // 
            this.confirmpassbox.CustomButton.Image = null;
            this.confirmpassbox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.confirmpassbox.CustomButton.Name = "";
            this.confirmpassbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirmpassbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmpassbox.CustomButton.TabIndex = 1;
            this.confirmpassbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmpassbox.CustomButton.UseSelectable = true;
            this.confirmpassbox.CustomButton.Visible = false;
            this.confirmpassbox.Lines = new string[0];
            this.confirmpassbox.Location = new System.Drawing.Point(327, 84);
            this.confirmpassbox.MaxLength = 32767;
            this.confirmpassbox.Name = "confirmpassbox";
            this.confirmpassbox.PasswordChar = '\0';
            this.confirmpassbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmpassbox.SelectedText = "";
            this.confirmpassbox.SelectionLength = 0;
            this.confirmpassbox.SelectionStart = 0;
            this.confirmpassbox.ShortcutsEnabled = true;
            this.confirmpassbox.Size = new System.Drawing.Size(137, 23);
            this.confirmpassbox.TabIndex = 3;
            this.confirmpassbox.UseSelectable = true;
            this.confirmpassbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmpassbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // typebox
            // 
            // 
            // 
            // 
            this.typebox.CustomButton.Image = null;
            this.typebox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.typebox.CustomButton.Name = "";
            this.typebox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.typebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.typebox.CustomButton.TabIndex = 1;
            this.typebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.typebox.CustomButton.UseSelectable = true;
            this.typebox.CustomButton.Visible = false;
            this.typebox.Lines = new string[0];
            this.typebox.Location = new System.Drawing.Point(327, 121);
            this.typebox.MaxLength = 32767;
            this.typebox.Name = "typebox";
            this.typebox.PasswordChar = '\0';
            this.typebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.typebox.SelectedText = "";
            this.typebox.SelectionLength = 0;
            this.typebox.SelectionStart = 0;
            this.typebox.ShortcutsEnabled = true;
            this.typebox.Size = new System.Drawing.Size(137, 23);
            this.typebox.TabIndex = 3;
            this.typebox.UseSelectable = true;
            this.typebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailbox
            // 
            // 
            // 
            // 
            this.emailbox.CustomButton.Image = null;
            this.emailbox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.emailbox.CustomButton.Name = "";
            this.emailbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailbox.CustomButton.TabIndex = 1;
            this.emailbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailbox.CustomButton.UseSelectable = true;
            this.emailbox.CustomButton.Visible = false;
            this.emailbox.Lines = new string[0];
            this.emailbox.Location = new System.Drawing.Point(327, 160);
            this.emailbox.MaxLength = 32767;
            this.emailbox.Name = "emailbox";
            this.emailbox.PasswordChar = '\0';
            this.emailbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailbox.SelectedText = "";
            this.emailbox.SelectionLength = 0;
            this.emailbox.SelectionStart = 0;
            this.emailbox.ShortcutsEnabled = true;
            this.emailbox.Size = new System.Drawing.Size(137, 23);
            this.emailbox.TabIndex = 3;
            this.emailbox.UseSelectable = true;
            this.emailbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addressbox
            // 
            // 
            // 
            // 
            this.addressbox.CustomButton.Image = null;
            this.addressbox.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.addressbox.CustomButton.Name = "";
            this.addressbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addressbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addressbox.CustomButton.TabIndex = 1;
            this.addressbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addressbox.CustomButton.UseSelectable = true;
            this.addressbox.CustomButton.Visible = false;
            this.addressbox.Lines = new string[0];
            this.addressbox.Location = new System.Drawing.Point(327, 207);
            this.addressbox.MaxLength = 32767;
            this.addressbox.Name = "addressbox";
            this.addressbox.PasswordChar = '\0';
            this.addressbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressbox.SelectedText = "";
            this.addressbox.SelectionLength = 0;
            this.addressbox.SelectionStart = 0;
            this.addressbox.ShortcutsEnabled = true;
            this.addressbox.Size = new System.Drawing.Size(137, 23);
            this.addressbox.TabIndex = 3;
            this.addressbox.UseSelectable = true;
            this.addressbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addressbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 294);
            this.Controls.Add(this.panel1);
            this.Name = "Adduser";
            this.Text = "Adduser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userpicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox namebox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.PictureBox userpicbox;
        private MetroFramework.Controls.MetroTextBox addressbox;
        private MetroFramework.Controls.MetroTextBox emailbox;
        private MetroFramework.Controls.MetroTextBox typebox;
        private MetroFramework.Controls.MetroTextBox confirmpassbox;
        private MetroFramework.Controls.MetroTextBox passbox;
    }
}