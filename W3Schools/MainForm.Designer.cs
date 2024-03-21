namespace W3Schools
{
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
            liubioiokToolStripMenuItem = new ToolStripMenuItem();
            pobaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sucaToolStripMenuItem = new ToolStripMenuItem();
            setziToolStripMenuItem = new ToolStripMenuItem();
            craccaToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            gitToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            nuovoToolStripMenuItem = new ToolStripMenuItem();
            salvaToolStripMenuItem = new ToolStripMenuItem();
            salvaComeToolStripMenuItem = new ToolStripMenuItem();
            chiudiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, gitToolStripMenuItem, liubioiokToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(877, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // liubioiokToolStripMenuItem
            // 
            liubioiokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pobaToolStripMenuItem, toolStripSeparator1, sucaToolStripMenuItem, setziToolStripMenuItem, craccaToolStripMenuItem });
            liubioiokToolStripMenuItem.Name = "liubioiokToolStripMenuItem";
            liubioiokToolStripMenuItem.Size = new Size(91, 24);
            liubioiokToolStripMenuItem.Text = "interagisci";
            // 
            // pobaToolStripMenuItem
            // 
            pobaToolStripMenuItem.Enabled = false;
            pobaToolStripMenuItem.Name = "pobaToolStripMenuItem";
            pobaToolStripMenuItem.Size = new Size(224, 26);
            pobaToolStripMenuItem.Text = "poba";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // sucaToolStripMenuItem
            // 
            sucaToolStripMenuItem.Name = "sucaToolStripMenuItem";
            sucaToolStripMenuItem.Size = new Size(224, 26);
            sucaToolStripMenuItem.Text = "suca";
            // 
            // setziToolStripMenuItem
            // 
            setziToolStripMenuItem.Name = "setziToolStripMenuItem";
            setziToolStripMenuItem.Size = new Size(224, 26);
            setziToolStripMenuItem.Text = "setzi";
            // 
            // craccaToolStripMenuItem
            // 
            craccaToolStripMenuItem.Name = "craccaToolStripMenuItem";
            craccaToolStripMenuItem.Size = new Size(224, 26);
            craccaToolStripMenuItem.Text = "cracca";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(53, 24);
            viewToolStripMenuItem.Text = "view";
            // 
            // gitToolStripMenuItem
            // 
            gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            gitToolStripMenuItem.Size = new Size(41, 24);
            gitToolStripMenuItem.Text = "git";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuovoToolStripMenuItem, salvaToolStripMenuItem, salvaComeToolStripMenuItem, chiudiToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // nuovoToolStripMenuItem
            // 
            nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            nuovoToolStripMenuItem.Size = new Size(224, 26);
            nuovoToolStripMenuItem.Text = "Nuovo";
            // 
            // salvaToolStripMenuItem
            // 
            salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            salvaToolStripMenuItem.Size = new Size(224, 26);
            salvaToolStripMenuItem.Text = "Salva";
            // 
            // salvaComeToolStripMenuItem
            // 
            salvaComeToolStripMenuItem.Name = "salvaComeToolStripMenuItem";
            salvaComeToolStripMenuItem.Size = new Size(224, 26);
            salvaComeToolStripMenuItem.Text = "Salva come...";
            // 
            // chiudiToolStripMenuItem
            // 
            chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            chiudiToolStripMenuItem.Size = new Size(224, 26);
            chiudiToolStripMenuItem.Text = "Chiudi";
            chiudiToolStripMenuItem.Click += chiudiToolStripMenuItem_Click;
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem liubioiokToolStripMenuItem;
        private ToolStripMenuItem pobaToolStripMenuItem;
        private ToolStripMenuItem sucaToolStripMenuItem;
        private ToolStripMenuItem setziToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem craccaToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem nuovoToolStripMenuItem;
        private ToolStripMenuItem salvaToolStripMenuItem;
        private ToolStripMenuItem salvaComeToolStripMenuItem;
        private ToolStripMenuItem chiudiToolStripMenuItem;
    }
}