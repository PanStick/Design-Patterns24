using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Builder
{

    internal class FormBuilder
    {
        IButtonsBuilder _buttonsBuilder;
        IWelcomeMessageBuilder _welcomeMessageBuilder;
        Form _result;

        public void SetButtonsBuilder(IButtonsBuilder buttonsBuilder)
        {
            _buttonsBuilder = buttonsBuilder;
        }
        public void SetWMBuilder(IWelcomeMessageBuilder welcomeMessageBuilder)
        {
            _welcomeMessageBuilder = welcomeMessageBuilder;
        }
        public void ConstructForm()
        {
            _result = new Form
            {
                WelcomeMessage = _welcomeMessageBuilder.PrintWM(),
                Buttons = _buttonsBuilder.AddButtons()
            };
        }

        public Form GetForm() {  return _result; }
    }
}
