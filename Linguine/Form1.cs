using System.IO;
namespace Linguine


{

    public partial class Form1 : Form
    {
        private string currentFilePath = null;
        private float currentFontSize = 11f; // initial
        private const float minFontSize = 6f;
        private const float maxFontSize = 72f;
        public Form1()
        {
            InitializeComponent();
            linguineEditor.MouseWheel += LinguineEditor_MouseWheel;
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomMenuColorTable());
        }
        private void LinguineEditor_MouseWheel(object sender, MouseEventArgs e)
        {
            // Only zoom if Ctrl is held
            if ((ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (e.Delta > 0 && currentFontSize < maxFontSize)
                {
                    currentFontSize += 2;
                }
                else if (e.Delta < 0 && currentFontSize > minFontSize)
                {
                    currentFontSize -= 2;
                }

                linguineEditor.Font = new Font(linguineEditor.Font.FontFamily, currentFontSize);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (*.txt)|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                linguineEditor.Text = File.ReadAllText(dialog.FileName);
                currentFilePath = dialog.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilePath != null)
            {
                // Save imm to file path
                File.WriteAllText(currentFilePath, linguineEditor.Text);
            }
            else
            {
                // fallback to Save As
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files (*.txt)|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, linguineEditor.Text);
                currentFilePath = dialog.FileName;
            }
        }

        private void linguineEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFontSize < maxFontSize)
            {
                currentFontSize += 2; // increase by 2 pt
                linguineEditor.Font = new Font(linguineEditor.Font.FontFamily, currentFontSize);
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFontSize > minFontSize)
            {
                currentFontSize -= 2; // decrease by 2 pt
                linguineEditor.Font = new Font(linguineEditor.Font.FontFamily, currentFontSize);
            }
        }

        // Theme functions for linguineEditor
        private void SetTheme(Color bg, Color fg, Color mbg, Color mfg)
        {
            linguineEditor.BackColor = bg;
            linguineEditor.ForeColor = fg;
            menuStrip1.BackColor = mbg;
            menuStrip1.ForeColor = mfg;
            linguineEditor.Font = new Font(linguineEditor.Font.FontFamily, currentFontSize);
        }
        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(Color.White, Color.Black, Color.FromArgb(233, 233, 233), Color.Black);
        }

        private void paperThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(Color.FromArgb(232, 213, 188), Color.FromArgb(94, 78, 70),
                Color.FromArgb(227, 205, 178), Color.FromArgb(94, 78, 70));
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(Color.FromArgb(33, 33, 33), Color.FromArgb(214, 214, 214),
                Color.FromArgb(33, 33, 33), Color.FromArgb(214, 214, 214));
        }

        private void blackThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(Color.Black, Color.LightGray,
                Color.FromArgb(16, 16, 16), Color.LightGray);
        }
    }

    public class CustomMenuColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(136, 136, 136); } // hover background
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(136, 136, 136); }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(136, 136, 136); }
        }
    }
}
