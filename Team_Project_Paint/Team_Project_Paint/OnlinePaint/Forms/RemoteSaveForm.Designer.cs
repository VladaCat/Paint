
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbImageFormat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(122, 91);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(132, 148);
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
            this.cmbImageFormat.Location = new System.Drawing.Point(293, 34);
            this.cmbImageFormat.Name = "cmbImageFormat";
            this.cmbImageFormat.Size = new System.Drawing.Size(121, 21);
            this.cmbImageFormat.TabIndex = 2;
            this.cmbImageFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RemoteSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbImageFormat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFileName);
            this.Name = "RemoteSaveForm";
            this.Text = "RemoteSaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbImageFormat;
    }
}