using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt__Pizzeria_
{
    public class Pizzas
    {
        public List<string> pizzaID = new List<string>
        {
            "1.",
            "2.",
            "3.",
            "4."
        };
        public List<string> preMadePizzas = new List<string> 
        {
            "Margherita",
            "Hawaii",
            "Prosciutto",
            "Din egen pizza" 
        };
        public List<string> descriptions = new List<string> 
        { "Med tomat og ost",
            "Med tomat, ost, skinkekød og ananas",
            "Med tomat, ost og permaskinke",
            "Med tomat, ost og op til 5 valgfri ingredienser" 
        };
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

    }
}
