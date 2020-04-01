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
    public partial class Ingredients : Form
    {
        int finalPrice;
        public Ingredients()
        {
            InitializeComponent();
            FinalOrder_Plus_Ingredients_textBox.Text = "";
            if(Price_In_Total_Numbers_Label.Text=="0")
            {
                Price_In_Total_Numbers_Label.Text = "0,00";
            }
        }

        private void Ingredients_Load(object sender, EventArgs e)
        {
        }
        #region CheckBoxes
        private void Topping_Options1_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options1.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Ananas +5,00 kr\n";
                finalPrice=finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString()+",00";

            }
            else if (!Topping_Options1.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Ananas +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString()+",00";
            }
        }

        private void Topping_Options2_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options2.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Artiskok +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString()+",00";
            }
            else if (!Topping_Options2.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Artiskok +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString()+",00";

            }
        }

        private void Topping_Options3_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options3.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Asparges +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString()+",00";
            }
            else if (!Topping_Options3.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Asparges +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString()+",00";

            }
        }

        private void Topping_Options4_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options4.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Bacon +10,00 kr\n";
                finalPrice = finalPrice + 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString()+",00";
            }
            else if (!Topping_Options4.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Bacon +10,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
        }

        private void Topping_Options5_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options5.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Bernaisesauce +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options5.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Bernaisesauce +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options6_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options6.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Champignon +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options6.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Champignon +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options7_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options7.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Chili +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options7.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Chili +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options8_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options8.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Cocktailpølser +10,00 kr\n";
                finalPrice = finalPrice + 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options8.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Cocktailpølser +10,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options9_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options9.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Ekstra ost +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options9.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Ekstra ost +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options10_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options10.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Fetaost +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options10.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Fetaost +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options11_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options11.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Frisk tomat +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options11.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Frisk tomat +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options12_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options12.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Gorgonzola +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options12.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Gorgonzola +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options13_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options13.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Grøn peber +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options13.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Grøn peber +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options14_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options14.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Hvidløg +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options14.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Hvidløg +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options15_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options15.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Jalapenos +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options15.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Jalapenos +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
        }

        private void Topping_Options16_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options16.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Kebab +10,00 kr\n";
                finalPrice = finalPrice + 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options16.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Kebab +10,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options17_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options17.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Kødsauce +10,00 kr\n";
                finalPrice = finalPrice + 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options17.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Kødsauce +10,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options18_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options18.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Krabbekød +10,00 kr\n";
                finalPrice = finalPrice + 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options18.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Krabbekød +10,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options19_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options19.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Kylling +10,00 kr\n";
                finalPrice = finalPrice + 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options19.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Kylling +10,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Topping_Options20_CheckedChanged(object sender, EventArgs e)
        {
            if (Topping_Options20.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Løg +5,00 kr\n";
                finalPrice = finalPrice + 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Topping_Options20.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Løg +5,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 5;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }
        #endregion

        private void Thickness_RButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Thickness_RButton1.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Almindelig bund +0,00 kr\n";
                finalPrice = finalPrice + 0;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Thickness_RButton1.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Almindelig bund +0,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice -0;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Thickness_RButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Thickness_RButton2.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Dobbelt bund +10,00 kr\n";
                finalPrice = finalPrice + 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Thickness_RButton2.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Dobbelt bund +10,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 10;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }

        private void Thickness_RButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (Thickness_RButton3.Checked)
            {
                FinalOrder_Plus_Ingredients_textBox.Text += "Deep pan +15,00 kr\n";
                finalPrice = finalPrice + 15;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";
            }
            else if (!Thickness_RButton3.Checked)
            {
                var replacement = FinalOrder_Plus_Ingredients_textBox.Text.Replace("Deep pan +15,00 kr\n", "");
                FinalOrder_Plus_Ingredients_textBox.Text = replacement;
                finalPrice = finalPrice - 15;
                Price_In_Total_Numbers_Label.Text = finalPrice.ToString() + ",00";

            }
        }
    }
}
