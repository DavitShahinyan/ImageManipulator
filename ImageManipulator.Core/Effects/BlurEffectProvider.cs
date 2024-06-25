using ImageManipulator.Core.Abstraction.Classes;
using ImageManipulator.Core.Descriptor;
using System;

namespace ImageManipulator.Core.Effects
{
    public class BlurEffectProvider : ImageEffectProviderBase
    {
        public override string Name => Constants.BlurEffectProviderName;

        protected override void WriteProcessingMessage(string path)
        {
            Console.WriteLine($"Applying blur effect to the image: {path}.\n");
        }
    }
}
