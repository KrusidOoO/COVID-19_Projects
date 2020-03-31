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
        Label label;
        public Ingredients(Label label)
        {
            InitializeComponent();
            this.Chosen_Pizza_Number_Label = label;
        }

        private void Ingredients_Load(object sender, EventArgs e)
        {
            
        }
    }
}
