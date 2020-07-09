using System;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace RussianRoulette
{
     public class LogicClass
    {
        //this is the bullet
        int Bullet;
        int points = 0;




        // this function loads the gun
        public void Load()
        {
            Bullet = 6;
        }

        // this function spin the bullets
        public int Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7); //setting a range
            return Bullet;
        }

        int ShootingChances = 4; // chances to shoot on head
        int ShootingAwayChances = 2; //chances to shoot away

        // this function shooting away

        public int ShootAtHead()
        {
            {
                if (Bullet == 1 && ShootingChances == 2)
                {
                    //tell the user you died!
                    points = 10;
                    MessageBox.Show("You survive! You got " + points + " points");
                    Application.Restart();

                }
                else if (Bullet == 1 && ShootingChances == 1)
                {
                    MessageBox.Show("You survive! You got " + points + " points");
                    points = 5;
                }
                else
                {
                    ShootingChances--;
                    Bullet--;
                    //if chances are zero tell him you are dead else tell him keep playing
                    if (ShootingChances == 0)
                    {
                        MessageBox.Show("You have lost all chances of survival, you scored " + points + " points do you want to play again?", "Game Over");
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("All the best!! Last chance to try your luck");
                    }
                }

                return ShootingChances;
            }
        }
            // this function shoot at head

            public int ShootAway()
        {
            if (Bullet == 1)
            {

                // the user is dead!
                MessageBox.Show("You are dead and you scored zero points! do you want to play again?", "Game Over!");
                Application.Restart();
            }
            else
            {
                ShootingAwayChances--;
                Bullet--;
                //if chances of shooting at your head is zero, tell him you survived unless tell him keep playing
                if (ShootingAwayChances == 0 && ShootingChances == 2)
                {
                    points = 10;
                    MessageBox.Show("You win!!! Congrats! You got " + points + " points! Do you want to play again?", "Game Over!");
                    Application.Restart();
                }
                else if (ShootingAwayChances == 0 && ShootingChances == 1)
                {
                    points = 5;
                    MessageBox.Show("You win!!! Congrats! You got " + points + " points! Do you want to play again?", "Game Over!");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Try your luck.. Fingers crossed");
                }
            }
            return ShootingAwayChances;
        }
            

            }
        } 
     



        









