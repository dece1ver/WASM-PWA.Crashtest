using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WASM_PWA.Crashtest.Infrastructure.Tools
{
    public class ThreadingInternalTool : Tool
    {
        public double Diameter { get; set; }
        public double Pitch { get; set; }
        public double Angle { get; set; }
        public override string Name => "REZBA";

        public ThreadingInternalTool(int position, double diameter, double pitch, double angle, ToolHand hand = ToolHand.Rigth)
        {
            Position = position;
            Diameter = diameter;
            Pitch = pitch;
            Angle = angle;
            Hand = hand;
        }
    }
}
