namespace INVENTORY.Presentation_layer
{
    partial class Addcustomer
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Addressbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Phonebox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Emailbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Entrydatebox = new MetroFramework.Controls.MetroDateTime();
            this.Namebox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Productpicbox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 271);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Closebtn);
            this.groupBox2.Controls.Add(this.Submitbtn);
            this.groupBox2.Controls.Add(this.Addressbox);
            this.groupBox2.Controls.Add(this.Phonebox);
            this.groupBox2.Controls.Add(this.Emailbox);
            this.groupBox2.Controls.Add(this.Entrydatebox);
            this.groupBox2.Controls.Add(this.Namebox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(202, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 268);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(125, 240);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(75, 23);
            this.Closebtn.TabIndex = 1;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(6, 240);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 1;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Addressbox
            // 
            this.Addressbox.Depth = 0;
            this.Addressbox.Hint = "";
            this.Addressbox.Location = new System.Drawing.Point(91, 145);
            this.Addressbox.MaxLength = 32767;
            this.Addressbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.PasswordChar = '\0';
            this.Addressbox.SelectedText = "";
            this.Addressbox.SelectionLength = 0;
            this.Addressbox.SelectionStart = 0;
            this.Addressbox.Size = new System.Drawing.Size(109, 23);
            this.Addressbox.TabIndex = 1;
            this.Addressbox.TabStop = false;
            this.Addressbox.UseSystemPasswordChar = false;
            // 
            // Phonebox
            // 
            this.Phonebox.Depth = 0;
            this.Phonebox.Hint = "";
            this.Phonebox.Location = new System.Drawing.Point(91, 98);
            this.Phonebox.MaxLength = 32767;
            this.Phonebox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Phonebox.Name = "Phonebox";
            this.Phonebox.PasswordChar = '\0';
            this.Phonebox.SelectedText = "";
            this.Phonebox.SelectionLength = 0;
            this.Phonebox.SelectionStart = 0;
            this.Phonebox.Size = new System.Drawing.Size(109, 23);
            this.Phonebox.TabIndex = 1;
            this.Phonebox.TabStop = false;
            this.Phonebox.UseSystemPasswordChar = false;
            // 
            // Emailbox
            // 
            this.Emailbox.Depth = 0;
            this.Emailbox.Hint = "";
            this.Emailbox.Location = new System.Drawing.Point(91, 54);
            this.Emailbox.MaxLength = 32767;
            this.Emailbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.PasswordChar = '\0';
            this.Emailbox.SelectedText = "";
            this.Emailbox.SelectionLength = 0;
            this.Emailbox.SelectionStart = 0;
            this.Emailbox.Size = new System.Drawing.Size(109, 23);
            this.Emailbox.TabIndex = 1;
            this.Emailbox.TabStop = false;
            this.Emailbox.UseSystemPasswordChar = false;
            // 
            // Entrydatebox
            // 
            this.Entrydatebox.Location = new System.Drawing.Point(91, 199);
            this.Entrydatebox.MinimumSize = new System.Drawing.Size(0, 29);
            this.Entrydatebox.Name = "Entrydatebox";
            this.Entrydatebox.Size = new System.Drawing.Size(109, 29);
            this.Entrydatebox.TabIndex = 2;
            // 
            // Namebox
            // 
            this.Namebox.Depth = 0;
            this.Namebox.Hint = "";
            this.Namebox.Location = new System.Drawing.Point(91, 19);
            this.Namebox.MaxLength = 32767;
            this.Namebox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Namebox.Name = "Namebox";
            this.Namebox.PasswordChar = '\0';
            this.Namebox.SelectedText = "";
            this.Namebox.SelectionLength = 0;
            this.Namebox.SelectionStart = 0;
            this.Namebox.Size = new System.Drawing.Size(109, 23);
            this.Namebox.TabIndex = 1;
            this.Namebox.TabStop = false;
            this.Namebox.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Entrydate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Uploadbtn);
            this.groupBox1.Controls.Add(this.Productpicbox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddCustomer";
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(62, 185);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(75, 23);
            this.Uploadbtn.TabIndex = 1;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            // 
            // Productpicbox
            // 
            this.Productpicbox.Location = new System.Drawing.Point(18, 19);
            this.Productpicbox.Name = "Productpicbox";
            this.Productpicbox.Size = new System.Drawing.Size(152, 132);
            this.Productpicbox.TabIndex = 0;
            this.Productpicbox.TabStop = false;
            // 
            // Addcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 279);
            this.Controls.Add(this.panel1);
            this.Name = "Addcustomer";
            this.Text = "Addcustomer";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Productpicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.PictureBox Productpicbox;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Submitbtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField Addressbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Phonebox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Emailbox;
        private MetroFramework.Controls.MetroDateTime Entrydatebox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Namebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}