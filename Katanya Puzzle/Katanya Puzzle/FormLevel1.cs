using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace katanya_puzzle
{
    public partial class FormLevel1 : Form
    {
        
        public FormLevel1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        int count = 0;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                count = 1;
                if (button1.Text == "" && count == 1)
                {
                    button1.Text = button5.Text;
                    button5.Text = "";
                    count = count + 1;
                }
                if (button2.Text == "" && count == 1)
                {
                    button2.Text = button6.Text;
                    button6.Text = "";
                    count = count + 1;
                }
                if (button3.Text == "" && count == 1)
                {
                    button3.Text = button7.Text;
                    button7.Text = "";
                    count = count + 1;
                }
                if (button4.Text == "" && count == 1)
                {
                    button4.Text = button8.Text;
                    button8.Text = "";
                    count = count + 1;
                }
                if (button5.Text == "" && count == 1)
                {
                    button5.Text = button9.Text;
                    button9.Text = "";
                    count = count + 1;
                }
                if (button6.Text == "" && count == 1)
                {
                    button6.Text = button10.Text;
                    button10.Text = "";
                    count = count + 1;
                }
                if (button7.Text == "" && count == 1)
                {
                    button7.Text = button11.Text;
                    button11.Text = "";
                    count = count + 1;
                }
                if (button8.Text == "" && count == 1)
                {
                    button8.Text = button12.Text;
                    button12.Text = "";
                    count = count + 1;
                }
                if (button9.Text == "" && count == 1)
                {
                    button9.Text = button13.Text;
                    button13.Text = "";
                    count = count + 1;
                }
                if (button10.Text == "" && count == 1)
                {
                    button10.Text = button14.Text;
                    button14.Text = "";
                    count = count + 1;
                }
                if (button11.Text == "" && count == 1)
                {
                    button11.Text = button15.Text;
                    button15.Text = "";
                    count = count + 1;
                }
                if (button12.Text == "" && count == 1)
                {
                    button12.Text = button16.Text;
                    button16.Text = "";
                    count = count + 1;
                }
                win();
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                count = 1;
                if (button5.Text == "" && count == 1)
                {
                    button5.Text = button1.Text;
                    button1.Text = "";
                    count = count + 1;
                }
                if (button6.Text == "" && count == 1)
                {
                    button6.Text = button2.Text;
                    button2.Text = "";
                    count = count + 1;
                }
                if (button7.Text == "" && count == 1)
                {
                    button7.Text = button3.Text;
                    button3.Text = "";
                    count = count + 1;
                }
                if (button8.Text == "" && count == 1)
                {
                    button8.Text = button4.Text;
                    button4.Text = "";
                    count = count + 1;
                }
                if (button9.Text == "" && count == 1)
                {
                    button9.Text = button5.Text;
                    button5.Text = "";
                    count = count + 1;
                }
                if (button10.Text == "" && count == 1)
                {
                    button10.Text = button6.Text;
                    button6.Text = "";
                    count = count + 1;
                }
                if (button11.Text == "" && count == 1)
                {
                    button11.Text = button7.Text;
                    button7.Text = "";
                    count = count + 1;
                }
                if (button12.Text == "" && count == 1)
                {
                    button12.Text = button8.Text;
                    button8.Text = "";
                    count = count + 1;
                }
                if (button13.Text == "" && count == 1)
                {
                    button13.Text = button9.Text;
                    button9.Text = "";
                    count = count + 1;
                }
                if (button14.Text == "" && count == 1)
                {
                    button14.Text = button10.Text;
                    button10.Text = "";
                    count = count + 1;
                }
                if (button15.Text == "" && count == 1)
                {
                    button15.Text = button11.Text;
                    button11.Text = "";
                    count = count + 1;
                }
                if (button16.Text == "" && count == 1)
                {
                    button16.Text = button12.Text;
                    button12.Text = "";
                    count = count + 1;
                }
                win();
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                count = 1;
                if (button1.Text == "" && count == 1)
                {
                    button1.Text = button2.Text;
                    button2.Text = "";
                    count = count + 1;
                }
                if (button2.Text == "" && count == 1)
                {
                    button2.Text = button3.Text;
                    button3.Text = "";
                    count = count + 1;
                }
                if (button3.Text == "" && count == 1)
                {
                    button3.Text = button4.Text;
                    button4.Text = "";
                    count = count + 1;
                }
                if (button5.Text == "" && count == 1)
                {
                    button5.Text = button6.Text;
                    button6.Text = "";
                    count = count + 1;
                }
                if (button6.Text == "" && count == 1)
                {
                    button6.Text = button7.Text;
                    button7.Text = "";
                    count = count + 1;
                }
                if (button7.Text == "" && count == 1)
                {
                    button7.Text = button8.Text;
                    button8.Text = "";
                    count = count + 1;
                }
                if (button9.Text == "" && count == 1)
                {
                    button9.Text = button10.Text;
                    button10.Text = "";
                    count = count + 1;
                }
                if (button10.Text == "" && count == 1)
                {
                    button10.Text = button11.Text;
                    button11.Text = "";
                    count = count + 1;
                }
                if (button11.Text == "" && count == 1)
                {
                    button11.Text = button12.Text;
                    button12.Text = "";
                    count = count + 1;
                }
                if (button13.Text == "" && count == 1)
                {
                    button13.Text = button14.Text;
                    button14.Text = "";
                    count = count + 1;
                }
                if (button14.Text == "" && count == 1)
                {
                    button14.Text = button15.Text;
                    button15.Text = "";
                    count = count + 1;
                }
                if (button15.Text == "" && count == 1)
                {
                    button15.Text = button16.Text;
                    button16.Text = "";
                    count = count + 1;
                }
                win();
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                count = 1;
                if (button2.Text == "" && count == 1)
                {
                    button2.Text = button1.Text;
                    button1.Text = "";
                    count = count + 1;
                }
                if (button3.Text == "" && count == 1)
                {
                    button3.Text = button2.Text;
                    button2.Text = "";
                    count = count + 1;
                }
                if (button4.Text == "" && count == 1)
                {
                    button4.Text = button3.Text;
                    button3.Text = "";
                    count = count + 1;
                }
                if (button6.Text == "" && count == 1)
                {
                    button6.Text = button5.Text;
                    button5.Text = "";
                    count = count + 1;
                }
                if (button7.Text == "" && count == 1)
                {
                    button7.Text = button6.Text;
                    button6.Text = "";
                    count = count + 1;
                }
                if (button8.Text == "" && count == 1)
                {
                    button8.Text = button7.Text;
                    button7.Text = "";
                    count = count + 1;
                }
                if (button10.Text == "" && count == 1)
                {
                    button10.Text = button9.Text;
                    button9.Text = "";
                    count = count + 1;
                }
                if (button11.Text == "" && count == 1)
                {
                    button11.Text = button10.Text;
                    button10.Text = "";
                    count = count + 1;
                }
                if (button12.Text == "" && count == 1)
                {
                    button12.Text = button11.Text;
                    button11.Text = "";
                    count = count + 1;
                }
                if (button14.Text == "" && count == 1)
                {
                    button14.Text = button13.Text;
                    button13.Text = "";
                    count = count + 1;
                }
                if (button15.Text == "" && count == 1)
                {
                    button15.Text = button14.Text;
                    button14.Text = "";
                    count = count + 1;
                }
                if (button16.Text == "" && count == 1)
                {
                    button16.Text = button15.Text;
                    button15.Text = "";
                    count = count + 1;
                }
                win();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        public void win()
        {

            if (button1.Text == "A" && button2.Text == "K" && button3.Text == "U" && button4.Text == ""
            && button5.Text == "K" && button6.Text == "A" && button7.Text == "M" && button8.Text == "U"
            && button9.Text == "K" && button10.Text == "I" && button11.Text == "T" && button12.Text == "A"
            && button13.Text == "B" && button14.Text == "I" && button15.Text == "S" && button16.Text == "A")
            {
                MessageBox.Show("Level 1 selesai. Klik Ok untuk Level selanjutnya");
                {
                    FormLevel2 Level2 = new FormLevel2();
                    Level2.Show();
                    this.Close();
                }
            }
        }

    }
}
