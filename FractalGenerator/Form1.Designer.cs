namespace FractalTree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawCanvas = new System.Windows.Forms.PictureBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.TrackShrinkRatio = new System.Windows.Forms.TrackBar();
            this.lblShrinkRatio = new System.Windows.Forms.Label();
            this.TrackAngleDelta = new System.Windows.Forms.TrackBar();
            this.lblAngleDelta = new System.Windows.Forms.Label();
            this.TrackSplitDepth = new System.Windows.Forms.TrackBar();
            this.lblSplitDepth = new System.Windows.Forms.Label();
            this.txtAnimDelay = new System.Windows.Forms.TextBox();
            this.lblAnimDelay = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackShrinkRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackAngleDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSplitDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawCanvas
            // 
            this.DrawCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawCanvas.Location = new System.Drawing.Point(23, 15);
            this.DrawCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.DrawCanvas.Name = "DrawCanvas";
            this.DrawCanvas.Size = new System.Drawing.Size(1374, 803);
            this.DrawCanvas.TabIndex = 0;
            this.DrawCanvas.TabStop = false;
            this.DrawCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCanvas_Paint);
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(1412, 49);
            this.BtnDraw.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(137, 28);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.Text = "Рисовать";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // TrackShrinkRatio
            // 
            this.TrackShrinkRatio.Location = new System.Drawing.Point(1408, 341);
            this.TrackShrinkRatio.Margin = new System.Windows.Forms.Padding(4);
            this.TrackShrinkRatio.Name = "TrackShrinkRatio";
            this.TrackShrinkRatio.Size = new System.Drawing.Size(139, 56);
            this.TrackShrinkRatio.TabIndex = 2;
            this.TrackShrinkRatio.Value = 8;
            // 
            // lblShrinkRatio
            // 
            this.lblShrinkRatio.AutoSize = true;
            this.lblShrinkRatio.Location = new System.Drawing.Point(1405, 320);
            this.lblShrinkRatio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShrinkRatio.Name = "lblShrinkRatio";
            this.lblShrinkRatio.Size = new System.Drawing.Size(148, 17);
            this.lblShrinkRatio.TabIndex = 3;
            this.lblShrinkRatio.Text = "Частота сокращений";
            // 
            // TrackAngleDelta
            // 
            this.TrackAngleDelta.Location = new System.Drawing.Point(1408, 254);
            this.TrackAngleDelta.Margin = new System.Windows.Forms.Padding(4);
            this.TrackAngleDelta.Maximum = 85;
            this.TrackAngleDelta.Minimum = 10;
            this.TrackAngleDelta.Name = "TrackAngleDelta";
            this.TrackAngleDelta.Size = new System.Drawing.Size(139, 56);
            this.TrackAngleDelta.TabIndex = 4;
            this.TrackAngleDelta.TickFrequency = 5;
            this.TrackAngleDelta.Value = 45;
            // 
            // lblAngleDelta
            // 
            this.lblAngleDelta.AutoSize = true;
            this.lblAngleDelta.Location = new System.Drawing.Point(1430, 233);
            this.lblAngleDelta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngleDelta.Name = "lblAngleDelta";
            this.lblAngleDelta.Size = new System.Drawing.Size(89, 17);
            this.lblAngleDelta.TabIndex = 5;
            this.lblAngleDelta.Text = "Дельта угла";
            // 
            // TrackSplitDepth
            // 
            this.TrackSplitDepth.Location = new System.Drawing.Point(1407, 176);
            this.TrackSplitDepth.Margin = new System.Windows.Forms.Padding(4);
            this.TrackSplitDepth.Maximum = 20;
            this.TrackSplitDepth.Minimum = 3;
            this.TrackSplitDepth.Name = "TrackSplitDepth";
            this.TrackSplitDepth.Size = new System.Drawing.Size(139, 56);
            this.TrackSplitDepth.TabIndex = 6;
            this.TrackSplitDepth.Value = 7;
            // 
            // lblSplitDepth
            // 
            this.lblSplitDepth.AutoSize = true;
            this.lblSplitDepth.Location = new System.Drawing.Point(1405, 155);
            this.lblSplitDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSplitDepth.Name = "lblSplitDepth";
            this.lblSplitDepth.Size = new System.Drawing.Size(157, 17);
            this.lblSplitDepth.TabIndex = 7;
            this.lblSplitDepth.Text = "Глубина расщепления";
            // 
            // txtAnimDelay
            // 
            this.txtAnimDelay.Location = new System.Drawing.Point(1421, 127);
            this.txtAnimDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnimDelay.Name = "txtAnimDelay";
            this.txtAnimDelay.Size = new System.Drawing.Size(111, 22);
            this.txtAnimDelay.TabIndex = 8;
            this.txtAnimDelay.Text = "50";
            // 
            // lblAnimDelay
            // 
            this.lblAnimDelay.AutoSize = true;
            this.lblAnimDelay.Location = new System.Drawing.Point(1411, 106);
            this.lblAnimDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimDelay.Name = "lblAnimDelay";
            this.lblAnimDelay.Size = new System.Drawing.Size(138, 17);
            this.lblAnimDelay.TabIndex = 9;
            this.lblAnimDelay.Text = "Скорость анимации";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1412, 13);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(137, 28);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 831);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblAnimDelay);
            this.Controls.Add(this.txtAnimDelay);
            this.Controls.Add(this.lblSplitDepth);
            this.Controls.Add(this.TrackSplitDepth);
            this.Controls.Add(this.lblAngleDelta);
            this.Controls.Add(this.TrackAngleDelta);
            this.Controls.Add(this.lblShrinkRatio);
            this.Controls.Add(this.TrackShrinkRatio);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.DrawCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fractal Tree Generator";
            ((System.ComponentModel.ISupportInitialize)(this.DrawCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackShrinkRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackAngleDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSplitDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawCanvas;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.TrackBar TrackShrinkRatio;
        private System.Windows.Forms.Label lblShrinkRatio;
        private System.Windows.Forms.TrackBar TrackAngleDelta;
        private System.Windows.Forms.Label lblAngleDelta;
        private System.Windows.Forms.TrackBar TrackSplitDepth;
        private System.Windows.Forms.Label lblSplitDepth;
        private System.Windows.Forms.TextBox txtAnimDelay;
        private System.Windows.Forms.Label lblAnimDelay;
        private System.Windows.Forms.Button btnStop;
    }
}

