namespace WASM_PWA.Crashtest.Infrastructure.Tools
{
    public class DrillingTool : Tool
    {
        public enum Types { Insert, Solid, Tip, Center, HSS }

        private Types _Type;
        public Types Type { get => _Type; set 
            {
                _Type = value;
                switch (_Type)
                {
                    case Types.Insert:
                        Angle = 180;
                        break;
                    case Types.Solid:
                        Angle = 140;
                        break;
                    case Types.Tip:
                        Angle = 142;
                        break;
                    case Types.Center:
                        Angle = 120;
                        break;
                    case Types.HSS:
                        Angle = 118;
                        break;
                    default:
                        break;
                }
            } }
        public double Diameter { get; set; }
        public double Angle { get; set; }
        public override string Name
        {
            get => Type switch
            {
                Types.Insert => "SV KORP",
                Types.Solid => "SV TV",
                Types.Tip => "SV GOLOVKA",
                Types.Center => "CENTR",
                Types.HSS => "SV HSS",
                _ => string.Empty,
            };
        }

        public DrillingTool(int position, Types type, double diameter, double angle, ToolHand hand = ToolHand.Rigth)
        {
            Position = position;
            Type = type;
            Diameter = diameter;
            Angle = angle;
            Hand = hand;
        }
    }
}
