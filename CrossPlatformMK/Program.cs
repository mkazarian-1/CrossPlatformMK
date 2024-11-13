using CrossPlatformMK.Service;

namespace CrossPlatformMK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CrossPlatformTask firstLab = new CrossPlatformTask();

            string inputPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\input.txt"));
            string outputPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Resources\output.txt"));
            
            firstLab.RunLab(inputPath, outputPath);
        }
    }
}