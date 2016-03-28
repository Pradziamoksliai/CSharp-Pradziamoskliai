using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PirmaUzduotis
{
    public partial class Form3 : Form
    {
        private string number;

        public string passValue
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public Form3()
        {
           InitializeComponent();
        }

        private void laukas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loads(object sender, EventArgs e)
        {
            if (number != "" && System.Text.RegularExpressions.Regex.IsMatch(number, "[^A-Za-z]"))
            {
                laukas.Text += number;
                laukas.AppendText(Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Tekstinis laukas yra tuscias arba ivesti buvo ne skaiciai");
            }
        }
    }
}
