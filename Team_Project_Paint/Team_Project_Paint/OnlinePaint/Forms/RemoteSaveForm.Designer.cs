
namespace Team_Project_Paint
{
    partial class RemoteSaveForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbImageFormat = new System.Windows.Forms.ComboBox();
            this.dataGridRemoteImages = new System.Windows.Forms.DataGridView();
            this.fileIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoteImages)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(137, 14);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbImageFormat
            // 
            this.cmbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageFormat.FormattingEnabled = true;
            this.cmbImageFormat.Items.AddRange(new object[] {
            "bmp",
            "jpeg",
            "png",
            "json"});
            this.cmbImageFormat.Location = new System.Drawing.Point(264, 13);
            this.cmbImageFormat.Name = "cmbImageFormat";
            this.cmbImageFormat.Size = new System.Drawing.Size(121, 21);
            this.cmbImageFormat.TabIndex = 2;
            // 
            // dataGridRemoteImages
            // 
            this.dataGridRemoteImages.AllowUserToAddRows = false;
            this.dataGridRemoteImages.AllowUserToDeleteRows = false;
            this.dataGridRemoteImages.AllowUserToOrderColumns = true;
            this.dataGridRemoteImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRemoteImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIdColumn,
            this.fileNameColumn,
            this.ImageType,
            this.createDateColumn,
            this.fileSizeColumn,
            this.DeleteButton});
            this.dataGridRemoteImages.Location = new System.Drawing.Point(12, 50);
            this.dataGridRemoteImages.Name = "dataGridRemoteImages";
            this.dataGridRemoteImages.ReadOnly = true;
            this.dataGridRemoteImages.Size = new System.Drawing.Size(776, 388);
            this.dataGridRemoteImages.TabIndex = 3;
            this.dataGridRemoteImages.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRemoteImages_CellDoubleClick);
            // 
            // fileIdColumn
            // 
            this.fileIdColumn.HeaderText = "ID";
            this.fileIdColumn.Name = "fileIdColumn";
            this.fileIdColumn.ReadOnly = true;
            // 
            // fileNameColumn
            // 
            this.fileNameColumn.HeaderText = "File Name";
            this.fileNameColumn.Name = "fileNameColumn";
            this.fileNameColumn.ReadOnly = true;
            // 
            // ImageType
            // 
            this.ImageType.HeaderText = "Image Type";
            this.ImageType.Name = "ImageType";
            this.ImageType.ReadOnly = true;
            // 
            // createDateColumn
            // 
            dataGridViewCellStyle9.Format = "G";
            dataGridViewCellStyle9.NullValue = null;
            this.createDateColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.createDateColumn.HeaderText = "Create Date";
            this.createDateColumn.Name = "createDateColumn";
            this.createDateColumn.ReadOnly = true;
            // 
            // fileSizeColumn
            // 
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.fileSizeColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.fileSizeColumn.HeaderText = "Size";
            this.fileSizeColumn.Name = "fileSizeColumn";
            this.fileSizeColumn.ReadOnly = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Delete";
            // 
            // RemoteSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridRemoteImages);
            this.Controls.Add(this.cmbImageFormat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFileName);
            this.Name = "RemoteSaveForm";
            this.Text = "RemoteSaveForm";
            this.VisibleChanged += new System.EventHandler(this.RemoteSaveForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoteImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbImageFormat;
        private System.Windows.Forms.DataGridView dataGridRemoteImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}