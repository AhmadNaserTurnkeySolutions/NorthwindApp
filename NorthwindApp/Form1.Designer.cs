namespace NorthwindApp
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.q1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllCustumersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.q2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.q3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.q4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excersizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ex2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queriesToolStripMenuItem,
            this.excersizesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.q1ToolStripMenuItem,
            this.q2ToolStripMenuItem,
            this.q3ToolStripMenuItem,
            this.q4ToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // q1ToolStripMenuItem
            // 
            this.q1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllCustumersToolStripMenuItem});
            this.q1ToolStripMenuItem.Name = "q1ToolStripMenuItem";
            this.q1ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.q1ToolStripMenuItem.Text = "q1";
            this.q1ToolStripMenuItem.Click += new System.EventHandler(this.q1ToolStripMenuItem_Click);
            // 
            // selectAllCustumersToolStripMenuItem
            // 
            this.selectAllCustumersToolStripMenuItem.Name = "selectAllCustumersToolStripMenuItem";
            this.selectAllCustumersToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.selectAllCustumersToolStripMenuItem.Text = "select all custumers";
            // 
            // q2ToolStripMenuItem
            // 
            this.q2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem});
            this.q2ToolStripMenuItem.Name = "q2ToolStripMenuItem";
            this.q2ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.q2ToolStripMenuItem.Text = "q2";
            this.q2ToolStripMenuItem.Click += new System.EventHandler(this.q2ToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addCustomerToolStripMenuItem.Text = "add customer";
            // 
            // q3ToolStripMenuItem
            // 
            this.q3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomerToolStripMenuItem});
            this.q3ToolStripMenuItem.Name = "q3ToolStripMenuItem";
            this.q3ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.q3ToolStripMenuItem.Text = "q3";
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.updateCustomerToolStripMenuItem.Text = "update customer";
            // 
            // q4ToolStripMenuItem
            // 
            this.q4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCustomerToolStripMenuItem});
            this.q4ToolStripMenuItem.Name = "q4ToolStripMenuItem";
            this.q4ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.q4ToolStripMenuItem.Text = "q4";
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.deleteCustomerToolStripMenuItem.Text = "delete customer";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // excersizesToolStripMenuItem
            // 
            this.excersizesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex1ToolStripMenuItem,
            this.ex2ToolStripMenuItem,
            this.ex3ToolStripMenuItem,
            this.ex4ToolStripMenuItem});
            this.excersizesToolStripMenuItem.Name = "excersizesToolStripMenuItem";
            this.excersizesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.excersizesToolStripMenuItem.Text = "excersizes";
            // 
            // ex1ToolStripMenuItem
            // 
            this.ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            this.ex1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex1ToolStripMenuItem.Text = "ex1";
            this.ex1ToolStripMenuItem.Click += new System.EventHandler(this.ex1ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 353);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewer
            // 
            this.dataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewer.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewer.Name = "dataGridViewer";
            this.dataGridViewer.Size = new System.Drawing.Size(445, 321);
            this.dataGridViewer.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ex2ToolStripMenuItem
            // 
            this.ex2ToolStripMenuItem.Name = "ex2ToolStripMenuItem";
            this.ex2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex2ToolStripMenuItem.Text = "ex2";
            this.ex2ToolStripMenuItem.Click += new System.EventHandler(this.ex2ToolStripMenuItem_Click);
            // 
            // ex3ToolStripMenuItem
            // 
            this.ex3ToolStripMenuItem.Name = "ex3ToolStripMenuItem";
            this.ex3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex3ToolStripMenuItem.Text = "ex3";
            this.ex3ToolStripMenuItem.Click += new System.EventHandler(this.ex3ToolStripMenuItem_Click);
            // 
            // ex4ToolStripMenuItem
            // 
            this.ex4ToolStripMenuItem.Name = "ex4ToolStripMenuItem";
            this.ex4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ex4ToolStripMenuItem.Text = "ex4";
            this.ex4ToolStripMenuItem.Click += new System.EventHandler(this.ex4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 377);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q1ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem selectAllCustumersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem q4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excersizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex4ToolStripMenuItem;
    }
}

