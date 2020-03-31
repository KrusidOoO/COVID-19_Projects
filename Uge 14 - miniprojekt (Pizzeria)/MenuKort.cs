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
    public partial class MenuKort : Form
    {
        public MenuKort()
        {
            InitializeComponent();
        }

        private void MenuKort_Load(object sender, EventArgs e)
        {
            List<string> Pizzaer = new List<string> { };
            LabelClass labelClass = new LabelClass();

        }

        private void Purchase1_Click(object sender, EventArgs e)
        {
            
        }

        private void Purchase2_Click(object sender, EventArgs e)
        {
            
        }

        private void Purchase3_Click(object sender, EventArgs e)
        {
            Ingredients newWindow = new Ingredients(Number_1);
            newWindow.Show(this);
        }

        private void Purchase4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
