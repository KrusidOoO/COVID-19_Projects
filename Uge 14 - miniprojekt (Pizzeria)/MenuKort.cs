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
        public Pizzas pizza;
        public TaskMaster TM;
        public int totalprice;
        public MenuKort()
        {
            InitializeComponent();
            //Basket_Content_Label.Text = TM.Order;
        }

        private void MenuKort_Load(object sender, EventArgs e)
        {

        }
        private void Select_Button_Click(object sender, EventArgs e)
        {
            if(PriceRegular1.Checked||PriceFam1.Checked)
            {
                pizza = Pizzas.pizzaCollection[0];
            }
            else if(PriceRegular2.Checked||PriceFam2.Checked)
            {
                pizza = Pizzas.pizzaCollection[1];
            }
            else if(PriceRegular3.Checked||PriceFam3.Checked)
            {
                pizza = Pizzas.pizzaCollection[2];
            }
            else if(PriceRegular4.Checked||PriceFam4.Checked)
            {
                pizza = Pizzas.pizzaCollection[3];
            }
            else
            {
                MessageBox.Show("Vælg en størrelse før du kan fortsætte");
            }

            if (pizza == null)
                return;

            totalprice = (PriceRegular1.Checked || PriceRegular2.Checked || PriceRegular3.Checked || PriceRegular4.Checked) ? pizza.RegularPrice : pizza.FamPrice;
            pizza.size = (PriceRegular1.Checked || PriceRegular2.Checked || PriceRegular3.Checked || PriceRegular4.Checked) ? "Alm." : "Fam.";
            if(pizza!=Pizzas.pizzaCollection[3])
            {
                pizza.IngredientsSelection(this);
            }
            else
            {

            }
        }
    }
}
