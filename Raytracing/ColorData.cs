using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Raytracing
{
    public sealed class ColorData : ShaderData<Vector3>
    {
        public ColorData(string name, Vector3 value) : base(name, value) { }

        public void ChangeValue(Vector3 newValue)
            => Value = newValue;

        public override void UpdateUniform(int id)
        {
            Vector3 vector3 = Value;
            GL.Uniform3(GL.GetUniformLocation(id, Name), ref vector3);
            Value = vector3;
        }
    }
}
