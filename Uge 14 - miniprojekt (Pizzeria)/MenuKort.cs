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
        Ingredients newWindow = new Ingredients();
        Pizzas pizza = new Pizzas();
        TaskMaster TM = new TaskMaster();
        public MenuKort()
        {
            InitializeComponent();
            Number_1.Text = pizza.pizzaID.ElementAt(0);
            Number_2.Text = pizza.pizzaID.ElementAt(1);
            Number_3.Text = pizza.pizzaID.ElementAt(2);
            Number_4.Text = pizza.pizzaID.ElementAt(3);
            Pizza_Name1.Text = pizza.preMadePizzas.ElementAt(0);
            Pizza_Name2.Text = pizza.preMadePizzas.ElementAt(1);
            Pizza_Name3.Text = pizza.preMadePizzas.ElementAt(2);
            Pizza_Name4.Text = pizza.preMadePizzas.ElementAt(3);
            Pizza_Description1.Text = pizza.descriptions.ElementAt(0);
            Pizza_Description2.Text = pizza.descriptions.ElementAt(1);
            Pizza_Description3.Text = pizza.descriptions.ElementAt(2);
            Pizza_Description4.Text = pizza.descriptions.ElementAt(3);
        }

        private void MenuKort_Load(object sender, EventArgs e)
        {

        }

        private void Purchase1_Click(object sender, EventArgs e)
        {
                TM.temporaryString1 = Number_1.Text;
                TM.temporaryString2 = Pizza_Name1.Text;
                TM.temporaryString3 = Pizza_Description1.Text;
            
            newWindow.Show(this);
        }

        private void Purchase2_Click(object sender, EventArgs e)
        {
            newWindow.Show(this);
        }

        private void Purchase3_Click(object sender, EventArgs e)
        {
            newWindow.Show(this);
        }

        private void Purchase4_Click(object sender, EventArgs e)
        {
            
        }

        private void Price_Normal1_CheckedChanged(object sender, EventArgs e)
        {
            if(Price_Normal1.Checked)
            {
                TM.finalPrice = 75;
            }
            else if(!Price_Normal1.Checked)
            {

            }
        }

        private void Price_Normal2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Price_Normal3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Price_Normal4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Price_Family1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Price_Family2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Price_Family3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Price_Family4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
