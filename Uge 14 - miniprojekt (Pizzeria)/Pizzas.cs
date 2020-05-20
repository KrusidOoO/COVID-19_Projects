using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt__Pizzeria_
{
    public class Pizzas
    {
        public int ID;
        public string Name;
        public string description;

        public string selectedPizzaID;
        public string selectedPizzaName;
        public string selectedPizzaDesc;
        public string size = "";
        public int RegularPrice = 75;
        public int FamPrice = 125;

        public static Pizzas[] pizzaCollection =
        {
            new Pizzas(1,"Margherita","Med tomat og ost"),
            new Pizzas(2,"Hawaii","Med tomat, ost, skinkekød og ananas"),
            new Pizzas(3,"Prosciutto","Med tomat, ost og parmaskinke"),
            new Pizzas(4,"Din egen pizza","Med tomat, ost og op til 5 valgfri ingredienser")
        };
        public Pizzas(int ID,string Name,string description)
        {
            this.ID = ID;
            this.Name = Name;
            this.description = description;
        }
        public List<string> Sodas = new List<string>
        {
            "Coca Cola",
            "Coca Cola Zero",
            "Fanta",
            "Sprite"
        };
        public List<string> SodaSizes = new List<string>
        {
            "330 mL (dåse)",
            "0,5 L (lille flaske)",
            "2 L (stor flaske)"
        };
        public void IngredientsSelection(MenuKort menu)
        {
            new Ingredients(menu).Show();
        }
    }
}
