
namespace Team_Project_Paint
{
    partial class StatsForm
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
            this.dataGridStatistics = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStatistics
            // 
            this.dataGridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistics.Location = new System.Drawing.Point(24, 72);
            this.dataGridStatistics.Name = "dataGridStatistics";
            this.dataGridStatistics.Size = new System.Drawing.Size(741, 334);
            this.dataGridStatistics.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(33, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridStatistics);
            this.Name = "StatsForm";
            this.Text = "Paint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStatistics;
        private System.Windows.Forms.Button backBtn;
    }
}