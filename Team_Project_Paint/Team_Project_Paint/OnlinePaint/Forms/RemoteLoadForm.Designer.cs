
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
            this.createDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtImageId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoteLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRemoteLoad
            // 
            this.dataGridRemoteLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRemoteLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileIdColumn,
            this.fileNameColumn,
            this.createDateColumn,
            this.fileSizeColumn});
            this.dataGridRemoteLoad.Location = new System.Drawing.Point(3, 39);
            this.dataGridRemoteLoad.Name = "dataGridRemoteLoad";
            this.dataGridRemoteLoad.Size = new System.Drawing.Size(776, 388);
            this.dataGridRemoteLoad.TabIndex = 0;
            // 
            // fileIdColumn
            // 
            this.fileIdColumn.HeaderText = "ID";
            this.fileIdColumn.Name = "fileIdColumn";
            this.fileIdColumn.ReadOnly = true;
            this.fileIdColumn.Visible = false;
            // 
            // fileNameColumn
            // 
            this.fileNameColumn.HeaderText = "File Name";
            this.fileNameColumn.Name = "fileNameColumn";
            this.fileNameColumn.ReadOnly = true;
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
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // txtImageId
            // 
            this.txtImageId.Location = new System.Drawing.Point(308, 12);
            this.txtImageId.Name = "txtImageId";
            this.txtImageId.Size = new System.Drawing.Size(100, 20);
            this.txtImageId.TabIndex = 2;
            // 
            // RemoteLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtImageId);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.dataGridRemoteLoad);
            this.Name = "RemoteLoadForm";
            this.Text = "RemoteLoadForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoteLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRemoteLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeColumn;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtImageId;
    }
}