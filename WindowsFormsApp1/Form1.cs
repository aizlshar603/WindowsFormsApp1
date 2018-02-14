using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class springfield : Form
    {
        public springfield()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //play sound 
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert__1_);
            player.Play();

            //change label colours
            state1label.BackColor = Color.DarkRed;
            state2label.BackColor = Color.DarkRed;
            Refresh();

            //change output message and flash dfhhuu
            outputLabel.Text = "Meltdown";

            outputLabel.BackColor = Color.DarkRed;
            outputLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            outputLabel.BackColor = Color.White;
            outputLabel.BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(1000);
            outputLabel.BackColor = Color.DarkRed;
            outputLabel.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            outputLabel.BackColor = Color.White;
            outputLabel.BackColor = Color.DarkRed;
            Refresh();
            Thread.Sleep(1000);


        }
    }
}
