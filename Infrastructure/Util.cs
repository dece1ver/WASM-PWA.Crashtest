using WASM_PWA.Crashtest.Infrastructure.Tools;
using System.Globalization;

namespace WASM_PWA.Crashtest.Infrastructure
{
    public static class Util
    {
        public static string ToolNumber(this int value)
        {
            return value.ToString($"D{4}");
        }

        public static string NC(this double value, int precision = 3)
        {
            return value.ToString($"F{precision}", CultureInfo.InvariantCulture).Contains('.')
                ? value.ToString($"F{precision}", CultureInfo.InvariantCulture).TrimEnd('0')
                : value.ToString($"F{precision}");
        }

        public static double Radians(this double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static double Radians(this int degrees)
        {
            return degrees * Math.PI / 180;
        }

        public static double Degrees(this double radians)
        {
            return radians * 180 / Math.PI;
        }

        public enum ToolDescriptionOption { General, L230, GoodwayLeft, GoodwayRight }
        public static string Description(this Tool tool, ToolDescriptionOption option = ToolDescriptionOption.General)
        {
            return tool switch
            {
                SpecialTool specialTool => option switch
                {
                    ToolDescriptionOption.General => $"T{specialTool.Position.ToolNumber()} ({specialTool.Name})".Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{specialTool.Position.ToolNumber()}({specialTool.Name})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{specialTool.Position.ToolNumber()}G54M58({specialTool.Name})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{specialTool.Position.ToolNumber()}G55M58({specialTool.Name})".Replace(',', '.'),
                    _ => string.Empty,
                },
                TurningExternalTool turningExternalTool => option switch
                {
                    ToolDescriptionOption.General => $"T{turningExternalTool.Position.ToolNumber()} ({turningExternalTool.Name} {turningExternalTool.Angle} R{turningExternalTool.Radius})".Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{turningExternalTool.Position.ToolNumber()}({turningExternalTool.Name} {turningExternalTool.Angle} R{turningExternalTool.Radius})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{turningExternalTool.Position.ToolNumber()}G54M58({turningExternalTool.Name} {turningExternalTool.Angle} R{turningExternalTool.Radius})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{turningExternalTool.Position.ToolNumber()}G55M58({turningExternalTool.Name} {turningExternalTool.Angle} R{turningExternalTool.Radius})".Replace(',', '.'),
                    _ => string.Empty,
                },
                TurningInternalTool turningInternalTool => option switch
                {
                    ToolDescriptionOption.General => $"T{turningInternalTool.Position.ToolNumber()} ({turningInternalTool.Name} D{turningInternalTool.Diameter} {turningInternalTool.Angle} R{turningInternalTool.Radius})".Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{turningInternalTool.Position.ToolNumber()}({turningInternalTool.Name} D{turningInternalTool.Diameter} {turningInternalTool.Angle} R{turningInternalTool.Radius})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{turningInternalTool.Position.ToolNumber()}G54M58({turningInternalTool.Name} D{turningInternalTool.Diameter} {turningInternalTool.Angle} R{turningInternalTool.Radius})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{turningInternalTool.Position.ToolNumber()}G55M58({turningInternalTool.Name} D{turningInternalTool.Diameter} {turningInternalTool.Angle} R{turningInternalTool.Radius})".Replace(',', '.'),
                    _ => string.Empty,
                },
                DrillingTool drillingTool => option switch
                {
                    ToolDescriptionOption.General => $"T{drillingTool.Position.ToolNumber()} ({drillingTool.Name} D{drillingTool.Diameter})".Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{drillingTool.Position.ToolNumber()}({drillingTool.Name} D{drillingTool.Diameter})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{drillingTool.Position.ToolNumber()}G54M58({drillingTool.Name} D{drillingTool.Diameter})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{drillingTool.Position.ToolNumber()}G55M58({drillingTool.Name} D{drillingTool.Diameter})".Replace(',', '.'),
                    _ => string.Empty,
                },
                TappingTool tappingTool => option switch
                {
                    ToolDescriptionOption.General => $"T{tappingTool.Position.ToolNumber()} ({tappingTool.Name} M{tappingTool.Diameter}x{tappingTool.Pitch})".Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{tappingTool.Position.ToolNumber()}({tappingTool.Name} M{tappingTool.Diameter}x{tappingTool.Pitch})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{tappingTool.Position.ToolNumber()}G54M58({tappingTool.Name} M{tappingTool.Diameter}x{tappingTool.Pitch})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{tappingTool.Position.ToolNumber()}G55M58({tappingTool.Name} M{tappingTool.Diameter}x{tappingTool.Pitch})".Replace(',', '.'),
                    _ => string.Empty,
                },
                ThreadingExternalTool threadingExternalTool => option switch
                {
                    ToolDescriptionOption.General => $"T{threadingExternalTool.Position.ToolNumber()} ({threadingExternalTool.Name} {threadingExternalTool.Pitch} {threadingExternalTool.Angle})".Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{threadingExternalTool.Position.ToolNumber()}({threadingExternalTool.Name} {threadingExternalTool.Pitch} {threadingExternalTool.Angle})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{threadingExternalTool.Position.ToolNumber()}G54M58({threadingExternalTool.Name} {threadingExternalTool.Pitch} {threadingExternalTool.Angle})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{threadingExternalTool.Position.ToolNumber()}G55M58({threadingExternalTool.Name} {threadingExternalTool.Pitch} {threadingExternalTool.Angle})".Replace(',', '.'),
                    _ => string.Empty,
                },
                ThreadingInternalTool threadingInternalTool => option switch
                {
                    ToolDescriptionOption.General => $"T{threadingInternalTool.Position.ToolNumber()} ({threadingInternalTool.Name} D{threadingInternalTool.Diameter} {threadingInternalTool.Pitch} {threadingInternalTool.Angle})".Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{threadingInternalTool.Position.ToolNumber()}({threadingInternalTool.Name} D{threadingInternalTool.Diameter} {threadingInternalTool.Pitch} {threadingInternalTool.Angle})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{threadingInternalTool.Position.ToolNumber()}G54M58({threadingInternalTool.Name} D{threadingInternalTool.Diameter} {threadingInternalTool.Pitch} {threadingInternalTool.Angle})".Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{threadingInternalTool.Position.ToolNumber()}G55M58({threadingInternalTool.Name} D{threadingInternalTool.Diameter} {threadingInternalTool.Pitch} {threadingInternalTool.Angle})".Replace(',', '.'),
                    _ => string.Empty,
                },
                GroovingExternalTool groovingExternalTool => option switch
                {
                    ToolDescriptionOption.General => $"T{groovingExternalTool.Position.ToolNumber()} ({groovingExternalTool.Name} {groovingExternalTool.Width}MM {(groovingExternalTool.ZeroPoint == GroovingExternalTool.Point.Left ? "KAK PROHOD" : "KAK OTR")})"
                    .Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{groovingExternalTool.Position.ToolNumber()}({groovingExternalTool.Name} {groovingExternalTool.Width}MM {(groovingExternalTool.ZeroPoint == GroovingExternalTool.Point.Left ? "KAK PROHOD" : "KAK OTR")})"
                    .Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{groovingExternalTool.Position.ToolNumber()}G54M58({groovingExternalTool.Name} {groovingExternalTool.Width}MM {(groovingExternalTool.ZeroPoint == GroovingExternalTool.Point.Left ? "KAK PROHOD" : "KAK OTR")})"
                    .Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{groovingExternalTool.Position.ToolNumber()}G55M58({groovingExternalTool.Name} {groovingExternalTool.Width}MM {(groovingExternalTool.ZeroPoint == GroovingExternalTool.Point.Left ? "KAK PROHOD" : "KAK OTR")})"
                    .Replace(',', '.'),
                    _ => string.Empty,
                },
                GroovingInternalTool groovingInternalTool => option switch
                {
                    ToolDescriptionOption.General => $"T{groovingInternalTool.Position.ToolNumber()} ({groovingInternalTool.Name} {groovingInternalTool.Width}MM {(groovingInternalTool.ZeroPoint == GroovingInternalTool.Point.Left ? "KAK PROHOD" : "KAK OTR")})"
                    .Replace(',', '.'),
                    ToolDescriptionOption.L230 => $"T{groovingInternalTool.Position.ToolNumber()}({groovingInternalTool.Name} {groovingInternalTool.Width}MM {(groovingInternalTool.ZeroPoint == GroovingInternalTool.Point.Left ? "KAK PROHOD" : "KAK OTR")})"
                    .Replace(',', '.'),
                    ToolDescriptionOption.GoodwayLeft => $"T{groovingInternalTool.Position.ToolNumber()}G54M58({groovingInternalTool.Name} {groovingInternalTool.Width}MM {(groovingInternalTool.ZeroPoint == GroovingInternalTool.Point.Left ? "KAK PROHOD" : "KAK OTR")})"
                    .Replace(',', '.'),
                    ToolDescriptionOption.GoodwayRight => $"T{groovingInternalTool.Position.ToolNumber()}G55M58({groovingInternalTool.Name} {groovingInternalTool.Width}MM {(groovingInternalTool.ZeroPoint == GroovingInternalTool.Point.Left ? "KAK PROHOD" : "KAK OTR")})"
                    .Replace(',', '.'),
                    _ => string.Empty,
                },
                _ => string.Empty,
            };
            ;
        }
    }
}