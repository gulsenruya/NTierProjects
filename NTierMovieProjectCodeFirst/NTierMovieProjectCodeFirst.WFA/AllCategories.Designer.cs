namespace NTierMovieProjectCodeFirst.WFA
{
    partial class AllCategories
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
            this.dataGriedCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGriedCategories
            // 
            this.dataGriedCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriedCategories.Location = new System.Drawing.Point(12, 12);
            this.dataGriedCategories.Name = "dataGriedCategories";
            this.dataGriedCategories.RowHeadersWidth = 51;
            this.dataGriedCategories.RowTemplate.Height = 24;
            this.dataGriedCategories.Size = new System.Drawing.Size(838, 499);
            this.dataGriedCategories.TabIndex = 0;
            
            // 
            // AllCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 525);
            this.Controls.Add(this.dataGriedCategories);
            this.Name = "AllCategories";
            this.Text = "AllCategories";
            this.Load += new System.EventHandler(this.AllCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGriedCategories;
    }
}