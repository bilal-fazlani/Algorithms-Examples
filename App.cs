using CommandDotNet.Attributes;

namespace Arrays
{
    public class App
    {
        [SubCommand]
        public Arrays Arrays { get; set; }
    }
}