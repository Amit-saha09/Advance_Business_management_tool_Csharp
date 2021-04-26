namespace INVENTORY.Presentation_layer
{
    partial class Suplieraddform
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
            this.suplypicbox = new System.Windows.Forms.PictureBox();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Namebox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Countrybox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Addressbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Emailbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Phonebox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suplypicbox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Phonebox);
            this.panel1.Controls.Add(this.Emailbox);
            this.panel1.Controls.Add(this.Addressbox);
            this.panel1.Controls.Add(this.Countrybox);
            this.panel1.Controls.Add(this.Namebox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
        //    this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 304);
            this.panel1.TabIndex = 0;
//            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.Uploadbtn);
            this.groupBox1.Controls.Add(this.suplypicbox);
       //     this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Supplier";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // suplypicbox
            // 
            this.suplypicbox.Location = new System.Drawing.Point(36, 31);
            this.suplypicbox.Name = "suplypicbox";
            this.suplypicbox.Size = new System.Drawing.Size(143, 144);
            this.suplypicbox.TabIndex = 0;
            this.suplypicbox.TabStop = false;
//            this.suplypicbox.Click += new System.EventHandler(this.suplypicbox_Click);
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(36, 211);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(143, 44);
            this.Uploadbtn.TabIndex = 1;
            this.Uploadbtn.Text = "Upload";
            this.Uploadbtn.UseVisualStyleBackColor = true;
//            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Namebox
            // 
            this.Namebox.Depth = 0;
            this.Namebox.Hint = "";
            this.Namebox.Location = new System.Drawing.Point(376, 27);
            this.Namebox.MaxLength = 32767;
            this.Namebox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Namebox.Name = "Namebox";
            this.Namebox.PasswordChar = '\0';
            this.Namebox.SelectedText = "";
            this.Namebox.SelectionLength = 0;
            this.Namebox.SelectionStart = 0;
            this.Namebox.Size = new System.Drawing.Size(127, 23);
            this.Namebox.TabIndex = 2;
            this.Namebox.TabStop = false;
            this.Namebox.UseSystemPasswordChar = false;
//            this.Namebox.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
//            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
//            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
//            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone";
//            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Countrybox
            // 
            this.Countrybox.Depth = 0;
            this.Countrybox.Hint = "";
            this.Countrybox.Location = new System.Drawing.Point(376, 73);
            this.Countrybox.MaxLength = 32767;
            this.Countrybox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Countrybox.Name = "Countrybox";
            this.Countrybox.PasswordChar = '\0';
            this.Countrybox.SelectedText = "";
            this.Countrybox.SelectionLength = 0;
            this.Countrybox.SelectionStart = 0;
            this.Countrybox.Size = new System.Drawing.Size(127, 23);
            this.Countrybox.TabIndex = 2;
            this.Countrybox.TabStop = false;
            this.Countrybox.UseSystemPasswordChar = false;
//            this.Countrybox.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // Addressbox
            // 
            this.Addressbox.Depth = 0;
            this.Addressbox.Hint = "";
            this.Addressbox.Location = new System.Drawing.Point(376, 118);
            this.Addressbox.MaxLength = 32767;
            this.Addressbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.PasswordChar = '\0';
            this.Addressbox.SelectedText = "";
            this.Addressbox.SelectionLength = 0;
            this.Addressbox.SelectionStart = 0;
            this.Addressbox.Size = new System.Drawing.Size(127, 23);
            this.Addressbox.TabIndex = 2;
            this.Addressbox.TabStop = false;
            this.Addressbox.UseSystemPasswordChar = false;
//            this.Addressbox.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // Emailbox
            // 
            this.Emailbox.Depth = 0;
            this.Emailbox.Hint = "";
            this.Emailbox.Location = new System.Drawing.Point(376, 162);
            this.Emailbox.MaxLength = 32767;
            this.Emailbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.PasswordChar = '\0';
            this.Emailbox.SelectedText = "";
            this.Emailbox.SelectionLength = 0;
            this.Emailbox.SelectionStart = 0;
            this.Emailbox.Size = new System.Drawing.Size(127, 23);
            this.Emailbox.TabIndex = 2;
            this.Emailbox.TabStop = false;
            this.Emailbox.UseSystemPasswordChar = false;
//            this.Emailbox.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // Phonebox
            // 
            this.Phonebox.Depth = 0;
            this.Phonebox.Hint = "";
            this.Phonebox.Location = new System.Drawing.Point(376, 214);
            this.Phonebox.MaxLength = 32767;
            this.Phonebox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Phonebox.Name = "Phonebox";
            this.Phonebox.PasswordChar = '\0';
            this.Phonebox.SelectedText = "";
            this.Phonebox.SelectionLength = 0;
            this.Phonebox.SelectionStart = 0;
            this.Phonebox.Size = new System.Drawing.Size(127, 23);
            this.Phonebox.TabIndex = 2;
            this.Phonebox.TabStop = false;
            this.Phonebox.UseSystemPasswordChar = false;
//            this.Phonebox.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Closebtn);
            this.groupBox2.Controls.Add(this.Submitbtn);
            this.groupBox2.Location = new System.Drawing.Point(231, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 297);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
//            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Submitbtn
            // 
            this.Submitbtn.Location = new System.Drawing.Point(18, 256);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(75, 23);
            this.Submitbtn.TabIndex = 0;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
//            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(197, 256);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(75, 23);
            this.Closebtn.TabIndex = 0;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
//            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Suplieraddform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 306);
            this.Controls.Add(this.panel1);
            this.Name = "Suplieraddform";
            this.Text = "Suplieraddform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suplypicbox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.PictureBox suplypicbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Namebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Phonebox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Emailbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Addressbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField Countrybox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Submitbtn;
    }
}