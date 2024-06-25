using ImageManipulator.Core.Abstraction.Interfaces;
using ImageManipulator.Core.Descriptor;
using System;
using System.Collections.Generic;

namespace ImageManipulator.Core.Processing
{
    public class PluginManager
    {
        private Dictionary<string, List<IImageEffect>> _imagesWithEffects;

        public PluginManager()
        {
            _imagesWithEffects = new Dictionary<string, List<IImageEffect>>();
        }

        public PluginManager AddEffect(string path, IImageEffect effect)
        {
            if (HasIncorrectParameter(effect))
            {
                Console.WriteLine(string.Format(Constants.EffectCannotBeAdded, effect.Name, path) + Environment.NewLine);
                return this;
            }
            if (!_imagesWithEffects.ContainsKey(path))
            {
                _imagesWithEffects[path] = new List<IImageEffect>();
            }
            if (!_imagesWithEffects[path].Contains(effect))
            {
                _imagesWithEffects[path].Add(effect);
            }
            return this;
        }

        public void RemoveEffect(string imagePath, IImageEffect effect)
        {
            if (_imagesWithEffects.ContainsKey(imagePath))
            {
                _imagesWithEffects[imagePath].Remove(effect);
            }
        }

        public void Process()
        {
            if(_imagesWithEffects.Count > 0)
            {
                foreach (var imagePath in _imagesWithEffects.Keys)
                {
                    if (_imagesWithEffects.ContainsKey(imagePath))
                    {
                        Console.WriteLine($"----Processing of the '{imagePath}' image is started.----\n");
                        foreach (var effect in _imagesWithEffects[imagePath])
                        {
                            effect.Apply(imagePath);
                        }
                        Console.WriteLine($"----Processing of the '{imagePath}' image is completed.----\n");
                    }
                }
            }
        }

        private bool HasIncorrectParameter(IImageEffect effect)
        {
            return
                effect.EffectParameter != null && (
                string.IsNullOrWhiteSpace(effect.EffectParameter.Name) ||
                effect.EffectParameter.Value == null);
        }
    }
}
