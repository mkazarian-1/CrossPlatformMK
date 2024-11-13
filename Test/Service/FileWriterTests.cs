using CrossPlatformMK.Service;

namespace Test.Service
{
    public class FileWriterTests
    {
        [Fact]
        public void WriteResult_ValidPath_WritesToFile()
        {
            var fileWriter = new FileWriter();
            var outputFilePath = "testOutput.txt";
            var outputContent = "This is a test result.";

            fileWriter.WriteResult(outputFilePath, outputContent);

            Assert.True(File.Exists(outputFilePath), "File was not created.");
            var fileContent = File.ReadAllText(outputFilePath);
            Assert.Equal(outputContent, fileContent);

            File.Delete(outputFilePath);
        }
    }
}
