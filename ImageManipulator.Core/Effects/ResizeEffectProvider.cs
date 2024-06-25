using ImageManipulator.Core.Abstraction.Classes;
using ImageManipulator.Core.Descriptor;
using System;

namespace ImageManipulator.Core.Effects
{
    public class ResizeEffectProvider : ImageEffectProviderBase
    {
        public override string Name => Constants.ResizeEffectProviderName;

        protected override void WriteProcessingMessage(string path)
        {
            Console.WriteLine($"Resizing the image: {path}.\n");
        }
    }
}
