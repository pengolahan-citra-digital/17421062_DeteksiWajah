namespace Deteksi_wajah
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
            this.components = new System.ComponentModel.Container();
            this.matrixBox1 = new Emgu.CV.UI.MatrixBox();
            this.btn_camera = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixBox1
            // 
            this.matrixBox1.Location = new System.Drawing.Point(207, 0);
            this.matrixBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.matrixBox1.Matrix = null;
            this.matrixBox1.Name = "matrixBox1";
            this.matrixBox1.Size = new System.Drawing.Size(30, 8);
            this.matrixBox1.TabIndex = 0;
            // 
            // btn_camera
            // 
            this.btn_camera.Location = new System.Drawing.Point(642, 625);
            this.btn_camera.Name = "btn_camera";
            this.btn_camera.Size = new System.Drawing.Size(125, 41);
            this.btn_camera.TabIndex = 1;
            this.btn_camera.Text = "Buka Camera";
            this.btn_camera.UseVisualStyleBackColor = true;
            this.btn_camera.Click += new System.EventHandler(this.btn_camera_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(27, 16);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1340, 588);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 687);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btn_camera);
            this.Controls.Add(this.matrixBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.MatrixBox matrixBox1;
        private System.Windows.Forms.Button btn_camera;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}

