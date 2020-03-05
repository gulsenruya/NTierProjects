namespace NTierECommerceProject.WFA
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.orderDetailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryAddToolStripMenuItem,
            this.categoryListToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem,
            this.productListToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderListToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // orderDetailToolStripMenuItem
            // 
            this.orderDetailToolStripMenuItem.Name = "orderDetailToolStripMenuItem";
            this.orderDetailToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.orderDetailToolStripMenuItem.Text = "Order Detail";
            // 
            // categoryAddToolStripMenuItem
            // 
            this.categoryAddToolStripMenuItem.Name = "categoryAddToolStripMenuItem";
            this.categoryAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoryAddToolStripMenuItem.Text = "Category Add";
            // 
            // categoryListToolStripMenuItem
            // 
            this.categoryListToolStripMenuItem.Name = "categoryListToolStripMenuItem";
            this.categoryListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoryListToolStripMenuItem.Text = "Category List";
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productAddToolStripMenuItem.Text = "Product Add";
            // 
            // productListToolStripMenuItem
            // 
            this.productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            this.productListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productListToolStripMenuItem.Text = "Product List";
            // 
            // orderListToolStripMenuItem
            // 
            this.orderListToolStripMenuItem.Name = "orderListToolStripMenuItem";
            this.orderListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderListToolStripMenuItem.Text = "Order List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailToolStripMenuItem;
    }
}

