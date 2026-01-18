namespace Linguine
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
            linguineEditor = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            lightThemeToolStripMenuItem = new ToolStripMenuItem();
            paperThemeToolStripMenuItem = new ToolStripMenuItem();
            darkThemeToolStripMenuItem = new ToolStripMenuItem();
            blackThemeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // linguineEditor
            // 
            linguineEditor.Dock = DockStyle.Fill;
            linguineEditor.Location = new Point(0, 41);
            linguineEditor.Multiline = true;
            linguineEditor.Name = "linguineEditor";
            linguineEditor.ScrollBars = ScrollBars.Both;
            linguineEditor.Size = new Size(706, 365);
            linguineEditor.TabIndex = 0;
            linguineEditor.TextChanged += linguineEditor_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(706, 41);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveAsToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(85, 37);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(403, 48);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(403, 48);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(403, 48);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, themeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(103, 37);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(403, 48);
            zoomInToolStripMenuItem.Text = "Zoom in";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(403, 48);
            zoomOutToolStripMenuItem.Text = "Zoom out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightThemeToolStripMenuItem, paperThemeToolStripMenuItem, darkThemeToolStripMenuItem, blackThemeToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(403, 48);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // lightThemeToolStripMenuItem
            // 
            lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            lightThemeToolStripMenuItem.Size = new Size(336, 48);
            lightThemeToolStripMenuItem.Text = "Light theme";
            lightThemeToolStripMenuItem.Click += lightThemeToolStripMenuItem_Click;
            // 
            // paperThemeToolStripMenuItem
            // 
            paperThemeToolStripMenuItem.Name = "paperThemeToolStripMenuItem";
            paperThemeToolStripMenuItem.Size = new Size(336, 48);
            paperThemeToolStripMenuItem.Text = "Paper theme";
            paperThemeToolStripMenuItem.Click += paperThemeToolStripMenuItem_Click;
            // 
            // darkThemeToolStripMenuItem
            // 
            darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            darkThemeToolStripMenuItem.Size = new Size(336, 48);
            darkThemeToolStripMenuItem.Text = "Dark theme";
            darkThemeToolStripMenuItem.Click += darkThemeToolStripMenuItem_Click;
            // 
            // blackThemeToolStripMenuItem
            // 
            blackThemeToolStripMenuItem.Name = "blackThemeToolStripMenuItem";
            blackThemeToolStripMenuItem.Size = new Size(336, 48);
            blackThemeToolStripMenuItem.Text = "Black theme";
            blackThemeToolStripMenuItem.Click += blackThemeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 406);
            Controls.Add(linguineEditor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Linguine";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox linguineEditor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem lightThemeToolStripMenuItem;
        private ToolStripMenuItem paperThemeToolStripMenuItem;
        private ToolStripMenuItem darkThemeToolStripMenuItem;
        private ToolStripMenuItem blackThemeToolStripMenuItem;
    }
}
