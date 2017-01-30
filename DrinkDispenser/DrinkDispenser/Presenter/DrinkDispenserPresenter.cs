using System;
using DrinkDispenser.Model;

namespace DrinkDispenser.Presenter
{
    public class DrinkDispenserPresenter
    {
        private DrinkDispenserModel _model;
        private IDrinkDispenserView _view;

        /// <summary>
        /// Stores the current control selection
        /// </summary>
        private string _currentControlSelection;

        public DrinkDispenserPresenter(DrinkDispenserModel model, IDrinkDispenserView view)
        {
            _model = model;
            _view = view;

            _view.OnButtonClick += ControlButtonClicked;
        }

        private void ControlButtonClicked(string name)
        {
            if (name == "controlButtonA" || name == "controlButtonB" || name == "controlButtonC" ||
                name == "controlButtonD" || name == "controlButtonE")
            {
            }

            else if (name == "controlButtonOne" || name == "controlButtonTwo" ||
                     name == "controlButtonThree" || name == "controlButtonFour" ||
                     name == "controlButtonFive" || name == "controlButtonSix" ||
                     name == "controlButtonSeven" || name == "controlButtonEight" || name == "controlButtonNine")
            {
            }

            else if (name == "controlEnterButton")
            {
            }

            else if (name == "controlAdminButton")
            {
            }

            else
            {
                throw new ArgumentOutOfRangeException(name, "It is not declared how this button should be handled!");
            }
        }
    }
}