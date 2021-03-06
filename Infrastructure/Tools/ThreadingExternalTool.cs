namespace WASM_PWA.Crashtest.Infrastructure.Tools
{
    public class ThreadingExternalTool : Tool
    {
        public double Pitch { get; set; }
        public double Angle { get; set; }

        public ThreadingExternalTool(int position, double pitch, double angle, ToolHand hand = ToolHand.Rigth)
        {
            Position = position;
            Name = "REZBA";
            Pitch = pitch;
            Angle = angle;
            Hand = hand;
        }
    }
}
