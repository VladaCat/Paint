
namespace Team_Project_Paint
{
    partial class RemoteLoadForm
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
            this.dataGridRemoteLoad = new System.Windows.Forms.DataGridView();
            this.fileIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtImageId = new System.Windows.Forms.TextBox();
            this.btnTemoLoadFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoteLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRemoteLoad
            // 
            this.dataGridRemoteLoad.AllowUserToAddRows = false;
            this.dataGridRemoteLoad.AllowUserToDeleteRows = false;
            this.dataGridRemoteLoad.AllowUserToOrderColumns = true;
            this.dataGridRemoteLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRemoteLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIdColumn,
            this.fileNameColumn,
            this.ImageType,
            this.createDateColumn,
            this.fileSizeColumn});
            this.dataGridRemoteLoad.Location = new System.Drawing.Point(3, 39);
            this.dataGridRemoteLoad.Name = "dataGridRemoteLoad";
            this.dataGridRemoteLoad.ReadOnly = true;
            this.dataGridRemoteLoad.Size = new System.Drawing.Size(776, 388);
            this.dataGridRemoteLoad.TabIndex = 0;
            this.dataGridRemoteLoad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRemoteLoad_CellDoubleClick);
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
            this.createDateColumn.HeaderText = "Create Date";
            this.createDateColumn.Name = "createDateColumn";
            this.createDateColumn.ReadOnly = true;
            // 
            // fileSizeColumn
            // 
            this.fileSizeColumn.HeaderText = "Size";
            this.fileSizeColumn.Name = "fileSizeColumn";
            this.fileSizeColumn.ReadOnly = true;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(213, 10);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            // 
            // txtImageId
            // 
            this.txtImageId.Location = new System.Drawing.Point(308, 12);
            this.txtImageId.Name = "txtImageId";
            this.txtImageId.Size = new System.Drawing.Size(100, 20);
            this.txtImageId.TabIndex = 2;
            // 
            // btnTemoLoadFiles
            // 
            this.btnTemoLoadFiles.Location = new System.Drawing.Point(22, 9);
            this.btnTemoLoadFiles.Name = "btnTemoLoadFiles";
            this.btnTemoLoadFiles.Size = new System.Drawing.Size(75, 23);
            this.btnTemoLoadFiles.TabIndex = 3;
            this.btnTemoLoadFiles.Text = "LoadFiles";
            this.btnTemoLoadFiles.UseVisualStyleBackColor = true;
            this.btnTemoLoadFiles.Click += new System.EventHandler(this.btnTemoLoadFiles_Click);
            // 
            // RemoteLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemoLoadFiles);
            this.Controls.Add(this.txtImageId);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.dataGridRemoteLoad);
            this.Name = "RemoteLoadForm";
            this.Text = "RemoteLoadForm";
            this.VisibleChanged += new System.EventHandler(this.RemoteLoadForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoteLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRemoteLoad;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtImageId;
        private System.Windows.Forms.Button btnTemoLoadFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeColumn;
    }
}