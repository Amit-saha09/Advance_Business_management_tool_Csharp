namespace INVENTORY.Presentation_layer
{
    partial class CategoryAddform
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
            this.Close = new System.Windows.Forms.Button();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Suplierbox = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Entrydatebox = new MetroFramework.Controls.MetroDateTime();
            this.Companybox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Typebox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Namebox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Catpicbox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Catpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Submitbtn);
            this.panel1.Controls.Add(this.Suplierbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Entrydatebox);
            this.panel1.Controls.Add(this.Companybox);
            this.panel1.Controls.Add(this.Typebox);
            this.panel1.Controls.Add(this.Namebox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 305);
            this.panel1.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(270, 262);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(55, 23);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(69, 262);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(55, 23);
            this.Submitbtn.TabIndex = 5;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            // 
            // Suplierbox
            // 
            this.Suplierbox.FormattingEnabled = true;
            this.Suplierbox.ItemHeight = 23;
            this.Suplierbox.Location = new System.Drawing.Point(321, 197);
            this.Suplierbox.Name = "Suplierbox";
            this.Suplierbox.Size = new System.Drawing.Size(88, 29);
            this.Suplierbox.TabIndex = 4;
            this.Suplierbox.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Suplier id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "EntryDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // Entrydatebox
            // 
            this.Entrydatebox.Location = new System.Drawing.Point(321, 106);
            this.Entrydatebox.MinimumSize = new System.Drawing.Size(0, 29);
            this.Entrydatebox.Name = "Entrydatebox";
            this.Entrydatebox.Size = new System.Drawing.Size(88, 29);
            this.Entrydatebox.TabIndex = 2;
            // 
            // Companybox
            // 
            this.Companybox.Depth = 0;
            this.Companybox.Hint = "";
            this.Companybox.Location = new System.Drawing.Point(319, 150);
            this.Companybox.MaxLength = 32767;
            this.Companybox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Companybox.Name = "Companybox";
            this.Companybox.PasswordChar = '\0';
            this.Companybox.SelectedText = "";
            this.Companybox.SelectionLength = 0;
            this.Companybox.SelectionStart = 0;
            this.Companybox.Size = new System.Drawing.Size(90, 23);
            this.Companybox.TabIndex = 1;
            this.Companybox.TabStop = false;
            this.Companybox.UseSystemPasswordChar = false;
            // 
            // Typebox
            // 
            this.Typebox.Depth = 0;
            this.Typebox.Hint = "";
            this.Typebox.Location = new System.Drawing.Point(321, 65);
            this.Typebox.MaxLength = 32767;
            this.Typebox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Typebox.Name = "Typebox";
            this.Typebox.PasswordChar = '\0';
            this.Typebox.SelectedText = "";
            this.Typebox.SelectionLength = 0;
            this.Typebox.SelectionStart = 0;
            this.Typebox.Size = new System.Drawing.Size(88, 23);
            this.Typebox.TabIndex = 1;
            this.Typebox.TabStop = false;
            this.Typebox.UseSystemPasswordChar = false;
            // 
            // Namebox
            // 
            this.Namebox.Depth = 0;
            this.Namebox.Hint = "";
            this.Namebox.Location = new System.Drawing.Point(321, 26);
            this.Namebox.MaxLength = 32767;
            this.Namebox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Namebox.Name = "Namebox";
            this.Namebox.PasswordChar = '\0';
            this.Namebox.SelectedText = "";
            this.Namebox.SelectionLength = 0;
            this.Namebox.SelectionStart = 0;
            this.Namebox.Size = new System.Drawing.Size(88, 23);
            this.Namebox.TabIndex = 1;
            this.Namebox.TabStop = false;
            this.Namebox.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Uploadbtn);
            this.groupBox1.Controls.Add(this.Catpicbox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddCategory";
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(47, 176);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(55, 16);
            this.Uploadbtn.TabIndex = 1;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            // 
            // Catpicbox
            // 
            this.Catpicbox.Location = new System.Drawing.Point(19, 35);
            this.Catpicbox.Name = "Catpicbox";
            this.Catpicbox.Size = new System.Drawing.Size(102, 119);
            this.Catpicbox.TabIndex = 0;
            this.Catpicbox.TabStop = false;
            // 
            // CategoryAddform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 316);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryAddform";
            this.Text = "CategoryAddform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Catpicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Catpicbox;
        private MetroFramework.Controls.MetroComboBox Suplierbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime Entrydatebox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Companybox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Typebox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Namebox;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Submitbtn;
    }
}