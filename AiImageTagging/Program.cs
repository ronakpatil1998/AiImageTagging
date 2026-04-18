using AiImageTagging;
using System.IO;

string sourceFolder = @"D:\Photos\Unsorted";
string destinationFolder = @"D:\Photos\Sorted";

var images = Directory.GetFiles(sourceFolder, "*.*", SearchOption.AllDirectories)
    .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                   file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                   file.EndsWith(".png", StringComparison.OrdinalIgnoreCase));

foreach (var imagePath in images)
{
    var image = new ImageClassifier.ModelInput()
    {
        ImageSource = File.ReadAllBytes(imagePath)
    };

    var result = ImageClassifier.Predict(image);
    string predoctedTag = result.PredictedLabel;

    string TagFolder = Path.Combine(destinationFolder, predoctedTag);
    Directory.CreateDirectory(TagFolder);

    string fileName = Path.GetFileName(imagePath);
    File.Move(imagePath, Path.Combine(TagFolder, fileName));

    Console.WriteLine($"Moved '{fileName}' to '{TagFolder} ({result.Score.Max():P2}Confidence)'");
}