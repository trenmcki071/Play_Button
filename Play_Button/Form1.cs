using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;



namespace Play_Button
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void timerWords_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.Click);
            player3.PlaySync();
            Thread.Sleep(100);
            timerWords.ForeColor = Color.White;
            timerNumber.ForeColor = Color.White;
            buttonStart.Visible = false;

            Refresh();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Ping);
            player.Play();
            Thread.Sleep(1000);

            timerNumber.Text = "2";

            Refresh();
            player.Play();
            Thread.Sleep(1000);

            timerNumber.Text = "1";

            Refresh();
            player.Play();
            Thread.Sleep(1000);

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.Start);
            background.BackColor = Color.Green;
            player2.Play();
            timerNumber.Visible = false;
            timerWords.Visible = false;
            GO.Visible = true;
        }
    }
}
