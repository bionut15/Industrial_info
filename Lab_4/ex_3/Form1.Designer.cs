namespace ex_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            displayForm1ToolStripMenuItem = new ToolStripMenuItem();
            dsiplayForm2ToolStripMenuItem = new ToolStripMenuItem();
            lldToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { displayForm1ToolStripMenuItem, dsiplayForm2ToolStripMenuItem, lldToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // displayForm1ToolStripMenuItem
            // 
            displayForm1ToolStripMenuItem.Name = "displayForm1ToolStripMenuItem";
            displayForm1ToolStripMenuItem.Size = new Size(155, 22);
            displayForm1ToolStripMenuItem.Text = "Display Form 1";
            displayForm1ToolStripMenuItem.Click += displayForm1ToolStripMenuItem_Click;
            // 
            // dsiplayForm2ToolStripMenuItem
            // 
            dsiplayForm2ToolStripMenuItem.Name = "dsiplayForm2ToolStripMenuItem";
            dsiplayForm2ToolStripMenuItem.Size = new Size(155, 22);
            dsiplayForm2ToolStripMenuItem.Text = "Dsiplay Form 2 ";
            dsiplayForm2ToolStripMenuItem.Click += dsiplayForm2ToolStripMenuItem_Click;
            // 
            // lldToolStripMenuItem
            // 
            lldToolStripMenuItem.Name = "lldToolStripMenuItem";
            lldToolStripMenuItem.Size = new Size(155, 22);
            lldToolStripMenuItem.Click += lldToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem displayForm1ToolStripMenuItem;
        private ToolStripMenuItem dsiplayForm2ToolStripMenuItem;
        private ToolStripMenuItem lldToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
