
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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoteLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridRemoteLoad);
            this.Name = "RemoteLoadForm";
            this.Text = "RemoteLoadForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRemoteLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRemoteLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeColumn;
        private System.Windows.Forms.Button button1;
    }
}