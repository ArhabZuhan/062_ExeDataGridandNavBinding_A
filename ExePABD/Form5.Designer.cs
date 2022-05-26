
namespace ExePABD
{
    partial class Form5
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
            System.Windows.Forms.Label nIMLabel;
            System.Windows.Forms.Label namaMhsLabel;
            System.Windows.Forms.Label alamatMhsLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label phoneMhsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.textBoxNamaMhs = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxNoTelp = new System.Windows.Forms.TextBox();
            nIMLabel = new System.Windows.Forms.Label();
            namaMhsLabel = new System.Windows.Forms.Label();
            alamatMhsLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            phoneMhsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nIMLabel
            // 
            nIMLabel.AutoSize = true;
            nIMLabel.Location = new System.Drawing.Point(277, 97);
            nIMLabel.Name = "nIMLabel";
            nIMLabel.Size = new System.Drawing.Size(36, 17);
            nIMLabel.TabIndex = 11;
            nIMLabel.Text = "NIM:";
            // 
            // namaMhsLabel
            // 
            namaMhsLabel.AutoSize = true;
            namaMhsLabel.Location = new System.Drawing.Point(277, 125);
            namaMhsLabel.Name = "namaMhsLabel";
            namaMhsLabel.Size = new System.Drawing.Size(79, 17);
            namaMhsLabel.TabIndex = 13;
            namaMhsLabel.Text = "Nama Mhs:";
            // 
            // alamatMhsLabel
            // 
            alamatMhsLabel.AutoSize = true;
            alamatMhsLabel.Location = new System.Drawing.Point(277, 153);
            alamatMhsLabel.Name = "alamatMhsLabel";
            alamatMhsLabel.Size = new System.Drawing.Size(85, 17);
            alamatMhsLabel.TabIndex = 15;
            alamatMhsLabel.Text = "Alamat Mhs:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(277, 181);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(35, 17);
            sexLabel.TabIndex = 17;
            sexLabel.Text = "Sex:";
            // 
            // phoneMhsLabel
            // 
            phoneMhsLabel.AutoSize = true;
            phoneMhsLabel.Location = new System.Drawing.Point(277, 209);
            phoneMhsLabel.Name = "phoneMhsLabel";
            phoneMhsLabel.Size = new System.Drawing.Size(83, 17);
            phoneMhsLabel.TabIndex = 19;
            phoneMhsLabel.Text = "Phone Mhs:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(708, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 22;
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(396, 91);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(100, 22);
            this.textBoxNIM.TabIndex = 23;
            // 
            // textBoxNamaMhs
            // 
            this.textBoxNamaMhs.Location = new System.Drawing.Point(396, 122);
            this.textBoxNamaMhs.Name = "textBoxNamaMhs";
            this.textBoxNamaMhs.Size = new System.Drawing.Size(100, 22);
            this.textBoxNamaMhs.TabIndex = 24;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(396, 150);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(100, 22);
            this.textBoxAlamat.TabIndex = 25;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(396, 181);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(100, 22);
            this.textBoxGender.TabIndex = 26;
            // 
            // textBoxNoTelp
            // 
            this.textBoxNoTelp.Location = new System.Drawing.Point(396, 209);
            this.textBoxNoTelp.Name = "textBoxNoTelp";
            this.textBoxNoTelp.Size = new System.Drawing.Size(100, 22);
            this.textBoxNoTelp.TabIndex = 27;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNoTelp);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNamaMhs);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nIMLabel);
            this.Controls.Add(namaMhsLabel);
            this.Controls.Add(alamatMhsLabel);
            this.Controls.Add(sexLabel);
            this.Controls.Add(phoneMhsLabel);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBoxNIM;
        public System.Windows.Forms.TextBox textBoxNamaMhs;
        public System.Windows.Forms.TextBox textBoxAlamat;
        public System.Windows.Forms.TextBox textBoxGender;
        public System.Windows.Forms.TextBox textBoxNoTelp;
    }
}