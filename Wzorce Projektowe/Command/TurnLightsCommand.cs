using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Command
{
    internal class TurnLightsCommand : Command
    {
        public TurnLightsCommand(Receiver r, Invoker i) : base(r, i) { }

        public override void Execute()
        {
            r.SetLights(i.GetLights());
        }
    }
}
