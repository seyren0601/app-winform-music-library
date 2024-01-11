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
    }
}
