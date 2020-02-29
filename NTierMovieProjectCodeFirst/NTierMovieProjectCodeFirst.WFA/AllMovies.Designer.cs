namespace NTierMovieProjectCodeFirst.WFA
{
    partial class AllMovies
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
            this.datagriedMovies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagriedMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // datagriedMovies
            // 
            this.datagriedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagriedMovies.Location = new System.Drawing.Point(10, 4);
            this.datagriedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.datagriedMovies.Name = "datagriedMovies";
            this.datagriedMovies.RowHeadersWidth = 51;
            this.datagriedMovies.Size = new System.Drawing.Size(920, 530);
            this.datagriedMovies.TabIndex = 2;
            // 
            // AllMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 546);
            this.Controls.Add(this.datagriedMovies);
            this.Name = "AllMovies";
            this.Text = "AllMovies";
            this.Load += new System.EventHandler(this.AllMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagriedMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagriedMovies;
    }
}