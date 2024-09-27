using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(numericStartingMoney.Value <= 0 || numericStartingMoney.Value >= 50000)
            {
                MessageBox.Show("Invalid value");
                return;
            }
            if (textBoxUsername.Text.Length < 1 || textBoxUsername.Text.Length > 20)
            {
                MessageBox.Show("Username too small or too big");
                return;
            }

            this.Hide();
            GameForm gameForm = new GameForm(numericDeckNr.Value.ToString(),textBoxUsername.Text,
                numericStartingMoney.Value);
            gameForm.Closed += (s, args) => this.Close();
            gameForm.Show();
        }
    }
}
