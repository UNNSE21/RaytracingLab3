using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.IO;

namespace Raytracing
{
    public class View
    {
        private const int StandartMaterial = 2;
        private const int StandartCf = 100;
        private const int StandartRCf = 130;

        private Vector3 _standartColor = new Vector3(0.8f, 0.7f, 0.6f);

        private int _vbo;
        private int _basicProgramID;
        private Vector3 _campos;
        private int _rTDepth;

        private readonly int _attributeVpos;
        private readonly int _uniformPos;
        private readonly int _uniformAspect;
        private readonly int _spect;

        public readonly FigureData BigSphereData;
        public readonly FigureData SmallSphereData;
        public readonly FigureData CubeData;
        public readonly FigureData TetrData;
        public readonly FigureData BackWallData;
        public readonly FigureData FrontWallData;
        public readonly FigureData LeftWallData;
        public readonly FigureData RightWallData;
        public readonly FigureData TopWallData;
        public readonly FigureData BottomWallData;

        public List<FigureData> FigureDatas = new List<FigureData>();

        public int RTDepth { get => _rTDepth; set => _rTDepth = Math.Max(0, value); }

        public View()
        {
            _vbo = 0;
            _basicProgramID = 0;
            _campos = new Vector3(0, 0, 0);
            _attributeVpos = 0;
            _uniformPos = 0;
            _uniformAspect = 0;
            _spect = 0;
            RTDepth = 6;

            CubeData = new FigureData
                (
                    name: "ucube",
                    value: 0,
                    new ColorData("ColCube", new Vector3(0.5f, 1.0f, 1.0f)),
                    new FigureCoefficentData("cubeRCf", StandartRCf),
                    new FigureCoefficentData("cubeCf", StandartCf),
                    new FigureCoefficentData("Cube", StandartMaterial)
                );
            FigureDatas.Add(CubeData);

            TetrData = new FigureData
                (
                    name: "utetr",
                    value: 0,
                    new ColorData("ColTetr", new Vector3(1.0f, 0.5f, 1.0f)),
                    new FigureCoefficentData("tetrRCf", StandartRCf),
                    new FigureCoefficentData("tetrCf", StandartCf),
                    new FigureCoefficentData("Tetr", StandartMaterial)
                );
            FigureDatas.Add(TetrData);

            BigSphereData = new FigureData
                (
                    name: "ubigs",
                    value: 0,
                    new ColorData("ColBigSphere", new Vector3(1.0f, 1.0f, 0.0f)),
                    new FigureCoefficentData("bigRCf", StandartRCf),
                    new FigureCoefficentData("bigCf", StandartCf),
                    new FigureCoefficentData("BigSphere", StandartMaterial)
                );
            FigureDatas.Add(BigSphereData);

            SmallSphereData = new FigureData
                (
                    name: "usmalls",
                    value: 0,
                    new ColorData("ColSmallSphere", new Vector3(0.0f, 1.0f, 0.0f)),
                    new FigureCoefficentData("smallRCf", StandartRCf),
                    new FigureCoefficentData("smallCf", StandartCf),
                    new FigureCoefficentData("SmallSphere", StandartMaterial)
                );
            FigureDatas.Add(SmallSphereData);

            BackWallData = new FigureData
                (
                    name: "Back",
                    value: 1,
                    new ColorData("ColBack", _standartColor),
                    new FigureCoefficentData("wallRCf", StandartRCf),
                    new FigureCoefficentData("wallCf", StandartCf),
                    new FigureCoefficentData("Back", StandartMaterial)
                );
            FigureDatas.Add(BackWallData);

            LeftWallData = new FigureData
                (
                    name: "Left",
                    value: 1,
                    new ColorData("ColLeft", _standartColor),
                    new FigureCoefficentData("wallRCf", StandartRCf),
                    new FigureCoefficentData("wallCf", StandartCf),
                    new FigureCoefficentData("Left", StandartMaterial)
                );
            FigureDatas.Add(LeftWallData);

            RightWallData = new FigureData
                (
                    name: "Right",
                    value: 1,
                    new ColorData("ColRight", _standartColor),
                    new FigureCoefficentData("wallRCf", StandartRCf),
                    new FigureCoefficentData("wallCf", StandartCf),
                    new FigureCoefficentData("Right", StandartMaterial)
                );
            FigureDatas.Add(RightWallData);

            FrontWallData = new FigureData
                (
                    name: "Front",
                    value: 1,
                    new ColorData("ColFront", _standartColor),
                    new FigureCoefficentData("wallRCf", StandartRCf),
                    new FigureCoefficentData("wallCf", StandartCf),
                    new FigureCoefficentData("Front", StandartMaterial)
                );
            FigureDatas.Add(FrontWallData);

            TopWallData = new FigureData
                (
                    name: "Top",
                    value: 1,
                    new ColorData("ColTop", _standartColor),
                    new FigureCoefficentData("wallRCf", StandartRCf),
                    new FigureCoefficentData("wallCf", StandartCf),
                    new FigureCoefficentData("Top", StandartMaterial)
                );
            FigureDatas.Add(TopWallData);

            BottomWallData = new FigureData
                (
                    name: "Bot",
                    value: 1,
                    new ColorData("ColBot", _standartColor),
                    new FigureCoefficentData("wallRCf", StandartRCf),
                    new FigureCoefficentData("wallCf", StandartCf),
                    new FigureCoefficentData("Bot", StandartMaterial)
                );
            FigureDatas.Add(BottomWallData);
        }

        public void DrawNewFrame()
        {
            GL.UseProgram(_basicProgramID);

            foreach (FigureData figure in FigureDatas)
                figure.UpdateUniform(_basicProgramID);

            GL.Uniform1(GL.GetUniformLocation(_basicProgramID, "RTDepth"), RTDepth);

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.Texture2D);
            GL.EnableVertexAttribArray(_attributeVpos);
            GL.DrawArrays(PrimitiveType.Quads, 0, 4);
            GL.DisableVertexAttribArray(_attributeVpos);
        }

        public void InitShaders()
        {
            _basicProgramID = GL.CreateProgram();
            LoadShader("..\\..\\raytracing.vert", ShaderType.VertexShader, _basicProgramID);
            LoadShader("..\\..\\raytracing.frag", ShaderType.FragmentShader, _basicProgramID);

            GL.LinkProgram(_basicProgramID);
            GL.GetProgram(_basicProgramID, GetProgramParameterName.LinkStatus, out _);

            Console.WriteLine(GL.GetProgramInfoLog(_basicProgramID));
        }

        private void LoadShader(string filename, ShaderType type, int program)
        {
            int address = GL.CreateShader(type);

            using (StreamReader sr = new StreamReader(filename))
                GL.ShaderSource(address, sr.ReadToEnd());

            GL.CompileShader(address);
            GL.AttachShader(program, address);

            Console.WriteLine(GL.GetShaderInfoLog(address));
        }

        public void InitVBO()
        {
            Vector3[] vertdata = new Vector3[]
            {
                new Vector3(-1f, -1f, 0f),
                new Vector3( 1f, -1f, 0f),
                new Vector3( 1f,  1f, 0f),
                new Vector3(-1f,  1f, 0f),
            };

            GL.GenBuffers(1, out _vbo);
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vbo);

            GL.BufferData(
                BufferTarget.ArrayBuffer,
                (IntPtr)(vertdata.Length * Vector3.SizeInBytes),
                vertdata, BufferUsageHint.StaticDraw
                );

            GL.VertexAttribPointer(_attributeVpos, 3, VertexAttribPointerType.Float, false, 0, 0);

            GL.Uniform3(_uniformPos, _campos);
            GL.Uniform1(_uniformAspect, _spect);

            GL.UseProgram(_basicProgramID);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
        }
    }
}
