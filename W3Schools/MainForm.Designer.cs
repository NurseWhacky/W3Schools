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
            ClickMe = new Button();
            SuspendLayout();
            // 
            // ClickMe
            // 
            ClickMe.BackColor = SystemColors.HotTrack;
            ClickMe.BackgroundImageLayout = ImageLayout.Stretch;
            ClickMe.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClickMe.ForeColor = Color.Gold;
            ClickMe.Location = new Point(349, 149);
            ClickMe.Name = "ClickMe";
            ClickMe.Size = new Size(217, 101);
            ClickMe.TabIndex = 0;
            ClickMe.Text = "Click Me!";
            ClickMe.UseVisualStyleBackColor = false;
            ClickMe.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 451);
            Controls.Add(ClickMe);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ClickMe;
    }
}