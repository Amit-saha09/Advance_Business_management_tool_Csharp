namespace INVENTORY.Presentation_layer.User_controlls
{
    partial class Editprofile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Namebox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwardbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.conpasswardbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addressbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(115, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uploadbtn
            // 
            this.uploadbtn.Location = new System.Drawing.Point(266, 116);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(75, 23);
            this.uploadbtn.TabIndex = 1;
            this.uploadbtn.Text = "Upload";
            this.uploadbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // Namebox
            // 
            this.Namebox.Depth = 0;
            this.Namebox.Hint = "";
            this.Namebox.Location = new System.Drawing.Point(135, 197);
            this.Namebox.MaxLength = 32767;
            this.Namebox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Namebox.Name = "Namebox";
            this.Namebox.PasswordChar = '\0';
            this.Namebox.SelectedText = "";
            this.Namebox.SelectionLength = 0;
            this.Namebox.SelectionStart = 0;
            this.Namebox.Size = new System.Drawing.Size(143, 23);
            this.Namebox.TabIndex = 3;
            this.Namebox.TabStop = false;
            this.Namebox.UseSystemPasswordChar = false;
            // 
            // passwardbox
            // 
            this.passwardbox.Depth = 0;
            this.passwardbox.Hint = "";
            this.passwardbox.Location = new System.Drawing.Point(135, 260);
            this.passwardbox.MaxLength = 32767;
            this.passwardbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwardbox.Name = "passwardbox";
            this.passwardbox.PasswordChar = '\0';
            this.passwardbox.SelectedText = "";
            this.passwardbox.SelectionLength = 0;
            this.passwardbox.SelectionStart = 0;
            this.passwardbox.Size = new System.Drawing.Size(143, 23);
            this.passwardbox.TabIndex = 3;
            this.passwardbox.TabStop = false;
            this.passwardbox.UseSystemPasswordChar = false;
            // 
            // conpasswardbox
            // 
            this.conpasswardbox.Depth = 0;
            this.conpasswardbox.Hint = "";
            this.conpasswardbox.Location = new System.Drawing.Point(135, 319);
            this.conpasswardbox.MaxLength = 32767;
            this.conpasswardbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.conpasswardbox.Name = "conpasswardbox";
            this.conpasswardbox.PasswordChar = '\0';
            this.conpasswardbox.SelectedText = "";
            this.conpasswardbox.SelectionLength = 0;
            this.conpasswardbox.SelectionStart = 0;
            this.conpasswardbox.Size = new System.Drawing.Size(143, 23);
            this.conpasswardbox.TabIndex = 3;
            this.conpasswardbox.TabStop = false;
            this.conpasswardbox.UseSystemPasswordChar = false;
            this.conpasswardbox.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
            // 
            // emailbox
            // 
            this.emailbox.Depth = 0;
            this.emailbox.Hint = "";
            this.emailbox.Location = new System.Drawing.Point(135, 388);
            this.emailbox.MaxLength = 32767;
            this.emailbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailbox.Name = "emailbox";
            this.emailbox.PasswordChar = '\0';
            this.emailbox.SelectedText = "";
            this.emailbox.SelectionLength = 0;
            this.emailbox.SelectionStart = 0;
            this.emailbox.Size = new System.Drawing.Size(143, 23);
            this.emailbox.TabIndex = 3;
            this.emailbox.TabStop = false;
            this.emailbox.UseSystemPasswordChar = false;
            // 
            // addressbox
            // 
            this.addressbox.Depth = 0;
            this.addressbox.Hint = "";
            this.addressbox.Location = new System.Drawing.Point(135, 445);
            this.addressbox.MaxLength = 32767;
            this.addressbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.addressbox.Name = "addressbox";
            this.addressbox.PasswordChar = '\0';
            this.addressbox.SelectedText = "";
            this.addressbox.SelectionLength = 0;
            this.addressbox.SelectionStart = 0;
            this.addressbox.Size = new System.Drawing.Size(143, 23);
            this.addressbox.TabIndex = 3;
            this.addressbox.TabStop = false;
            this.addressbox.UseSystemPasswordChar = false;
            this.addressbox.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Newpass:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confrmpass:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Editprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.conpasswardbox);
            this.Controls.Add(this.passwardbox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Editprofile";
            this.Size = new System.Drawing.Size(395, 543);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Namebox;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwardbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField conpasswardbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField addressbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
