using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biletCekilisUygulaması
{
    public partial class Form1 : Form
    {
        ResultForm frmresults = new ResultForm();
        public int ticketNumber;
        public int winnerNumber;
        public int remainingTicket;
        public Form1()
        {
            InitializeComponent();
        }

        

        public void btnStartDraw_Click(object sender, EventArgs e)
        {
            try
            {
                ticketNumber = Convert.ToInt32(txtTicketNumber.Text);
                winnerNumber = Convert.ToInt32(txtWinner.Text);

                btnStartDraw.Enabled = false;
                confirmWinners.Enabled = true;

                Random rnd = new Random();
                if (winnerNumber > templistBox.Items.Count)
                {
                    MessageBox.Show("Error: There can be a maximum of " + templistBox.Items.Count + " winners!");
                    btnStartDraw.Enabled = true;
                    confirmWinners.Enabled = false;
                }
                else
                {
                    if (switchSelected.Checked == true)
                    {
                        for (int i = 1; i <= winnerNumber; i++)
                        {
                            int selceted = rnd.Next(0, templistBox.Items.Count);
                            listBox1.Items.Add(templistBox.Items[selceted]);
                        }
                    }

                    else
                    {
                        for (int i = 1; i <= winnerNumber; i++)
                        {
                            int selceted = rnd.Next(0, templistBox.Items.Count);
                            listBox1.Items.Add(templistBox.Items[selceted]);
                            templistBox.Items.RemoveAt(selceted);
                        }
                    }
                    remainingTicket -= winnerNumber;
                    lblRemainingTicket.Text = remainingTicket.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error: Please do not leave any text box empty!");
            }
        }

       

        public void ticketConfirm_Click(object sender, EventArgs e)
        {
            btnStartDraw.Enabled = true;
            ticketConfirm.Enabled = false;
            txtTicketNumber.Enabled = false;
            switchSelected.Enabled = false;
            templistBox.Items.Clear();

            remainingTicket = Convert.ToInt32(txtTicketNumber.Text);
            lblRemainingTicket.Text = remainingTicket.ToString();

            ticketNumber = Convert.ToInt32(txtTicketNumber.Text);
            for (int i = 0; i < ticketNumber+1; i++)
            {
                templistBox.Items.Add(i.ToString());
            }
            templistBox.Items.RemoveAt(0);
        }

        private void confirmWinners_Click(object sender, EventArgs e)
        {
            ticketNumber = Convert.ToInt32(txtTicketNumber.Text);
            winnerNumber = Convert.ToInt32(txtWinner.Text);
            btnStartDraw.Enabled = true;
            confirmWinners.Enabled = false;
            btnResults.Enabled = true;

            frmresults.richTextBox1.AppendText(Environment.NewLine + txtGiftName.Text);
            for (int i = 0; i <= listBox1.Items.Count-1; i++)
            {
                frmresults.richTextBox1.AppendText(Environment.NewLine + listBox1.Items[i]);
            }

            listBox1.Items.Clear();
            txtGiftName.Text = "";
            txtWinner.Text = "";
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("ERROR: Please save this round before going to the results panel!");
            }
            else
            {
                this.Hide();
                frmresults.Show();
            }
        }
        private void txtGiftName_TextChanged(object sender, EventArgs e)
        {
            lblGft.Text = txtGiftName.Text + " Winners:";
        }
        private void txtWinner_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTicketNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.github.com/AEKHer");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket icon created by RA_IC0N21 - Flaticon");
        }
    }
}
