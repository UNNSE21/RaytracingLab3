using OpenTK.Graphics.OpenGL;

namespace Raytracing
{
    public sealed class FigureData : ShaderData<int>
    {
        public ColorData ColorData { get; private set; }
        public FigureCoefficentData RCf { get; private set; }
        public FigureCoefficentData Cf { get; private set; }
        public FigureCoefficentData MaterialID { get; private set; }

        public FigureData(
            string name,
            int value,
            ColorData colorData,
            FigureCoefficentData rcf,
            FigureCoefficentData cf,
            FigureCoefficentData materialID
            ) : base(name, value)
        {
            ColorData = colorData;
            RCf = rcf;
            Cf = cf;
            MaterialID = materialID;
        }

        public FigureData(string name, int value) : base(name, value) { }

        public void Show()
            => Value = 1;

        public void Hide()
            => Value = 0;

        public override void UpdateUniform(int id)
        {
            GL.Uniform1(GL.GetUniformLocation(id, Name), Value);
            ColorData.UpdateUniform(id);
            RCf.UpdateUniform(id);
            Cf.UpdateUniform(id);
            MaterialID.UpdateUniform(id);
        }
    }
}
