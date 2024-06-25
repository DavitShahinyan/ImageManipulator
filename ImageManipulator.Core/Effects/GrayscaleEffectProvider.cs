using ImageManipulator.Core.Abstraction.Classes;
using ImageManipulator.Core.Descriptor;
using System;

namespace ImageManipulator.Core.Effects
{
    public class GrayscaleEffectProvider : ImageEffectProviderBase
    {
        public override string Name => Constants.GrayscaleEffectProviderName;

        protected override void WriteProcessingMessage(string path)
        {
            Console.WriteLine($"Applying grayscale to image: {path}.\n");
        }
    }
}
