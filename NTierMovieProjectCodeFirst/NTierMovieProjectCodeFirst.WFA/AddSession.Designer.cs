namespace NTierMovieProjectCodeFirst.WFA
{
    partial class AddSession
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
            this.btnAddSession = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxHour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMinute = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxMinute);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxHour);
            this.groupBox1.Controls.Add(this.btnAddSession);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(527, 266);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Session";
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(156, 178);
            this.btnAddSession.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(206, 46);
            this.btnAddSession.TabIndex = 3;
            this.btnAddSession.Text = "ADD SESSİON";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hour:";
            // 
            // tbxHour
            // 
            this.tbxHour.Location = new System.Drawing.Point(189, 69);
            this.tbxHour.Name = "tbxHour";
            this.tbxHour.Size = new System.Drawing.Size(142, 34);
            this.tbxHour.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minute:";
            // 
            // tbxMinute
            // 
            this.tbxMinute.Location = new System.Drawing.Point(192, 116);
            this.tbxMinute.Name = "tbxMinute";
            this.tbxMinute.Size = new System.Drawing.Size(142, 34);
            this.tbxMinute.TabIndex = 6;
            // 
            // AddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 345);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSession";
            this.Text = "AddSession";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxHour;
    }
}