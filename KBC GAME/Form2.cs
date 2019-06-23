using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KBC_GAME
{
    public partial class KBC : Form
    {
         Form3 F3 = new Form3();
        public KBC()
        {
            InitializeComponent();

            Form3 F3 = new Form3();
        }

        private void Form2_Load(object sender, EventArgs e)

           
        {
            
            Question_box.Text = "WHO WAS THE FOUNDER OF PAKISTAN?";
            OPT_1.Text = "QUAID -E- AZAM";
            OPT_2.Text="ALLAMA IQBAL";
            OPT_3.Text="LIAQUAT ALI KHAN";
            OPT_4.Text="ZUBAIR";
            Question_box.Enabled = false;
                
        }

        private void OPT_1_Click(object sender, EventArgs e)
        {
            if (Question_box.Text == "WHO WAS THE FOUNDER OF PAKISTAN?")
            {

                Question_box.Text = "WHEN DID SOVIENT UNION BREAK DOWN ?";
                OPT_1.Text = "A ) 1969";
                OPT_2.Text = "B) 1979";
                OPT_3.Text = "C) 1989";
                OPT_4.Text = "D) 1999";
                label1.Text="1) 1,000";
                label15.BackColor = System.Drawing.Color.Black;
                label1.BackColor = System.Drawing.Color.Indigo;

                F3.label1.Text = "YOU HAVE WON Rs. 1,000";
                label17.Text = F3.label1.Text;
                
                F3.label1.Refresh();
                
                
        

            }
            else if (Question_box.Text == "WHICH IS THE COMMON EUROPIAN CURRENCY ?")
            {
                label4.BackColor=System.Drawing.Color.Black;
                label5.Text = "5) 10,000";
                label5.BackColor = System.Drawing.Color.Indigo;
                
                
                Question_box.Text = "WHAT IS THE SYMBOL OF VICTORY ?";
                OPT_1.Text = "A ) DOWNWARD THUMB";
                OPT_2.Text = "B) DOVE WITH OLIVE BRANCHES";
                OPT_3.Text = "C) HORES";
                OPT_4.Text = "D) TWO FINGER IN V SHAPE";
               

                F3.label1.Text = "YOU HAVE WON Rs. 10,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
               
            }
            else if (Question_box.Text == "WHO LOST HIS TEETH WHILE WRITING MAHABHARAT ?")
            {

                
                label7.Text = "7) 40,000";
                label7.BackColor = System.Drawing.Color.Indigo;
                label16.BackColor = System.Drawing.Color.Black;
                
                F3.label1.Text = "YOU WON 40,000";
                Question_box.Text = "WHO ADOPTED UNIVERSAL DECLARATION OF HUMAN RIGHTS ?";
                OPT_1.Text = "A ) AMNESTY INTERNATIONAL";
                OPT_2.Text = "B) U N";
                OPT_3.Text = "C) NATO";
                OPT_4.Text = "D) COMMON WEALTH";
               
                F3.label1.Text = "YOU HAVE WON Rs. 40,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
               

            }
            else if (Question_box.Text == "IN THE RHYME WHERE DID HUMPTY DUMPTY SIT ?")
            {
                label11.Text = "11) 6,25,000";
                label11.BackColor = System.Drawing.Color.Indigo;
                label10.BackColor = System.Drawing.Color.Black;
               
                F3.label1.Text = "YOU WON 6,25,000";
                Question_box.Text = "WHO WAS ALSO A BRITISH CITIZEN ?";
                OPT_1.Text = "A ) ADOLF HITLER";
                OPT_2.Text = "B) SARDAR PATEL";
                OPT_3.Text = "C) PANDIT NEHRU";
                OPT_4.Text = "D) BENITTO MUSSOLINI";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
               
                
                



            }
            else if (Question_box.Text == "HOW MANY OF ENGLISH MUNARCHS ARE NAMED ELIZABETH ?")
            {



                label14.Text = "14) 50,00,000";
                label14.BackColor = System.Drawing.Color.Indigo;
                label13.BackColor = System.Drawing.Color.Black;
              
                F3.label1.Text = "YOU WON 50,00,000";
                Question_box.Text = "WHICH PAKISTHANI LEADER SIGNED SIMLA AGREEMENT ?";
                OPT_1.Text = "A)ZIA HL HAQ";
                OPT_2.Text = "B) AGAB KHAN";
                OPT_3.Text = "C) ZULFIKAR ALI BHUTTO";
                OPT_4.Text = "D) YAHYA KHAN";

                F3.label1.Text = "YOU HAVE WON Rs. 50,00,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh(); 
               





            }
            else
            {
                
                this.Hide();
                Form3 F3 = new Form3();
                F3.label1.Text = label17.Text;
                F3.Show();
            }

        }

        private void OPT_2_Click(object sender, EventArgs e)
        {
            if (Question_box.Text == "WHO ADOPTED UNIVERSAL DECLARATION OF HUMAN RIGHTS ?")
            {


                label8.Text = "8) 80,000";
                label8.BackColor = System.Drawing.Color.Indigo;
                label7.BackColor = System.Drawing.Color.Black;
               
                F3.label1.Text = "YOU WON 80,000";
                Question_box.Text = "WHO PATRONISED KALIDAS ?";
                OPT_1.Text = "A) AKBAR";
                OPT_2.Text = "B) CHANDRAGUPTH";
                OPT_3.Text = "C) VIKRAMADHITHYA";
                OPT_4.Text = "D) KRISHNADEVARAYA";
                F3.label1.Text = "YOU HAVE WON Rs. 80,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
               



            }
            
            else if (Question_box.Text == "WHICH OF THESE ANIMALS LAUGHS ?")
            {


                label4.Text = "4) 5,000";
                label4.BackColor = System.Drawing.Color.Indigo;
                label3.BackColor = System.Drawing.Color.Black;
               
                F3.label1.Text = "YOU WON 5,000";
                Question_box.Text = "WHICH IS THE COMMON EUROPIAN CURRENCY ?";
                OPT_1.Text = "A ) EURO";
                OPT_2.Text = "B) YEN";
                OPT_3.Text = "C) EUROPEAN CURRENCY";
                OPT_4.Text = "D) POUND";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
               
                
            }
            else if (Question_box.Text == "HOW DO YOU SAY GOOD BYE IN JAPANESE ?")
            {

                
                label13.Text = "13) 25,00,000";
                label13.BackColor = System.Drawing.Color.Indigo;
                label12.BackColor = System.Drawing.Color.Black;

                Question_box.Text = "HOW MANY OF ENGLISH MUNARCHS ARE NAMED ELIZABETH ?";
                OPT_1.Text = "A ) 2";
                OPT_2.Text = "B) 3";
                OPT_3.Text = "C) 1";
                OPT_4.Text = "D) 4";
                
                
                F3.label1.Text = "YOU WON 25,00,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
                F3.Show();
                
                



            }
            else
            {
           
                this.Hide();
                Form3 F3 = new Form3();
                F3.Show();
                F3.label1.Text = label17.Text;
                this.Hide();
                
            }
            


        }

        private void OPT_3_Click(object sender, EventArgs e)
        {
            if (Question_box.Text == "WHEN DID SOVIENT UNION BREAK DOWN ?")
            {
                label2.Text = "2) 2,000";
                label2.BackColor = System.Drawing.Color.Indigo;
                label1.BackColor = System.Drawing.Color.Black;
                Question_box.Text = "WHICH OF THESE IS A SYMBOL OF PEACE ?";
                OPT_1.Text = "A ) LOTUS";
                OPT_2.Text = "B) TWO LEAVES";
                OPT_3.Text = "C) HAND";
                OPT_4.Text = "D) DOVE WITH OILVE BRANCH";
               
                F3.label1.Text = "YOU WON 2,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
               
               
            }
            else if (Question_box.Text == "WHO PATRONISED KALIDAS ?")
            {
                label9.Text = "9) 1,60,000";
                label9.BackColor = System.Drawing.Color.Indigo;
                label8.BackColor = System.Drawing.Color.Black;
                Question_box.Text = "WHO TOUCH TURNED ALL TO GOLD ?";
                OPT_1.Text = "A ) ARGUS";
                OPT_2.Text = "B) AURALIUS";
                OPT_3.Text = "C) AURUM";
                OPT_4.Text = "D) MIDAS";
                
                F3.label1.Text = "YOU WON 1,60,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();

            }
            else if (Question_box.Text == "WHO WAS ALSO A BRITISH CITIZEN ?")
            {
                label12.Text = "12) 12,50,000";
                label12.BackColor = System.Drawing.Color.Indigo;
                label11.BackColor = System.Drawing.Color.Black;
                Question_box.Text = "HOW DO YOU SAY GOOD BYE IN JAPANESE ?";
                OPT_1.Text = "A ) NA HONDO";
                OPT_2.Text = "C) SHO YU";
                OPT_3.Text = "B) SAYONARA";
                OPT_4.Text = "D) WAKA";
                F3.label1.Text = "YOU HAVE WON Rs. 12,50,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
                


            }


            else
            {
                
                Form3 F3 = new Form3();
                F3.Show();
                F3.label1.Text = label17.Text;
                this.Hide();
            }

        }

        private void OPT_4_Click(object sender, EventArgs e)
        {
            if (Question_box.Text == "WHICH OF THESE IS A SYMBOL OF PEACE ?")
            {
                label3.Text = "3) 3,000";
                label3.BackColor = System.Drawing.Color.Indigo;
                label2.BackColor = System.Drawing.Color.Black;
                Question_box.Text = "WHICH OF THESE ANIMALS LAUGHS ?";
                OPT_1.Text = "A ) TIGER";
                OPT_2.Text = "B) HYNA";
                OPT_3.Text = "C) RHINO";
                OPT_4.Text = "D) ZEEBRA";
                F3.label1.Text = "YOU HAVE WON Rs. 3,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
               

            }

            else if (Question_box.Text == "WHAT IS THE SYMBOL OF VICTORY ?")
            {


                label16.Text = "6) 20,000";
                label16.BackColor = System.Drawing.Color.Indigo;
                label5.BackColor = System.Drawing.Color.Black;

                Question_box.Text = "WHO LOST HIS TEETH WHILE WRITING MAHABHARAT ?";
                OPT_1.Text = "A ) GANESH";
                OPT_2.Text = "B) VEDA VYAS";
                OPT_3.Text = "C) VALMIKI";
                OPT_4.Text = "D) DUSHASAN";
                label6.Text = "6) 20,000";
                label6.BackColor = System.Drawing.Color.Indigo;
                label5.BackColor = System.Drawing.Color.Black;
                F3.label1.Text = "YOU HAVE WON Rs. 20,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();
                


            }
            else if (Question_box.Text == "WHO TOUCH TURNED ALL TO GOLD ?")
            {


                label10.Text = "10) 3,20,000";
                label10.BackColor = System.Drawing.Color.Indigo;
                label9.BackColor = System.Drawing.Color.Black;
                Question_box.Text = "IN THE RHYME WHERE DID HUMPTY DUMPTY SIT ?";
                OPT_1.Text = "A ) WALL";
                OPT_2.Text = "B) KINGS HORSE";
                OPT_3.Text = "C) TREE";
                OPT_4.Text = "D) THRONE";

                F3.label1.Text = "YOU WON 3,20,000";
                label17.Text = F3.label1.Text;
                F3.label1.Refresh();


            }
            else
            {
            
                Form3 F3 = new Form3(); 
                F3.Show();
                F3.label1.Text = label17.Text;
                this.Hide();
                
            }
        }

        
        

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.ForeColor = System.Drawing.Color.Black;
                if (Question_box.Text == "WHO WAS THE FOUNDER OF PAKISTAN")
                {


                    OPT_2.Text = "";
                    OPT_4.Text = "";
                    checkBox1.Enabled = false;




                }
                else if (Question_box.Text == "WHICH IS THE COMMON EUROPIAN CURRENCY ?")
                {


                    OPT_2.Text = "";
                    OPT_4.Text = "";
                    checkBox1.Enabled = false;



                }
                else if (Question_box.Text == "WHO LOST HIS TEETH WHILE WRITING MAHABHARAT ?")
                {


                    OPT_3.Text = "";
                    OPT_4.Text = "";
                    checkBox1.Enabled = false;


                }
                else if (Question_box.Text == "IN THE RHYME WHERE DID HUMPTY DUMPTY SIT ?")
                {


                    OPT_2.Text = "";

                    OPT_4.Text = "";
                    checkBox1.Enabled = false;



                }
                else if (Question_box.Text == "HOW MANY OF ENGLISH MUNARCHS ARE NAMED ELIZABETH ?")
                {


                    OPT_2.Text = "";
                    OPT_3.Text = "";

                    checkBox1.Enabled = false;





                }
                else if (Question_box.Text == "WHICH PAKISTHANI LEADER SIGNED SIMLA AGREEMENT ?")
                {
                    OPT_1.Text = "";
                    OPT_3.Text = "";
                    checkBox1.Enabled = false;
                }
                else if (Question_box.Text == "WHO ADOPTED UNIVERSAL DECLARATION OF HUMAN RIGHTS ?")
                {
                    OPT_3.Text = "";
                    OPT_4.Text = "";
                    checkBox1.Enabled = false;


                }
                else if (Question_box.Text == "WHICH OF THESE ANIMALS LAUGHS ?")
                {


                    OPT_1.Text = "";

                    OPT_4.Text = "";
                    checkBox1.Enabled = false;

                }
                else if (Question_box.Text == "HOW DO YOU SAY GOOD BYE IN JAPANESE ?")
                {


                    OPT_1.Text = "";

                    OPT_4.Text = "";
                    checkBox1.Enabled = false;



                }
                else if (Question_box.Text == "WHEN DID SOVIENT UNION BREAK DOWN ?")
                {

                    OPT_2.Text = "";

                    OPT_4.Text = "";
                    checkBox1.Enabled = false;

                }
                else if (Question_box.Text == "WHO PATRONISED KALIDAS ?")
                {


                    OPT_1.Text = "";

                    OPT_4.Text = "";
                    checkBox1.Enabled = false;

                }
                else if (Question_box.Text == "WHO WAS ALSO A BRITISH CITIZEN ?")
                {



                    OPT_2.Text = "";
                    OPT_4.Text = "";
                    checkBox1.Enabled = false;


                }
                if (Question_box.Text == "WHICH OF THESE IS A SYMBOL OF PEACE ?")
                {


                    OPT_2.Text = "";
                    OPT_3.Text = "";

                    checkBox1.Enabled = false;

                }

                else if (Question_box.Text == "WHAT IS THE SYMBOL OF VICTORY ?")
                {


                    OPT_2.Text = "";
                    OPT_3.Text = "";

                    checkBox1.Enabled = false;


                }
                else if (Question_box.Text == "WHO TOUCH TURNED ALL TO GOLD ?")
                {


                    OPT_1.Text = "";
                    OPT_2.Text = "";

                    checkBox1.Enabled = false;

                }
                else
                {
                }
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
            if (Question_box.Text == "IN WHICH DIRECTION DOES A MUSLIM PRAY ?")
            {
            
                F3.label1.Text = "YOU HAVE WON Rs. 10000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH IS THE COMMON EUROPIAN CURRENCY ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 5,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHO LOST HIS TEETH WHILE WRITING MAHABHARAT ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 20,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "IN THE RHYME WHERE DID HUMPTY DUMPTY SIT ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 3,20,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "HOW MANY OF ENGLISH MUNARCHS ARE NAMED ELIZABETH ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 25,00,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH PAKISTHANI LEADER SIGNED SIMLA AGREEMENT ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 50,00,000";
                F3.Show();
                this.Hide();
            }

            else if (Question_box.Text == "WHEN DID SOVIENT UNION BREAK DOWN ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 1000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH OF THESE ANIMALS LAUGHS ?")
            {
                F3.label1.Text = "YOU HAV HAVE WON Rs. 40,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH OF THESE ANIMALS LAUGHS ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs.3,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "HOW DO YOU SAY GOOD BYE IN JAPANESE ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 12,50,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHO PATRONISED KALIDAS ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 80,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHO WAS ALSO A BRITISH CITIZEN ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 6,25,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH OF THESE IS A SYMBOL OF PEACE ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 2,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHAT IS THE SYMBOL OF VICTORY ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs.10,000";
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHO TOUCH TURNED ALL TO GOLD ?")
            {
                F3.label1.Text = "YOU HAVE WON Rs. 1,60,000";
                F3.Show();
                this.Hide();
            }
            else
            {
            }
        }

        private void Question_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
    }
}
