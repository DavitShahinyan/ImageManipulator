namespace ImageManipulator.Core.Models
{
    public class EffectParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public EffectParameter() { }
        public EffectParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}
