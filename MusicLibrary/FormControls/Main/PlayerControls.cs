using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary_BLL.Services;

namespace MusicLibrary
{
    public partial class Main
    {
        private void rdRepeat_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                mp.Repeat = (MusicPlayer.RepeatMode)radio.Tag;
                Console.WriteLine($"Repeat: {mp.Repeat}");
            }
        }

        private void ResetNowPlaying()
        {
            if(mp.waveOut != null)
            {
                mp.Stop();
                mp.waveOut = null;
                mp.FileReader = null;
                // Disable button because waveOut is now null
                btnStop.Enabled = false;
                btnPlay.Enabled = false;

                // Reset seekbar
                trbSeeker.Value = 0;
                lblSeekMin.Text = "0:00";
                lblSeekMax.Text = "0:00";

                // Reset details' textboxes
                foreach (Control control in grpDetails.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Text = string.Empty;
                    }
                }
            }
        }
    }
}
