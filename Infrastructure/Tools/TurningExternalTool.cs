namespace WASM_PWA.Crashtest.Infrastructure.Tools
{
    public class TurningExternalTool : Tool
    {
        public enum Types { Face, Bar }

        public Types Type { get; set; }
        public double Radius { get; set; }
        public double Angle { get; set; }
        public override string Name => Type == Types.Face ? "TORC" : "PROHOD";

        public TurningExternalTool(int position, Types type, double angle, double radius, ToolHand hand = ToolHand.Rigth)
        {
            Position = position;
            Type = type;
            Radius = radius;
            Angle = angle;
            Hand = hand;
        }
    }
}
