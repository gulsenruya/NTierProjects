namespace NTierMovieProjectCodeFirst.WFA
{
    partial class AddSaloon
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
            this.nudSaloonCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnSaloonSave = new System.Windows.Forms.Button();
            this.tbxSaloonName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaloonCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudSaloonCapacity);
            this.groupBox1.Controls.Add(this.btnSaloonSave);
            this.groupBox1.Controls.Add(this.tbxSaloonName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(545, 306);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Saloons";
            // 
            // nudSaloonCapacity
            // 
            this.nudSaloonCapacity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSaloonCapacity.Location = new System.Drawing.Point(216, 133);
            this.nudSaloonCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.nudSaloonCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSaloonCapacity.Name = "nudSaloonCapacity";
            this.nudSaloonCapacity.Size = new System.Drawing.Size(207, 34);
            this.nudSaloonCapacity.TabIndex = 4;
            // 
            // btnSaloonSave
            // 
            this.btnSaloonSave.Location = new System.Drawing.Point(218, 195);
            this.btnSaloonSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaloonSave.Name = "btnSaloonSave";
            this.btnSaloonSave.Size = new System.Drawing.Size(205, 56);
            this.btnSaloonSave.TabIndex = 3;
            this.btnSaloonSave.Text = "ADD SALOON";
            this.btnSaloonSave.UseVisualStyleBackColor = true;
            this.btnSaloonSave.Click += new System.EventHandler(this.btnSaloonSave_Click);
            // 
            // tbxSaloonName
            // 
            this.tbxSaloonName.Location = new System.Drawing.Point(216, 84);
            this.tbxSaloonName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSaloonName.Name = "tbxSaloonName";
            this.tbxSaloonName.Size = new System.Drawing.Size(205, 34);
            this.tbxSaloonName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saloon Name:";
            // 
            // AddSaloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSaloon";
            this.Text = "AddSaloon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaloonCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudSaloonCapacity;
        private System.Windows.Forms.Button btnSaloonSave;
        private System.Windows.Forms.TextBox tbxSaloonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}