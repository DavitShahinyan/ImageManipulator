using ImageManipulator.Core.Abstraction.Classes;
using ImageManipulator.Core.Descriptor;
using System;

namespace ImageManipulator.Core.Effects
{
    public class RadiusEffectProvider : ImageEffectProviderBase
    {
        public override string Name => Constants.RadiusEffectProviderName;

        protected override void WriteProcessingMessage(string path)
        {
            Console.WriteLine($"Applying radius effect to the image: {path}.\n");
        }
    }
}
