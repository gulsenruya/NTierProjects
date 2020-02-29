namespace NTierMovieProjectCodeFirst.WFA
{
    partial class AllSessions
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
            this.dataGriedSessions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGriedSessions
            // 
            this.dataGriedSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriedSessions.Location = new System.Drawing.Point(12, 12);
            this.dataGriedSessions.Name = "dataGriedSessions";
            this.dataGriedSessions.RowHeadersWidth = 51;
            this.dataGriedSessions.RowTemplate.Height = 24;
            this.dataGriedSessions.Size = new System.Drawing.Size(439, 503);
            this.dataGriedSessions.TabIndex = 1;
            // 
            // AllSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 536);
            this.Controls.Add(this.dataGriedSessions);
            this.Name = "AllSessions";
            this.Text = "AllSessions";
            this.Load += new System.EventHandler(this.AllSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedSessions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGriedSessions;
    }
}