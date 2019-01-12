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
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
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
                    button1.Text = button6.Text;
                    button6.Text = "";
                    count = count + 1;
                }
                if (button2.Text == "" && count == 1)
                {
                    button2.Text = button7.Text;
                    button7.Text = "";
                    count = count + 1;
                }
                if (button3.Text == "" && count == 1)
                {
                    button3.Text = button8.Text;
                    button8.Text = "";
                    count = count + 1;
                }
                if (button4.Text == "" && count == 1)
                {
                    button4.Text = button9.Text;
                    button9.Text = "";
                    count = count + 1;
                }
                if (button5.Text == "" && count == 1)
                {
                    button5.Text = button10.Text;
                    button10.Text = "";
                    count = count + 1;
                }
                if (button6.Text == "" && count == 1)
                {
                    button6.Text = button11.Text;
                    button11.Text = "";
                    count = count + 1;
                }
                if (button7.Text == "" && count == 1)
                {
                    button7.Text = button12.Text;
                    button12.Text = "";
                    count = count + 1;
                }
                if (button8.Text == "" && count == 1)
                {
                    button8.Text = button13.Text;
                    button13.Text = "";
                    count = count + 1;
                }
                if (button9.Text == "" && count == 1)
                {
                    button9.Text = button14.Text;
                    button14.Text = "";
                    count = count + 1;
                }
                if (button10.Text == "" && count == 1)
                {
                    button10.Text = button15.Text;
                    button15.Text = "";
                    count = count + 1;
                }
                if (button11.Text == "" && count == 1)
                {
                    button11.Text = button16.Text;
                    button16.Text = "";
                    count = count + 1;
                }
                if (button12.Text == "" && count == 1)
                {
                    button12.Text = button17.Text;
                    button17.Text = "";
                    count = count + 1;
                }
                if (button13.Text == "" && count == 1)
                {
                    button13.Text = button18.Text;
                    button18.Text = "";
                    count = count + 1;
                }
                if (button14.Text == "" && count == 1)
                {
                    button14.Text = button19.Text;
                    button19.Text = "";
                    count = count + 1;
                }
                if (button15.Text == "" && count == 1)
                {
                    button15.Text = button20.Text;
                    button20.Text = "";
                    count = count + 1;
                }
                win();
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                count = 1;
                if (button6.Text == "" && count == 1)
                {
                    button6.Text = button1.Text;
                    button1.Text = "";
                    count = count + 1;
                }
                if (button7.Text == "" && count == 1)
                {
                    button7.Text = button2.Text;
                    button2.Text = "";
                    count = count + 1;
                }
                if (button8.Text == "" && count == 1)
                {
                    button8.Text = button3.Text;
                    button3.Text = "";
                    count = count + 1;
                }
                if (button9.Text == "" && count == 1)
                {
                    button9.Text = button4.Text;
                    button4.Text = "";
                    count = count + 1;
                }
                if (button10.Text == "" && count == 1)
                {
                    button10.Text = button5.Text;
                    button5.Text = "";
                    count = count + 1;
                }
                if (button11.Text == "" && count == 1)
                {
                    button11.Text = button6.Text;
                    button6.Text = "";
                    count = count + 1;
                }
                if (button12.Text == "" && count == 1)
                {
                    button12.Text = button7.Text;
                    button7.Text = "";
                    count = count + 1;
                }
                if (button13.Text == "" && count == 1)
                {
                    button13.Text = button8.Text;
                    button8.Text = "";
                    count = count + 1;
                }
                if (button14.Text == "" && count == 1)
                {
                    button14.Text = button9.Text;
                    button9.Text = "";
                    count = count + 1;
                }
                if (button15.Text == "" && count == 1)
                {
                    button15.Text = button10.Text;
                    button10.Text = "";
                    count = count + 1;
                }
                if (button16.Text == "" && count == 1)
                {
                    button16.Text = button11.Text;
                    button11.Text = "";
                    count = count + 1;
                }
                if (button17.Text == "" && count == 1)
                {
                    button17.Text = button12.Text;
                    button12.Text = "";
                    count = count + 1;
                }
                if (button18.Text == "" && count == 1)
                {
                    button18.Text = button13.Text;
                    button13.Text = "";
                    count = count + 1;
                }
                if (button19.Text == "" && count == 1)
                {
                    button19.Text = button14.Text;
                    button14.Text = "";
                    count = count + 1;
                }
                if (button20.Text == "" && count == 1)
                {
                    button20.Text = button15.Text;
                    button15.Text = "";
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
                if (button4.Text == "" && count == 1)
                {
                    button4.Text = button5.Text;
                    button5.Text = "";
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
                if (button8.Text == "" && count == 1)
                {
                    button8.Text = button9.Text;
                    button9.Text = "";
                    count = count + 1;
                }
                if (button9.Text == "" && count == 1)
                {
                    button9.Text = button10.Text;
                    button10.Text = "";
                    count = count + 1;
                }
                if (button11.Text == "" && count == 1)
                {
                    button11.Text = button12.Text;
                    button12.Text = "";
                    count = count + 1;
                }
                if (button12.Text == "" && count == 1)
                {
                    button12.Text = button13.Text;
                    button13.Text = "";
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
                if (button16.Text == "" && count == 1)
                {
                    button16.Text = button17.Text;
                    button17.Text = "";
                    count = count + 1;
                }
                if (button17.Text == "" && count == 1)
                {
                    button17.Text = button18.Text;
                    button18.Text = "";
                    count = count + 1;
                }
                if (button18.Text == "" && count == 1)
                {
                    button18.Text = button19.Text;
                    button19.Text = "";
                    count = count + 1;
                }
                if (button19.Text == "" && count == 1)
                {
                    button19.Text = button20.Text;
                    button20.Text = "";
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
                if (button5.Text == "" && count == 1)
                {
                    button5.Text = button4.Text;
                    button4.Text = "";
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
                if (button9.Text == "" && count == 1)
                {
                    button9.Text = button8.Text;
                    button8.Text = "";
                    count = count + 1;
                }
                if (button10.Text == "" && count == 1)
                {
                    button10.Text = button9.Text;
                    button9.Text = "";
                    count = count + 1;
                }
                if (button12.Text == "" && count == 1)
                {
                    button12.Text = button11.Text;
                    button11.Text = "";
                    count = count + 1;
                }
                if (button13.Text == "" && count == 1)
                {
                    button13.Text = button12.Text;
                    button12.Text = "";
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
                if (button17.Text == "" && count == 1)
                {
                    button17.Text = button16.Text;
                    button16.Text = "";
                    count = count + 1;
                }
                if (button18.Text == "" && count == 1)
                {
                    button18.Text = button17.Text;
                    button17.Text = "";
                    count = count + 1;
                }
                if (button19.Text == "" && count == 1)
                {
                    button19.Text = button18.Text;
                    button18.Text = "";
                    count = count + 1;
                }
                if (button20.Text == "" && count == 1)
                {
                    button20.Text = button19.Text;
                    button19.Text = "";
                    count = count + 1;
                }
                win();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        public void win()
        {

            if (button1.Text == "T" && button2.Text == "U" && button3.Text == "G" && button4.Text == "A" && button5.Text == "S"
             && button6.Text == "A" && button7.Text == "K" && button8.Text == "H" && button9.Text == "I" && button10.Text == "R"
             && button11.Text == "L" && button12.Text == "U" && button13.Text == "A" && button14.Text == "R" && button15.Text == ""
             && button16.Text == "B" && button17.Text == "I" && button18.Text == "A" && button19.Text == "S" && button20.Text == "A")
            {
                MessageBox.Show("Selamat Kamu Menang...!!!");
                {
                    FormHome Home = new FormHome();
                    Home.Show();
                    this.Close();
                }
            }
        }
    }
}
