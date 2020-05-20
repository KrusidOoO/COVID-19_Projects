using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uge_14___miniprojekt__Pizzeria_
{
    public partial class Form1 : Form
    {
        MenuKort mk = new MenuKort();
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuKort_click(object sender, EventArgs e)
        {
            this.Hide();
            mk.Show();
        }
    }
}
