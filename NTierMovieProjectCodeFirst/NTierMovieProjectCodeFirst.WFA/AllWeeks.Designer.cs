namespace NTierMovieProjectCodeFirst.WFA
{
    partial class AllWeeks
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
            this.datagriedWeeks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagriedWeeks)).BeginInit();
            this.SuspendLayout();
            // 
            // datagriedWeeks
            // 
            this.datagriedWeeks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriedWeeks.Location = new System.Drawing.Point(13, 13);
            this.datagriedWeeks.Margin = new System.Windows.Forms.Padding(4);
            this.datagriedWeeks.Name = "datagriedWeeks";
            this.datagriedWeeks.RowHeadersWidth = 51;
            this.datagriedWeeks.Size = new System.Drawing.Size(673, 382);
            this.datagriedWeeks.TabIndex = 3;
            // 
            // AllWeeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 399);
            this.Controls.Add(this.datagriedWeeks);
            this.Name = "AllWeeks";
            this.Text = "AllWeeks";
            this.Load += new System.EventHandler(this.AllWeeks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagriedWeeks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagriedWeeks;
    }
}