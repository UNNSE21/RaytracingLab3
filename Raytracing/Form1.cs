using System;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Raytracing
{
    public partial class MainForm : Form
    {
        private readonly View _view;
        private bool _isLoaded;
        private Vector3 _selectedColor;

        public MainForm(View view)
        {
            InitializeComponent();
            _view = view;
            _isLoaded = false;
            _selectedColor = new Vector3(0.7f, 0.5f, 0.9f);
            _materialTypeComboBox.SelectedIndex = 1;
            _depthTrackBar.Maximum = 1;
            _depthTrackBar.Maximum = 20;
            _depthTrackBar.Value = _view.RTDepth;
            _cfTrackBar.Minimum = 1;
            _cfTrackBar.Maximum = 500;
            _rcfTrackBar.Minimum = 100;
            _rcfTrackBar.Maximum = 500;
            Text = "Fuck The World!";
        }

        private void OnGlControlPaint(object sender, PaintEventArgs e)
        {
            if (_isLoaded)
            {
                _view.DrawNewFrame();
                _glControl.SwapBuffers();
                GL.UseProgram(0);
            }
        }

        private void OnGlControlLoad(object sender, EventArgs e)
        {
            _isLoaded = true;
            _view.InitShaders();
            _view.InitVBO();
        }

        private void OnMainFormLoad(object sender, EventArgs e)
        {
            Application.Idle += OnApplicationIdle;
        }

        private void OnApplicationIdle(object sender, EventArgs e)
        {
            while (_glControl.IsIdle)
                _glControl.Invalidate();
        }

        private void OnMainFormSizeChanged(object sender, EventArgs e)
        {
            _glControl.Update();
        }

        private void OnGlControlSizeChanged(object sender, EventArgs e)
        {
            _glControl.Update();
        }

        private void OnCubeVisibilityChanged(object sender, EventArgs e)
        {
            if (_cubeVisibility.Checked)
                _view.CubeData.Show();
            else
                _view.CubeData.Hide();
        }

        private void OnTetrVisibilityChanged(object sender, EventArgs e)
        {
            if (_tetrVisibility.Checked)
                _view.TetrData.Show();
            else
                _view.TetrData.Hide();
        }

        private void OnBigSphereVisibilityChanged(object sender, EventArgs e)
        {
            if (_bigSphereVisibility.Checked)
                _view.BigSphereData.Show();
            else
                _view.BigSphereData.Hide();
        }

        private void OnSmallSphereVisibilityChanged(object sender, EventArgs e)
        {
            if (_smallSphereVisibility.Checked)
                _view.SmallSphereData.Show();
            else
                _view.SmallSphereData.Hide();
        }

        private void OnAcceptButtonClick(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedColor.X = _colorDialog.Color.R / 255.0f;
                _selectedColor.Y = _colorDialog.Color.G / 255.0f;
                _selectedColor.Z = _colorDialog.Color.B / 255.0f;
            }

            if (_materialIDComboBox.SelectedIndex != -1)
                _view.FigureDatas[_materialIDComboBox.SelectedIndex].ColorData.Value = _selectedColor;
        }

        private void OnMaterialIDComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _materialTypeComboBox.SelectedIndex = _view.FigureDatas[_materialIDComboBox.SelectedIndex].MaterialID.Value - 1;
            _cfTrackBar.Value = _view.FigureDatas[_materialIDComboBox.SelectedIndex].Cf.Value;
            _rcfTrackBar.Value = _view.FigureDatas[_materialIDComboBox.SelectedIndex].RCf.Value;
        }

        private void OnMaterialTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_materialIDComboBox.SelectedIndex != -1)
                _view.FigureDatas[_materialIDComboBox.SelectedIndex].MaterialID.Value = _materialIDComboBox.SelectedIndex;
        }

        private void OnDepthTrackScroll(object sender, EventArgs e)
        {
            _view.RTDepth = _depthTrackBar.Value;
        }

        private void OnCfTrackBarScroll(object sender, EventArgs e)
        {
            if (_materialIDComboBox.SelectedIndex != -1)
                _view.FigureDatas[_materialIDComboBox.SelectedIndex].Cf.Value = _cfTrackBar.Value;
        }

        private void OnRCfTrackBarScroll(object sender, EventArgs e)
        {
            if (_materialIDComboBox.SelectedIndex != -1)
                _view.FigureDatas[_materialIDComboBox.SelectedIndex].RCf.Value = _rcfTrackBar.Value;
        }
    }
}
