using ImageManipulator.Core.Models;

namespace ImageManipulator.Core.Abstraction.Interfaces
{
    public interface IImageEffect
    {
        string Name { get; }
        void Apply(string path);
        EffectParameter EffectParameter { get; }
    }
}
