using System;
using System.Windows.Forms;

namespace Uge_14___miniprojekt__Pizzeria_
{
    public partial class Ingredients : Form
    {
        public MenuKort MK;
        public Pizzas pizza;
        public Ingredients ingredients;
        public TaskMaster TM;
        public void ShowSelectedPizza()
        {
            Chosen_Pizza_Number_Label.Text =$"{pizza.ID}.";
            Chosen_Pizza_Name_Label.Text = $"{pizza.Name} {pizza.size}";
            Chosen_Pizza_Description_Label.Text = $"{pizza.description}";
        }
        public Ingredients(MenuKort menu)
        {
            InitializeComponent();
            this.pizza = menu.pizza;
            this.MK = menu;
            ShowSelectedPizza();
            Order_Ingredients_Label.Text = "";
            Price_In_Total_Numbers_Label.Text = menu.totalprice.ToString()+",00";
        }

        private void Ingredients_Load(object sender, EventArgs e)
        {

        }
        #region CheckBoxes
        private void Topping_Options1_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options1.Checked)
            {
                Order_Ingredients_Label.Text += "Ananas +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
            else if (!Topping_Options1.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Ananas +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
        }

        private void Topping_Options2_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options2.Checked)
            {
                Order_Ingredients_Label.Text += "Artiskok +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options2.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Artiskok +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
        }

        private void Topping_Options3_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options3.Checked)
            {
                Order_Ingredients_Label.Text += "Asparges +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options3.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Asparges +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
        }

        private void Topping_Options4_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options4.Checked)
            {
                Order_Ingredients_Label.Text += "Bacon +10,00 kr\n";
                MK.totalprice = MK.totalprice + 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options4.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Bacon +10,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
        }

        private void Topping_Options5_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options5.Checked)
            {
                Order_Ingredients_Label.Text += "Bernaisesauce +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options5.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Bernaisesauce +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options6_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options6.Checked)
            {
                Order_Ingredients_Label.Text += "Champignon +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options6.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Champignon +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options7_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options7.Checked)
            {
                Order_Ingredients_Label.Text += "Chili +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options7.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Chili +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options8_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options8.Checked)
            {
                Order_Ingredients_Label.Text += "Cocktailpølser +10,00 kr\n";
                MK.totalprice = MK.totalprice + 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options8.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Cocktailpølser +10,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options9_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options9.Checked)
            {
                Order_Ingredients_Label.Text += "Ekstra ost +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options9.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Ekstra ost +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options10_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options10.Checked)
            {
                Order_Ingredients_Label.Text += "Fetaost +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options10.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Fetaost +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options11_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options11.Checked)
            {
                Order_Ingredients_Label.Text += "Frisk tomat +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options11.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Frisk tomat +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options12_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options12.Checked)
            {
                Order_Ingredients_Label.Text += "Gorgonzola +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options12.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Gorgonzola +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options13_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options13.Checked)
            {
                Order_Ingredients_Label.Text += "Grøn peber +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options13.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Grøn peber +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options14_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options14.Checked)
            {
                Order_Ingredients_Label.Text += "Hvidløg +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options14.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Hvidløg +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options15_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options15.Checked)
            {
                Order_Ingredients_Label.Text += "Jalapenos +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options15.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Jalapenos +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
        }

        private void Topping_Options16_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options16.Checked)
            {
                Order_Ingredients_Label.Text += "Kebab +10,00 kr\n";
                MK.totalprice = MK.totalprice + 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options16.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Kebab +10,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options17_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options17.Checked)
            {
                Order_Ingredients_Label.Text += "Kødsauce +10,00 kr\n";
                MK.totalprice = MK.totalprice + 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options17.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Kødsauce +10,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options18_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options18.Checked)
            {
                Order_Ingredients_Label.Text += "Krabbekød +10,00 kr\n";
                MK.totalprice = MK.totalprice + 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options18.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Krabbekød +10,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options19_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options19.Checked)
            {
                Order_Ingredients_Label.Text += "Kylling +10,00 kr\n";
                MK.totalprice = MK.totalprice + 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options19.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Kylling +10,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Topping_Options20_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options20.Checked)
            {
                Order_Ingredients_Label.Text += "Løg +5,00 kr\n";
                MK.totalprice = MK.totalprice + 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Topping_Options20.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Løg +5,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 5;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }
        #endregion

        private void Thickness_RButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Thickness_RButton1.Checked)
            {
                Order_Ingredients_Label.Text += "Almindelig bund +0,00 kr\n";
                MK.totalprice = MK.totalprice + 0;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Thickness_RButton1.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Almindelig bund +0,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 0;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }
        private void Thickness_RButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Thickness_RButton2.Checked)
            {
                Order_Ingredients_Label.Text += "Dobbelt bund +10,00 kr\n";
                MK.totalprice = MK.totalprice + 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Thickness_RButton2.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Dobbelt bund +10,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 10;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }
        private void Thickness_RButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (Thickness_RButton3.Checked)
            {
                Order_Ingredients_Label.Text += "Deep pan +15,00 kr\n";
                MK.totalprice = MK.totalprice + 15;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";
            }
            else if (!Thickness_RButton3.Checked)
            {
                var replacement = Order_Ingredients_Label.Text.Replace("Deep pan +15,00 kr\n", "");
                Order_Ingredients_Label.Text = replacement;
                MK.totalprice = MK.totalprice - 15;
                Price_In_Total_Numbers_Label.Text = MK.totalprice.ToString() + ",00";

            }
        }

        private void Done_Selecting_Button_Click(object sender, EventArgs e)
        {
            MK.Order = "1 x Pizzaer ";
            if(Thickness_RButton1.Checked)
            {
                MK.Order += "- Almindelig - ";
            }
            else if(Thickness_RButton2.Checked)
            {
                MK.Order += "- Dobbeltbund - ";
            }
            else if(Thickness_RButton3.Checked)
            {
                MK.Order += "- Deep Pan - ";
            }
            MK.Order += Chosen_Pizza_Name_Label.Text;
            this.Hide();
        }
    }
}
