using CommandDotNet.Attributes;

namespace Arrays
{
    public class App
    {
        [SubCommand]
        public Algorithms.Arrays Arrays { get; set; }
    }
}