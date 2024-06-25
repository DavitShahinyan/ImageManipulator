using ImageManipulator.Core.Abstraction.Interfaces;
using ImageManipulator.Core.Models;
using System;

namespace ImageManipulator.Core.Abstraction.Classes
{
    public abstract class ImageEffectProviderBase : IImageEffect
    {
        public abstract string Name { get; }

        protected abstract void WriteProcessingMessage(string path);

        private EffectParameter _effectParameter;

        public EffectParameter EffectParameter
        {
            get { return _effectParameter; }
            private set { _effectParameter = value; }
        }

        public void SetEffectParameter(string name, object value)
        {
            _effectParameter = new EffectParameter { Name = name, Value = value };
        }
        public virtual void Apply(string path)
        {
            if(EffectParameter != null)
            {
                WriteDetails();
            }
            WriteProcessingMessage(path);
        }
        public void WriteDetails()
        {
            Console.WriteLine($"---{Name}---\nDetails:\n{EffectParameter.Name} = {EffectParameter.Value}.");
        }
    }
}
