using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Command
{
    internal class SetTemperatureCommand : Command
    {

        public SetTemperatureCommand(Receiver r, Invoker i) : base(r, i) { }

        public override void Execute()
        {
            r.SetTemperature(i.GetTemperature());
        }
    }
}
