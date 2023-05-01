namespace Raytracing
{
    public class ShaderData<T>
    {
        public string Name { get; protected set; }
        public T Value { get; set; }

        public ShaderData(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public virtual void UpdateUniform(int id) { }
    }
}
