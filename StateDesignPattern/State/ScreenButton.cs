using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //State
    interface IButtonState
    {
        void ChangeMod(Button button);
    }

    //ConcreteState
    class OpenButtonState : IButtonState
    {
        public void ChangeMod(Button button)
        {
            Console.WriteLine("Mode changing is active.");
            /*Next time context will launch ChangeModeSettings */
            button.State = new ChangeModeSettings();
        }
    }
    //ConcreteState
    class ChangeModeSettings : IButtonState
    {
        public void ChangeMod(Button button)
        {
            Console.WriteLine("Mode changed to movie mode to standart mode .");
            /*Next time context will launch CloseButtonState */
            button.State = new CloseButtonState();
        }
    }
    //ConcreteState
    class CloseButtonState : IButtonState
    {
        public void ChangeMod(Button button)
        {
            Console.WriteLine("Mode changing is closed");
            /*Next time context will launch OpenButtonState */
            button.State = new OpenButtonState();
        }
    }
    //Context
    class Button
    {
        public Button()
        {          
            State = new OpenButtonState();
        }
        private IButtonState _State { get; set; }
        public IButtonState State
        {
            get { return _State; }
            set
            {
                _State = value;
                /*ChangeMod function will launch in here.*/
            }
        }
        public void Do()
        {
            State.ChangeMod(this);
        }
    }
}
