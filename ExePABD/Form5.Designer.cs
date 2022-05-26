
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
            this.nIMTextBox = new System.Windows.Forms.TextBox();
            this.namaMhsTextBox = new System.Windows.Forms.TextBox();
            this.alamatMhsTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.phoneMhsTextBox = new System.Windows.Forms.TextBox();
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
            // nIMTextBox
            // 
            this.nIMTextBox.Location = new System.Drawing.Point(368, 94);
            this.nIMTextBox.Name = "nIMTextBox";
            this.nIMTextBox.Size = new System.Drawing.Size(100, 22);
            this.nIMTextBox.TabIndex = 12;
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
            // namaMhsTextBox
            // 
            this.namaMhsTextBox.Location = new System.Drawing.Point(368, 122);
            this.namaMhsTextBox.Name = "namaMhsTextBox";
            this.namaMhsTextBox.Size = new System.Drawing.Size(100, 22);
            this.namaMhsTextBox.TabIndex = 14;
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
            // alamatMhsTextBox
            // 
            this.alamatMhsTextBox.Location = new System.Drawing.Point(368, 150);
            this.alamatMhsTextBox.Name = "alamatMhsTextBox";
            this.alamatMhsTextBox.Size = new System.Drawing.Size(100, 22);
            this.alamatMhsTextBox.TabIndex = 16;
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
            // sexTextBox
            // 
            this.sexTextBox.Location = new System.Drawing.Point(368, 178);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(100, 22);
            this.sexTextBox.TabIndex = 18;
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
            // phoneMhsTextBox
            // 
            this.phoneMhsTextBox.Location = new System.Drawing.Point(368, 206);
            this.phoneMhsTextBox.Name = "phoneMhsTextBox";
            this.phoneMhsTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneMhsTextBox.TabIndex = 20;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nIMLabel);
            this.Controls.Add(this.nIMTextBox);
            this.Controls.Add(namaMhsLabel);
            this.Controls.Add(this.namaMhsTextBox);
            this.Controls.Add(alamatMhsLabel);
            this.Controls.Add(this.alamatMhsTextBox);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(phoneMhsLabel);
            this.Controls.Add(this.phoneMhsTextBox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nIMTextBox;
        private System.Windows.Forms.TextBox namaMhsTextBox;
        private System.Windows.Forms.TextBox alamatMhsTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox phoneMhsTextBox;
    }
}