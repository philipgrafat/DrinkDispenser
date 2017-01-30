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

            switch (button.Name)
            {
                case "controlButtonA":
                case "controlButtonB":
                case "controlButtonC":
                case "controlButtonD":
                case "controlButtonE":
                    break;
                case "controlButtonOne":
                case "controlButtonTwo":
                case "controlButtonThree":
                case "controlButtonFour":
                case "controlButtonFive":
                case "controlButtonSix":
                case "controlButtonSeven":
                case "controlButtonEight":
                case "controlButtonNine":
                    break;
                case "controlAdminButton":
                    break;
                default:
                    throw new ArgumentOutOfRangeException(button.Name, "It is not declared how this button should be handled!");
            }
        }
    }
}
