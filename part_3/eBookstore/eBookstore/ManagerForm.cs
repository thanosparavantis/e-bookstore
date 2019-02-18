using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBookstore
{
    public partial class ManagerForm : Form
    {
        private bool[] lightStates = { false,  false, false, false, false };

        private System.Media.SoundPlayer player;
        private bool musicPlayerState = false;
        private int musicTrack = 1;

        private int climaTemprature = 18;
        private bool climaState = false;

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer();
            player.SoundLocation = "./study_music_" + musicTrack +".wav";
            nextButton.Enabled = previousButton.Enabled = false;

            if (!climaState)
            {
                climaIncreaseButton.Enabled = false;
                climaDecreaseButton.Enabled = false;
            }
        }

        private void light1OnButton_Click(object sender, EventArgs e)
        {
            lightStates[0] = !lightStates[0];
            light1Button.Text = lightStates[0] ? "On" : "Off";
            light1Indicator.Image = lightStates[0] ? eBookstore.Properties.Resources.pin_green : eBookstore.Properties.Resources.pin_red;
        }

        private void light2Button_Click(object sender, EventArgs e)
        {
            lightStates[1] = !lightStates[1];
            light2Button.Text = lightStates[1] ? "On" : "Off";
            light2Indicator.Image = lightStates[1] ? eBookstore.Properties.Resources.pin_green : eBookstore.Properties.Resources.pin_red;
        }

        private void light3Button_Click(object sender, EventArgs e)
        {
            lightStates[2] = !lightStates[2];
            light3Button.Text = lightStates[2] ? "On" : "Off";
            light3Indicator.Image = lightStates[2] ? eBookstore.Properties.Resources.pin_green : eBookstore.Properties.Resources.pin_red;
        }

        private void light4Button_Click(object sender, EventArgs e)
        {
            lightStates[3] = !lightStates[3];
            light4Button.Text = lightStates[3] ? "On" : "Off";
            light4Indicator.Image = lightStates[3] ? eBookstore.Properties.Resources.pin_green : eBookstore.Properties.Resources.pin_red;
        }

        private void light5Button_Click(object sender, EventArgs e)
        {
            lightStates[4] = !lightStates[4];
            light5Button.Text = lightStates[4] ? "On" : "Off";
            light5Indicator.Image = lightStates[4] ? eBookstore.Properties.Resources.pin_green : eBookstore.Properties.Resources.pin_red;
        }

        private void climaIncreaseButton_Click(object sender, EventArgs e)
        {
            if (climaTemprature < 28)
            {
                climaTemprature++;
                tempratureLabel.Text = climaTemprature.ToString();
            }
        }

        private void climaDecreaseButton_Click(object sender, EventArgs e)
        {
            if (climaTemprature > 18)
            {
                climaTemprature--;
                tempratureLabel.Text = climaTemprature.ToString();
            }
        }

        private void climaButton_Click(object sender, EventArgs e)
        {
            climaState = !climaState;
            tempratureLabel.Text = climaState ? climaTemprature.ToString() : "00";
            climaIncreaseButton.Enabled = climaState ? true : false;
            climaDecreaseButton.Enabled = climaState ? true : false;
            climaButton.Text = climaState ? "On" : "Off";
        }

        private void light1Button_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click the button to turn on/off the light 1.";
        }

        private void light1Button_MouseLeave(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "";
        }

        private void light2Button_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click the button to turn on/off the light 2.";
        }

        private void light3Button_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click the button to turn on/off the light 3.";
        }

        private void light4Button_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click the button to turn on/off the light 4.";
        }

        private void light5Button_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click the button to turn on/off the light 5.";
        }

        private void climaButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click the button to turn on/off the air condition.";
        }

        private void climaIncreaseButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click the button to increase temprature.";
        }

        private void climaDecreaseButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click the button to decrease temprature.";
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ManagerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Control)
                this.Hide();

            if ((e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) && e.Control)
                light1Button.PerformClick();

            if ((e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) && e.Control)
                light2Button.PerformClick();

            if ((e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) && e.Control)
                light3Button.PerformClick();

            if ((e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) && e.Control)
                light4Button.PerformClick();

            if ((e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) && e.Control)
                light5Button.PerformClick();

            if (e.KeyCode == Keys.O && e.Control)
                climaButton.PerformClick();

            if (e.KeyCode == Keys.Add && e.Control)
                climaIncreaseButton.PerformClick();

            if (e.KeyCode == Keys.Subtract && e.Control)
                climaDecreaseButton.PerformClick();

            if (e.KeyCode == Keys.P && e.Control)
                playStopButton.PerformClick();

            if (e.KeyCode == Keys.OemPeriod && e.Control)
                nextButton.PerformClick();

            if (e.KeyCode == Keys.Oemcomma && e.Control)
                previousButton.PerformClick();

            // if (e.KeyCode == Keys.H && e.Control)
            // Open help
        }

        private void playStopButton_Click(object sender, EventArgs e)
        {
            if (!musicPlayerState)
            {
                player.PlayLooping();
                songTitlteLabel.Text = "study_music_" + musicTrack;
                playStopButton.Text = "Stop";
                songTitlteLabel.Text = "study_music_" + musicTrack;
                nextButton.Enabled = previousButton.Enabled = true;
                playStopButton.ForeColor = Color.DarkRed;
            }
            else
            {
                player.Stop();
                songTitlteLabel.Text = "study_music_" + musicTrack;
                playStopButton.Text = "Play";
                songTitlteLabel.Text = "---";
                nextButton.Enabled = previousButton.Enabled = false;
                playStopButton.ForeColor = Color.LimeGreen;
            }

            musicPlayerState = !musicPlayerState;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            musicTrack = (musicTrack == 3) ? 1 : ++musicTrack;
            player.Stop();
            player.SoundLocation = "./study_music_" + musicTrack + ".wav";
            songTitlteLabel.Text = "study_music_" + musicTrack;
            player.PlayLooping();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            musicTrack = (musicTrack == 1) ? 3 : --musicTrack;
            player.Stop();
            player.SoundLocation = "./study_music_" + musicTrack + ".wav";
            songTitlteLabel.Text = "study_music_" + musicTrack;
            player.PlayLooping();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manager \np16036 - Ioannidis Panagiotis \np16112 - Paravantis Athanasios", "About");
        }

        private void playStopButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Play / Stop music player.";
        }

        private void previousButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Previous music track.";
        }

        private void nextButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Next music track.";
        }
    }
}
