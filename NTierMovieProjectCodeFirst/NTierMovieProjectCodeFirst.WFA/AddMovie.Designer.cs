namespace NTierMovieProjectCodeFirst.WFA
{
    partial class AddMovie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMovieDuration = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescripton = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMovieDuration);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tbxDescripton);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(565, 436);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Movies";
            // 
            // nudMovieDuration
            // 
            this.nudMovieDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMovieDuration.Location = new System.Drawing.Point(215, 262);
            this.nudMovieDuration.Margin = new System.Windows.Forms.Padding(4);
            this.nudMovieDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMovieDuration.Name = "nudMovieDuration";
            this.nudMovieDuration.Size = new System.Drawing.Size(275, 34);
            this.nudMovieDuration.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(215, 316);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(273, 54);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ADD MOVIE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(215, 52);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(273, 34);
            this.tbxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // tbxDescripton
            // 
            this.tbxDescripton.Location = new System.Drawing.Point(215, 115);
            this.tbxDescripton.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescripton.Multiline = true;
            this.tbxDescripton.Name = "tbxDescripton";
            this.tbxDescripton.Size = new System.Drawing.Size(275, 106);
            this.tbxDescripton.TabIndex = 2;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(597, 490);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddMovie";
            this.Text = "Add Movie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudMovieDuration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDescripton;
    }
}