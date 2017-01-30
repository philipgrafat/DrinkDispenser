using System;

namespace DrinkDispenser
{
    public interface IDrinkDispenserView
    {
        event DrinkDispenserForm.ButtonClick OnButtonClick;
    }
}