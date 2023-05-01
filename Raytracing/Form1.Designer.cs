namespace Raytracing
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._glControl = new OpenTK.GLControl();
            this._cubeVisibility = new System.Windows.Forms.CheckBox();
            this._tetrVisibility = new System.Windows.Forms.CheckBox();
            this._bigSphereVisibility = new System.Windows.Forms.CheckBox();
            this._materialIDComboBox = new System.Windows.Forms.ComboBox();
            this._colorDialog = new System.Windows.Forms.ColorDialog();
            this._acceptButton = new System.Windows.Forms.Button();
            this._materialTypeComboBox = new System.Windows.Forms.ComboBox();
            this._smallSphereVisibility = new System.Windows.Forms.CheckBox();
            this._depthTrackBar = new System.Windows.Forms.TrackBar();
            this._cfTrackBar = new System.Windows.Forms.TrackBar();
            this._rcfTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._depthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cfTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._rcfTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // _glControl
            // 
            this._glControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._glControl.AutoSize = true;
            this._glControl.BackColor = System.Drawing.Color.Black;
            this._glControl.Location = new System.Drawing.Point(10, 11);
            this._glControl.Name = "_glControl";
            this._glControl.Size = new System.Drawing.Size(668, 526);
            this._glControl.TabIndex = 0;
            this._glControl.VSync = false;
            this._glControl.Load += new System.EventHandler(this.OnGlControlLoad);
            this._glControl.SizeChanged += new System.EventHandler(this.OnGlControlSizeChanged);
            this._glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.OnGlControlPaint);
            // 
            // _cubeVisibility
            // 
            this._cubeVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cubeVisibility.AutoSize = true;
            this._cubeVisibility.Location = new System.Drawing.Point(714, 489);
            this._cubeVisibility.Margin = new System.Windows.Forms.Padding(2);
            this._cubeVisibility.Name = "_cubeVisibility";
            this._cubeVisibility.Size = new System.Drawing.Size(44, 17);
            this._cubeVisibility.TabIndex = 4;
            this._cubeVisibility.Text = "Куб";
            this._cubeVisibility.UseVisualStyleBackColor = true;
            this._cubeVisibility.CheckedChanged += new System.EventHandler(this.OnCubeVisibilityChanged);
            // 
            // _tetrVisibility
            // 
            this._tetrVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tetrVisibility.AutoSize = true;
            this._tetrVisibility.Location = new System.Drawing.Point(714, 510);
            this._tetrVisibility.Margin = new System.Windows.Forms.Padding(2);
            this._tetrVisibility.Name = "_tetrVisibility";
            this._tetrVisibility.Size = new System.Drawing.Size(80, 17);
            this._tetrVisibility.TabIndex = 5;
            this._tetrVisibility.Text = "Тетраэдер";
            this._tetrVisibility.UseVisualStyleBackColor = true;
            this._tetrVisibility.CheckedChanged += new System.EventHandler(this.OnTetrVisibilityChanged);
            // 
            // _bigSphereVisibility
            // 
            this._bigSphereVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bigSphereVisibility.AutoSize = true;
            this._bigSphereVisibility.Location = new System.Drawing.Point(812, 489);
            this._bigSphereVisibility.Margin = new System.Windows.Forms.Padding(2);
            this._bigSphereVisibility.Name = "_bigSphereVisibility";
            this._bigSphereVisibility.Size = new System.Drawing.Size(106, 17);
            this._bigSphereVisibility.TabIndex = 6;
            this._bigSphereVisibility.Text = "Большая сфера";
            this._bigSphereVisibility.UseVisualStyleBackColor = true;
            this._bigSphereVisibility.CheckedChanged += new System.EventHandler(this.OnBigSphereVisibilityChanged);
            // 
            // _materialIDComboBox
            // 
            this._materialIDComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._materialIDComboBox.FormattingEnabled = true;
            this._materialIDComboBox.Items.AddRange(new object[] {
            "Куб",
            "Тетраэдер",
            "Большая сфера",
            "Маленькая сфера",
            "Стена сзади",
            "Стена слева",
            "Стена справаL",
            "Стена спереди",
            "Потолок",
            "Пол"});
            this._materialIDComboBox.Location = new System.Drawing.Point(693, 11);
            this._materialIDComboBox.Margin = new System.Windows.Forms.Padding(2);
            this._materialIDComboBox.Name = "_materialIDComboBox";
            this._materialIDComboBox.Size = new System.Drawing.Size(246, 21);
            this._materialIDComboBox.TabIndex = 7;
            this._materialIDComboBox.SelectedIndexChanged += new System.EventHandler(this.OnMaterialIDComboBoxSelectedIndexChanged);
            // 
            // _acceptButton
            // 
            this._acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._acceptButton.Location = new System.Drawing.Point(884, 121);
            this._acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this._acceptButton.Name = "_acceptButton";
            this._acceptButton.Size = new System.Drawing.Size(55, 41);
            this._acceptButton.TabIndex = 8;
            this._acceptButton.Text = "Цвет";
            this._acceptButton.UseVisualStyleBackColor = true;
            this._acceptButton.Click += new System.EventHandler(this.OnAcceptButtonClick);
            // 
            // _materialTypeComboBox
            // 
            this._materialTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._materialTypeComboBox.FormattingEnabled = true;
            this._materialTypeComboBox.Items.AddRange(new object[] {
            "Прозрачный",
            "Диффузный",
            "Зеркальный"});
            this._materialTypeComboBox.Location = new System.Drawing.Point(693, 121);
            this._materialTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this._materialTypeComboBox.Name = "_materialTypeComboBox";
            this._materialTypeComboBox.Size = new System.Drawing.Size(179, 21);
            this._materialTypeComboBox.TabIndex = 9;
            this._materialTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnMaterialTypeComboBoxSelectedIndexChanged);
            // 
            // _smallSphereVisibility
            // 
            this._smallSphereVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._smallSphereVisibility.AutoSize = true;
            this._smallSphereVisibility.Location = new System.Drawing.Point(812, 510);
            this._smallSphereVisibility.Margin = new System.Windows.Forms.Padding(2);
            this._smallSphereVisibility.Name = "_smallSphereVisibility";
            this._smallSphereVisibility.Size = new System.Drawing.Size(118, 17);
            this._smallSphereVisibility.TabIndex = 10;
            this._smallSphereVisibility.Text = "Маленькая сфера";
            this._smallSphereVisibility.UseVisualStyleBackColor = true;
            this._smallSphereVisibility.CheckedChanged += new System.EventHandler(this.OnSmallSphereVisibilityChanged);
            // 
            // _depthTrackBar
            // 
            this._depthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._depthTrackBar.Location = new System.Drawing.Point(750, 394);
            this._depthTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this._depthTrackBar.Name = "_depthTrackBar";
            this._depthTrackBar.Size = new System.Drawing.Size(140, 45);
            this._depthTrackBar.TabIndex = 11;
            this._depthTrackBar.Scroll += new System.EventHandler(this.OnDepthTrackScroll);
            // 
            // _cfTrackBar
            // 
            this._cfTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cfTrackBar.Location = new System.Drawing.Point(693, 248);
            this._cfTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this._cfTrackBar.Name = "_cfTrackBar";
            this._cfTrackBar.Size = new System.Drawing.Size(245, 45);
            this._cfTrackBar.TabIndex = 12;
            this._cfTrackBar.Scroll += new System.EventHandler(this.OnCfTrackBarScroll);
            // 
            // _rcfTrackBar
            // 
            this._rcfTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._rcfTrackBar.Location = new System.Drawing.Point(694, 297);
            this._rcfTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this._rcfTrackBar.Name = "_rcfTrackBar";
            this._rcfTrackBar.Size = new System.Drawing.Size(245, 45);
            this._rcfTrackBar.TabIndex = 13;
            this._rcfTrackBar.Scroll += new System.EventHandler(this.OnRCfTrackBarScroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Глубина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Зеркальная составляющая";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Прозрачность";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._rcfTrackBar);
            this.Controls.Add(this._cfTrackBar);
            this.Controls.Add(this._depthTrackBar);
            this.Controls.Add(this._smallSphereVisibility);
            this.Controls.Add(this._materialTypeComboBox);
            this.Controls.Add(this._acceptButton);
            this.Controls.Add(this._materialIDComboBox);
            this.Controls.Add(this._bigSphereVisibility);
            this.Controls.Add(this._tetrVisibility);
            this.Controls.Add(this._cubeVisibility);
            this.Controls.Add(this._glControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.SizeChanged += new System.EventHandler(this.OnMainFormSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this._depthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cfTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._rcfTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl _glControl;
        private System.Windows.Forms.CheckBox _cubeVisibility;
        private System.Windows.Forms.CheckBox _tetrVisibility;
        private System.Windows.Forms.CheckBox _bigSphereVisibility;
        private System.Windows.Forms.ComboBox _materialIDComboBox;
        private System.Windows.Forms.ColorDialog _colorDialog;
        private System.Windows.Forms.Button _acceptButton;
        private System.Windows.Forms.ComboBox _materialTypeComboBox;
        private System.Windows.Forms.CheckBox _smallSphereVisibility;
        private System.Windows.Forms.TrackBar _depthTrackBar;
        private System.Windows.Forms.TrackBar _cfTrackBar;
        private System.Windows.Forms.TrackBar _rcfTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

