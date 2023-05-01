using OpenTK.Graphics.OpenGL;

namespace Raytracing
{
    public sealed class FigureCoefficentData : ShaderData<int>
    {
        public FigureCoefficentData(string name, int value) : base(name, value) { }

        public void ChangeValue(int newValue)
            => Value = newValue;

        public override void UpdateUniform(int id)
            => GL.Uniform1(GL.GetUniformLocation(id, Name), Value);
    }
}
