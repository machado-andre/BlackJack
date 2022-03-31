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
            GameForm gameForm = new GameForm(numericDeckNr.Value.ToString(),textBoxUsername.Text,
                numericStartingMoney.Value);
            gameForm.ShowDialog();
            this.Close();
        }
    }
}
