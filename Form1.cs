using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projactPazzi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void UpdateSizeText()
        {
            
            if (rbSmall.Checked)

                TextSize.Text = rbSmall.Text;
            else if (rbMedium.Checked)
                TextSize.Text = rbMedium.Text;
            else if (rbLarge.Checked)
                TextSize.Text = rbLarge.Text;
          
               
          
        }
        private int GetSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToInt32(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToInt32(rbMedium.Tag);
            else if (rbLarge.Checked)
                return Convert.ToInt32(rbLarge.Tag);
            else
                return 0;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeText();
            UpdateTotalPrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeText();
            UpdateTotalPrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeText();
            UpdateTotalPrice();
        }



        private void TextSize_Click(object sender, EventArgs e)
        {
           
        }
        private void GetToppingsNamePrice()
        {
            tbToppangs.Text = ""; // نفرغ النص أولاً

            if (chkChees.Checked)
                tbToppangs.Text += chkChees.Text + " ";
            if (chkMeushrooms.Checked)
                tbToppangs.Text += chkMeushrooms.Text + " ";
            if (chkTometos.Checked)
                tbToppangs.Text += chkTometos.Text + " ";
            if (chkOnon.Checked)
                tbToppangs.Text += chkOnon.Text + " ";
            if (chkOiwus.Checked)
                tbToppangs.Text += chkOiwus.Text + " ";
            if (chkPeppers.Checked)
                tbToppangs.Text += chkPeppers.Text + " ";
        }

        private int GetToppingsPriced()
        {
            int num = 0;
            if (chkChees.Checked)
                num += Convert.ToInt32(chkChees.Tag);
             if (chkMeushrooms.Checked)
                num += Convert.ToInt32(chkMeushrooms.Tag);
             if (chkTometos.Checked)
                num += Convert.ToInt32(chkTometos.Tag);
             if (chkOnon.Checked)
                num += Convert.ToInt32(chkOnon.Tag);
             if (chkOiwus.Checked)
                num += Convert.ToInt32(chkOiwus.Tag);
             if (chkPeppers.Checked)
                num += Convert.ToInt32(chkPeppers.Tag);
            

            return num;

        }

        private void chkChees_CheckedChanged(object sender, EventArgs e)
        {

            GetToppingsNamePrice();
            UpdateTotalPrice();
        }

        private void chkMeushrooms_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsNamePrice();
            UpdateTotalPrice();
        }

        private void chkTometos_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsNamePrice();
            UpdateTotalPrice();
        }

        private void chkOnon_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsNamePrice();
            UpdateTotalPrice();
        }

        private void chkOiwus_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsNamePrice();
            UpdateTotalPrice();
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsNamePrice();
            UpdateTotalPrice();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void UpdateTotalPrice()
        {
            int sizePrice = GetSizePrice();
            int toppingsPrice = GetToppingsPriced();
            int N = ShowTotalPrice();
            int total = sizePrice + toppingsPrice + N;

            textBox2.Text ="$"+ total.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        private void ShowTotalName()
        {
            if (rbThin.Checked)
                btrCrust.Text = rbThin.Text;
            else if(rbThank.Checked)
                btrCrust.Text = rbThank.Text;

        }

        private int ShowTotalPrice()
        {
            if (rbThin.Checked)
                return Convert.ToInt32(rbThin.Tag);
            else if (rbThank.Checked)
                return Convert.ToInt32(rbThank.Tag);
            else
                return 0;

        }
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            ShowTotalName();
            UpdateTotalPrice();
        }

        private void rbThank_CheckedChanged(object sender, EventArgs e)
        {
            ShowTotalName();
            UpdateTotalPrice();
        }

        private void GetEatPlaceName()
        {
            if (rbEatin.Checked)
                rbEat.Text = rbEatin.Text;
            else if (rbTakeOut.Checked)
                rbEat.Text = rbTakeOut.Text;
            else
                rbEat.Text = "No Eat";
        }

        private void gbWhereToEat_Enter(object sender, EventArgs e)
        {

        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            GetEatPlaceName();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            GetEatPlaceName();
        }
    }
}
