namespace W3Schools
{
    // PUBLISHER
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            showProductsToolStripMenuItem = new ToolStripMenuItem();
            showCustomersToolStripMenuItem = new ToolStripMenuItem();
            showEmployeesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            gitToolStripMenuItem = new ToolStripMenuItem();
            cloneRepositoryToolStripMenuItem = new ToolStripMenuItem();
            stageChangesToolStripMenuItem = new ToolStripMenuItem();
            commiitChangesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, gitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(877, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showProductsToolStripMenuItem, showCustomersToolStripMenuItem, showEmployeesToolStripMenuItem, toolStripMenuItem1, loginToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // showProductsToolStripMenuItem
            // 
            showProductsToolStripMenuItem.Name = "showProductsToolStripMenuItem";
            showProductsToolStripMenuItem.Size = new Size(224, 26);
            showProductsToolStripMenuItem.Text = "Show Products";
            showProductsToolStripMenuItem.Click += showProductsToolStripMenuItem_Click;
            // 
            // showCustomersToolStripMenuItem
            // 
            showCustomersToolStripMenuItem.Name = "showCustomersToolStripMenuItem";
            showCustomersToolStripMenuItem.Size = new Size(224, 26);
            showCustomersToolStripMenuItem.Text = "Show Customers";
            showCustomersToolStripMenuItem.Click += showCustomersToolStripMenuItem_Click;
            // 
            // showEmployeesToolStripMenuItem
            // 
            showEmployeesToolStripMenuItem.Name = "showEmployeesToolStripMenuItem";
            showEmployeesToolStripMenuItem.Size = new Size(224, 26);
            showEmployeesToolStripMenuItem.Text = "Show Employees";
            showEmployeesToolStripMenuItem.Click += showEmployeesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(224, 26);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // gitToolStripMenuItem
            // 
            gitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cloneRepositoryToolStripMenuItem, stageChangesToolStripMenuItem, commiitChangesToolStripMenuItem });
            gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            gitToolStripMenuItem.Size = new Size(41, 24);
            gitToolStripMenuItem.Text = "git";
            // 
            // cloneRepositoryToolStripMenuItem
            // 
            cloneRepositoryToolStripMenuItem.Name = "cloneRepositoryToolStripMenuItem";
            cloneRepositoryToolStripMenuItem.Size = new Size(205, 26);
            cloneRepositoryToolStripMenuItem.Text = "Clone repository";
            // 
            // stageChangesToolStripMenuItem
            // 
            stageChangesToolStripMenuItem.Name = "stageChangesToolStripMenuItem";
            stageChangesToolStripMenuItem.Size = new Size(205, 26);
            stageChangesToolStripMenuItem.Text = "Stage changes";
            // 
            // commiitChangesToolStripMenuItem
            // 
            commiitChangesToolStripMenuItem.Name = "commiitChangesToolStripMenuItem";
            commiitChangesToolStripMenuItem.Size = new Size(205, 26);
            commiitChangesToolStripMenuItem.Text = "Commit Changes";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 451);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ToolStripMenuItem cloneRepositoryToolStripMenuItem;
        private ToolStripMenuItem stageChangesToolStripMenuItem;
        private ToolStripMenuItem commiitChangesToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem showProductsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem showEmployeesToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem showCustomersToolStripMenuItem;
    }
}