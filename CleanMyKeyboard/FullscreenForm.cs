using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanMyKeyboard
{
    public partial class FullscreenForm : Form
    {
        private Size centerPanelSize = new Size(550, 220);
        private int exitIndex = 0;
        private const string exitStr = "EXIT";
        private Label[] exitLabels;
        private bool allowExit = false;

        public FullscreenForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FullscreenForm_Load(object sender, EventArgs e)
        {
            PlaceCenterPanel();
            exitLabels = new Label[] {eLabel, xLabel, iLabel, tLabel};
        }

        private void FullscreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !allowExit;
        }

        private void PlaceCenterPanel()
        {
            centerPanel.Size = centerPanelSize;
            centerPanel.Location = new Point(
                    (this.Size.Width - centerPanel.Size.Width) / 2,
                    (this.Size.Height - centerPanel.Size.Height) / 2
                );
        }

        private void FullscreenForm_ResizeEnd(object sender, EventArgs e)
        {
            PlaceCenterPanel();
        }

        private void FullscreenForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (exitIndex >= exitStr.Length)
            {
                ExitAfterMillis(0);
                return;
            }

            char ch = Char.ToUpper(e.KeyChar);
            if (exitStr[exitIndex] == ch)
            {
                exitIndex++;
                RefreshExitLabels();
                if (exitIndex >= exitStr.Length)
                {
                    new Thread(() => ExitAfterMillis(100)).Start();
                }
            }
            else
            {
                exitIndex = 0;
                RefreshExitLabels();
            }
        }

        private void ExitAfterMillis(int millis)
        {
            allowExit = true;
            Thread.Sleep(millis);
            Application.Exit();
        }

        private void RefreshExitLabels()
        {
            for (int i = 0; i < exitLabels.Length; i++)
            {
                exitLabels[i].ForeColor = i < exitIndex ? Color.White : Color.Black;
            }
        }
    }
}
