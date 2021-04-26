namespace INVENTORY.Presentation_layer.User_controlls
{
    partial class Categoryinfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Catpic = new System.Windows.Forms.PictureBox();
            this.catname = new System.Windows.Forms.Label();
            this.Companyname = new System.Windows.Forms.Label();
            this.Editbtn = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Catpic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Editbtn);
            this.groupBox1.Controls.Add(this.Companyname);
            this.groupBox1.Controls.Add(this.catname);
            this.groupBox1.Controls.Add(this.Catpic);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Details";
            // 
            // Catpic
            // 
            this.Catpic.Location = new System.Drawing.Point(6, 19);
            this.Catpic.Name = "Catpic";
            this.Catpic.Size = new System.Drawing.Size(125, 85);
            this.Catpic.TabIndex = 0;
            this.Catpic.TabStop = false;
            // 
            // catname
            // 
            this.catname.AutoSize = true;
            this.catname.Location = new System.Drawing.Point(6, 107);
            this.catname.Name = "catname";
            this.catname.Size = new System.Drawing.Size(35, 13);
            this.catname.TabIndex = 1;
            this.catname.Text = "label1";
            // 
            // Companyname
            // 
            this.Companyname.AutoSize = true;
            this.Companyname.Location = new System.Drawing.Point(6, 130);
            this.Companyname.Name = "Companyname";
            this.Companyname.Size = new System.Drawing.Size(35, 13);
            this.Companyname.TabIndex = 2;
            this.Companyname.Text = "label2";
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(46, 154);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(46, 21);
            this.Editbtn.TabIndex = 4;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(117, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 18);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Categoryinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.groupBox1);
            this.Name = "Categoryinfo";
            this.Size = new System.Drawing.Size(147, 190);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Catpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton Editbtn;
        private System.Windows.Forms.Label Companyname;
        private System.Windows.Forms.Label catname;
        private System.Windows.Forms.PictureBox Catpic;
    }
}
