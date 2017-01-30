using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkDispenser
{
    public partial class DrinkDispenserForm : Form, IDrinkDispenserView
    {
        public delegate void ButtonClick(string name);

        public event ButtonClick OnButtonClick;

        public DrinkDispenserForm()
        {
            InitializeComponent();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            Button button;

            try
            {
                button = (Button) sender;
            }
            catch (InvalidCastException)
            {
                throw new ArgumentException("This function can only be called by a button!");
            }

            OnButtonClick?.Invoke(button.Name);
        }
    }
}