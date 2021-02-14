
namespace CashWidget
{
    partial class CashWidgetMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashWidgetMainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.addMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionsToolStripMenuItem,
            this.manageTransactionsToolStripMenuItem,
            this.viewTransactionsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton1.Text = "Transactions";
            // 
            // addTransactionsToolStripMenuItem
            // 
            this.addTransactionsToolStripMenuItem.Name = "addTransactionsToolStripMenuItem";
            this.addTransactionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addTransactionsToolStripMenuItem.Text = "Add Transactions";
            this.addTransactionsToolStripMenuItem.Click += new System.EventHandler(this.addTransactionsToolStripMenuItem_Click);
            // 
            // manageTransactionsToolStripMenuItem
            // 
            this.manageTransactionsToolStripMenuItem.Name = "manageTransactionsToolStripMenuItem";
            this.manageTransactionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.manageTransactionsToolStripMenuItem.Text = "Manage Transactions";
            // 
            // viewTransactionsToolStripMenuItem
            // 
            this.viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem";
            this.viewTransactionsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewTransactionsToolStripMenuItem.Text = "View Transactions";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoriesToolStripMenuItem,
            this.manageCategoriesToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(68, 22);
            this.toolStripDropDownButton2.Text = "Category";
            // 
            // addCategoriesToolStripMenuItem
            // 
            this.addCategoriesToolStripMenuItem.Name = "addCategoriesToolStripMenuItem";
            this.addCategoriesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addCategoriesToolStripMenuItem.Text = "Add Categories";
            // 
            // manageCategoriesToolStripMenuItem
            // 
            this.manageCategoriesToolStripMenuItem.Name = "manageCategoriesToolStripMenuItem";
            this.manageCategoriesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manageCategoriesToolStripMenuItem.Text = "Manage Categories";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMethodToolStripMenuItem,
            this.manageMethodToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(117, 22);
            this.toolStripDropDownButton3.Text = "Payment Methods";
            // 
            // addMethodToolStripMenuItem
            // 
            this.addMethodToolStripMenuItem.Name = "addMethodToolStripMenuItem";
            this.addMethodToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addMethodToolStripMenuItem.Text = "Add Method";
            // 
            // manageMethodToolStripMenuItem
            // 
            this.manageMethodToolStripMenuItem.Name = "manageMethodToolStripMenuItem";
            this.manageMethodToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.manageMethodToolStripMenuItem.Text = "Manage Method";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 471);
            this.dataGridView1.TabIndex = 1;
            // 
            // CashWidgetMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CashWidgetMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashWidget";
            this.Load += new System.EventHandler(this.CashWidgetMainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem addTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem addCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem addMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMethodToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

