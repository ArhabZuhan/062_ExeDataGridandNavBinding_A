
namespace ExePABD
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label nIMLabel;
            System.Windows.Forms.Label namaMhsLabel;
            System.Windows.Forms.Label alamatMhsLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label phoneMhsLabel;
            this.prodiTIDataSet = new ExePABD.ProdiTIDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new ExePABD.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.tableAdapterManager = new ExePABD.ProdiTIDataSetTableAdapters.TableAdapterManager();
            this.mahasiswaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mahasiswaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nIMTextBox = new System.Windows.Forms.TextBox();
            this.namaMhsTextBox = new System.Windows.Forms.TextBox();
            this.alamatMhsTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.phoneMhsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            nIMLabel = new System.Windows.Forms.Label();
            namaMhsLabel = new System.Windows.Forms.Label();
            alamatMhsLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            phoneMhsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingNavigator)).BeginInit();
            this.mahasiswaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MahasiswaTableAdapter = this.mahasiswaTableAdapter;
            this.tableAdapterManager.UpdateOrder = ExePABD.ProdiTIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mahasiswaBindingNavigator
            // 
            this.mahasiswaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mahasiswaBindingNavigator.BindingSource = this.mahasiswaBindingSource;
            this.mahasiswaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mahasiswaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mahasiswaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mahasiswaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mahasiswaBindingNavigatorSaveItem});
            this.mahasiswaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mahasiswaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mahasiswaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mahasiswaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mahasiswaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mahasiswaBindingNavigator.Name = "mahasiswaBindingNavigator";
            this.mahasiswaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mahasiswaBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.mahasiswaBindingNavigator.TabIndex = 0;
            this.mahasiswaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // mahasiswaBindingNavigatorSaveItem
            // 
            this.mahasiswaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mahasiswaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mahasiswaBindingNavigatorSaveItem.Image")));
            this.mahasiswaBindingNavigatorSaveItem.Name = "mahasiswaBindingNavigatorSaveItem";
            this.mahasiswaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mahasiswaBindingNavigatorSaveItem.Text = "Save Data";
            this.mahasiswaBindingNavigatorSaveItem.Click += new System.EventHandler(this.mahasiswaBindingNavigatorSaveItem_Click);
            // 
            // nIMLabel
            // 
            nIMLabel.AutoSize = true;
            nIMLabel.Location = new System.Drawing.Point(276, 119);
            nIMLabel.Name = "nIMLabel";
            nIMLabel.Size = new System.Drawing.Size(36, 17);
            nIMLabel.TabIndex = 1;
            nIMLabel.Text = "NIM:";
            // 
            // nIMTextBox
            // 
            this.nIMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.nIMTextBox.Location = new System.Drawing.Point(367, 116);
            this.nIMTextBox.Name = "nIMTextBox";
            this.nIMTextBox.Size = new System.Drawing.Size(100, 22);
            this.nIMTextBox.TabIndex = 2;
            // 
            // namaMhsLabel
            // 
            namaMhsLabel.AutoSize = true;
            namaMhsLabel.Location = new System.Drawing.Point(276, 147);
            namaMhsLabel.Name = "namaMhsLabel";
            namaMhsLabel.Size = new System.Drawing.Size(79, 17);
            namaMhsLabel.TabIndex = 3;
            namaMhsLabel.Text = "Nama Mhs:";
            // 
            // namaMhsTextBox
            // 
            this.namaMhsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NamaMhs", true));
            this.namaMhsTextBox.Location = new System.Drawing.Point(367, 144);
            this.namaMhsTextBox.Name = "namaMhsTextBox";
            this.namaMhsTextBox.Size = new System.Drawing.Size(100, 22);
            this.namaMhsTextBox.TabIndex = 4;
            // 
            // alamatMhsLabel
            // 
            alamatMhsLabel.AutoSize = true;
            alamatMhsLabel.Location = new System.Drawing.Point(276, 175);
            alamatMhsLabel.Name = "alamatMhsLabel";
            alamatMhsLabel.Size = new System.Drawing.Size(85, 17);
            alamatMhsLabel.TabIndex = 5;
            alamatMhsLabel.Text = "Alamat Mhs:";
            // 
            // alamatMhsTextBox
            // 
            this.alamatMhsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "AlamatMhs", true));
            this.alamatMhsTextBox.Location = new System.Drawing.Point(367, 172);
            this.alamatMhsTextBox.Name = "alamatMhsTextBox";
            this.alamatMhsTextBox.Size = new System.Drawing.Size(100, 22);
            this.alamatMhsTextBox.TabIndex = 6;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(276, 203);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(35, 17);
            sexLabel.TabIndex = 7;
            sexLabel.Text = "Sex:";
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(367, 200);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(100, 22);
            this.sexTextBox.TabIndex = 8;
            // 
            // phoneMhsLabel
            // 
            phoneMhsLabel.AutoSize = true;
            phoneMhsLabel.Location = new System.Drawing.Point(276, 231);
            phoneMhsLabel.Name = "phoneMhsLabel";
            phoneMhsLabel.Size = new System.Drawing.Size(83, 17);
            phoneMhsLabel.TabIndex = 9;
            phoneMhsLabel.Text = "Phone Mhs:";
            // 
            // phoneMhsTextBox
            // 
            this.phoneMhsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "PhoneMhs", true));
            this.phoneMhsTextBox.Location = new System.Drawing.Point(367, 228);
            this.phoneMhsTextBox.Name = "phoneMhsTextBox";
            this.phoneMhsTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneMhsTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(708, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.mahasiswaBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingNavigator)).EndInit();
            this.mahasiswaBindingNavigator.ResumeLayout(false);
            this.mahasiswaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private ProdiTIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mahasiswaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mahasiswaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nIMTextBox;
        private System.Windows.Forms.TextBox namaMhsTextBox;
        private System.Windows.Forms.TextBox alamatMhsTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox phoneMhsTextBox;
        private System.Windows.Forms.Button button1;
    }
}