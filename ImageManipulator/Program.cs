using ImageManipulator.Core.Effects;
using ImageManipulator.Core.Processing;
using System;

namespace ImageManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string image1Path = "testImage1Path.jpg";
            string image2Path = "testImage2Path.jpg";

            PluginManager pluginManager = new PluginManager();

            var blurEffect = new BlurEffectProvider();

            blurEffect.SetEffectParameter("Pixels", 50);
            pluginManager.AddEffect(image1Path, blurEffect);

            var resizeEffect = new ResizeEffectProvider();
            resizeEffect.SetEffectParameter("Pixels", 100);
            pluginManager.AddEffect(image1Path, resizeEffect);

            var grayscaleEffect = new GrayscaleEffectProvider();
            pluginManager.AddEffect(image1Path, grayscaleEffect);

            var radiusEffect = new RadiusEffectProvider();
            radiusEffect.SetEffectParameter("Percentage", 30);
            pluginManager.AddEffect(image1Path, radiusEffect);

            pluginManager
                .AddEffect(image1Path, blurEffect)
                .AddEffect(image1Path, resizeEffect)
                .AddEffect(image1Path, grayscaleEffect)
                .AddEffect(image1Path, radiusEffect);

            radiusEffect.SetEffectParameter("Pixels", 200);
            blurEffect.SetEffectParameter("", 100);
            pluginManager
                .AddEffect(image2Path, radiusEffect)
                .AddEffect(image2Path, grayscaleEffect)
                .AddEffect(image2Path, blurEffect);

            pluginManager.Process();

            Console.WriteLine("Processing completed.");
            Console.ReadLine();
        }
    }
}
