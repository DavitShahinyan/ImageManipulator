namespace ImageManipulator.Core.Descriptor
{
    public static class Constants
    {
        public const string ResizeEffectProviderName = "Resize Effect";
        public const string RadiusEffectProviderName = "Radius Effect";
        public const string GrayscaleEffectProviderName = "Grayscale Effect";
        public const string BlurEffectProviderName = "Blur Effect";

        public const string EffectCannotBeAdded = "Effect '{0}' cannot be added to the '{1}' image because it has incorrect parameter!";
    }
}
