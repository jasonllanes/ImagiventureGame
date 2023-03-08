using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagiventure
{

    

    public partial class T_1_1 : Form
    {
        String t1_answer_key = "BOOK";
        int chances = 10;
        int random_num;
        String[] attacks = {"Rock","Paper","Scissor"};
        public T_1_1()
        {
            InitializeComponent();
        }

        private void T_1_1_Load(object sender, EventArgs e)
        {
            lbl_t3_answer.Hide();
            lbl_t3_answer2.Hide();
            btn_t3_next.Hide();

            lblChances.Text = chances.ToString();
            random_num = RandomNumberGenerator();
            Debug.WriteLine("The random number is " + random_num);
            Console.WriteLine("The random number is " + random_num);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(t1_answer.Text.ToUpper().Equals(t1_answer_key))
            {
                trial_board.SelectedTab = trial_2;
            }
            else
            {
                MessageBox.Show("Wrong! Try some other answer young hero...");
                DeductChances();
            }
             
        }

     
        private void btn_sub_Click(object sender, EventArgs e)
        {
            if(int.Parse(t2_answer.Text) == 0)
            {
                lbl_comment.Text = "I said numbers 1-10 only";
            }
            else
            {
                CheckNumber(int.Parse(t2_answer.Text));
            }
            
        }

        public int RandomNumberGenerator()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 10);
            return randomNumber;
        }
        public void CheckNumber(int answer)
        {
                   
            if (answer == random_num)
            {
                lbl_comment.Text = "Marvelous!";
                trial_board.SelectedTab = trial_3;
            }
            else if (answer > random_num)
            {
                lbl_comment.Text = "Make it lower...";
                DeductChances();
            }
            else if (answer < random_num)
            {
                lbl_comment.Text = "Higher hero Higher!";
                DeductChances();
            }
            else if (answer > 10)
            {
                lbl_comment.Text = "I said numbers 1-10 only";
                DeductChances();
            }
            else
            {
                DeductChances();
            }
        }
        public void DeductChances()
        {
            chances--;
            lblChances.Text = chances.ToString();

            
        }
        public void GameOver()
        {
            if(chances == 0)
            {
                MessageBox.Show("Game Over! You are not a true hero!");
            }
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            lbl_t3_answer.Show();
            lbl_t3_answer2.Show();
            btn_t3_next.Show();
        }

        private void btn_attack_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 3);
            String dragon_choice = attacks[randomNumber];
            if (cb_attacks.Text == "Rock")
            {
                if (dragon_choice == "Rock")
                {
                    Console.WriteLine("Tie!");
                }
                else if (dragon_choice == "Paper")
                {
                    Console.WriteLine("Computer wins!");
                }
                else if (dragon_choice == "Scissor")
                {
                    Console.WriteLine("You win!");
                }
            }
            else if (cb_attacks.Text == "Paper")
            {
                if (dragon_choice == "Rock")
                {
                    Console.WriteLine("You win!");
                }
                else if (dragon_choice == "Paper")
                {
                    Console.WriteLine("Tie!");
                }
                else if (dragon_choice == "Scissor")
                {
                    Console.WriteLine("Computer wins!");
                }
            }
            else if (cb_attacks.Text == "Scissor")
            {
                if (dragon_choice == "Rock")
                {
                    Console.WriteLine("Computer wins!");
                }
                else if (dragon_choice == "Paper")
                {
                    Console.WriteLine("You win!");
                }
                else if (dragon_choice == "Scissor")
                {
                    Console.WriteLine("Tie!");
                }
            }
        }
    }
}
