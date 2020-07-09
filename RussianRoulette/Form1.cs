using RussianRoulette.Properties;
using System;
using System.Media;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        LogicClass Logic = new LogicClass();

        public object LoadGun { get; private set; }
        public object LoadImg { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // disable spin, playagain, textbox, shoot button and enable load button only at MainForm Load
            Spin.Enabled = false;
           ShootHead.Enabled = false;
            ShootAway.Enabled = false;
           

        }

        private void Load_Click(object sender, EventArgs e)
        {
            
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.Load);
            sp.Play();//sound effect to the load button and its source is mentioned
            Load.Enabled = false;
            ShootAway.Enabled = false;
            ShootHead.Enabled = false;
            PlayAgain.Enabled = false;
            Spin.Enabled = true;// it is to disable the spin button unless the gun is loaded
            Logic.Load();//calling the load function to act here
           
        }

        private void ShootHead_Click(object sender, EventArgs e)
        {

            Spin.Enabled = false;
            Load.Enabled = false;
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.GunShoot);
            sp.Play();
            Logic.ShootAtHead();//calling the shootaway logic to act
            
            
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            Load.Enabled = false;// load button is disablesd after the player has once loaded the bullet
            Spin.Enabled = false;
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.Spin);
            sp.Play();
            ShootHead.Enabled = true;// fire is disabled until the chamber is spinned
            ShootAway.Enabled = true;//shootaway is disabled until the chamber is spinned
            Logic.Spin();//calling the spin function to act
        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            Spin.Enabled = false;
            Load.Enabled = false;

            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.GunShoot);
            sp.Play();
            Logic.ShootAway();//calling the shootaway logic to act
            
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Load.Enabled = true;
            Spin.Enabled = false;
            ShootAway.Enabled = false;
            ShootHead.Enabled = false;
           
           
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
