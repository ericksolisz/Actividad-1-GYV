namespace Transformaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PCT_Canvas = new System.Windows.Forms.PictureBox();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.CleanButton = new System.Windows.Forms.Button();
            this.CXPlusButton = new System.Windows.Forms.Button();
            this.CYPlusButton = new System.Windows.Forms.Button();
            this.CXMinusButton = new System.Windows.Forms.Button();
            this.CYMinusButton = new System.Windows.Forms.Button();
            this.CcenterButton = new System.Windows.Forms.Button();
            this.XPlusSButton = new System.Windows.Forms.Button();
            this.CMinusSButton = new System.Windows.Forms.Button();
            this.CRotateButton = new System.Windows.Forms.Button();
            this.CRotateOGButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_Canvas
            // 
            this.PCT_Canvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PCT_Canvas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PCT_Canvas.Location = new System.Drawing.Point(1, -1);
            this.PCT_Canvas.Name = "PCT_Canvas";
            this.PCT_Canvas.Size = new System.Drawing.Size(534, 450);
            this.PCT_Canvas.TabIndex = 0;
            this.PCT_Canvas.TabStop = false;
            this.PCT_Canvas.Click += new System.EventHandler(this.PCT_Canvas_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 10;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(631, 58);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 23);
            this.CleanButton.TabIndex = 5;
            this.CleanButton.Text = "Clean";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // CXPlusButton
            // 
            this.CXPlusButton.Location = new System.Drawing.Point(587, 105);
            this.CXPlusButton.Name = "CXPlusButton";
            this.CXPlusButton.Size = new System.Drawing.Size(75, 23);
            this.CXPlusButton.TabIndex = 7;
            this.CXPlusButton.Text = "+x";
            this.CXPlusButton.UseVisualStyleBackColor = true;
            this.CXPlusButton.Click += new System.EventHandler(this.CXPlusButton_Click);
            // 
            // CYPlusButton
            // 
            this.CYPlusButton.Location = new System.Drawing.Point(668, 105);
            this.CYPlusButton.Name = "CYPlusButton";
            this.CYPlusButton.Size = new System.Drawing.Size(75, 23);
            this.CYPlusButton.TabIndex = 8;
            this.CYPlusButton.Text = "+y";
            this.CYPlusButton.UseVisualStyleBackColor = true;
            this.CYPlusButton.Click += new System.EventHandler(this.CYPlusButton_Click);
            // 
            // CXMinusButton
            // 
            this.CXMinusButton.Location = new System.Drawing.Point(587, 134);
            this.CXMinusButton.Name = "CXMinusButton";
            this.CXMinusButton.Size = new System.Drawing.Size(75, 23);
            this.CXMinusButton.TabIndex = 9;
            this.CXMinusButton.Text = "-x";
            this.CXMinusButton.UseVisualStyleBackColor = true;
            this.CXMinusButton.Click += new System.EventHandler(this.CXMinusButton_Click);
            // 
            // CYMinusButton
            // 
            this.CYMinusButton.Location = new System.Drawing.Point(668, 134);
            this.CYMinusButton.Name = "CYMinusButton";
            this.CYMinusButton.Size = new System.Drawing.Size(75, 23);
            this.CYMinusButton.TabIndex = 10;
            this.CYMinusButton.Text = "-y";
            this.CYMinusButton.UseVisualStyleBackColor = true;
            this.CYMinusButton.Click += new System.EventHandler(this.CYMinusButton_Click);
            // 
            // CcenterButton
            // 
            this.CcenterButton.Location = new System.Drawing.Point(631, 222);
            this.CcenterButton.Name = "CcenterButton";
            this.CcenterButton.Size = new System.Drawing.Size(75, 23);
            this.CcenterButton.TabIndex = 11;
            this.CcenterButton.Text = "Center";
            this.CcenterButton.UseVisualStyleBackColor = true;
            this.CcenterButton.Click += new System.EventHandler(this.CcenterButton_Click);
            // 
            // XPlusSButton
            // 
            this.XPlusSButton.Location = new System.Drawing.Point(587, 163);
            this.XPlusSButton.Name = "XPlusSButton";
            this.XPlusSButton.Size = new System.Drawing.Size(75, 23);
            this.XPlusSButton.TabIndex = 12;
            this.XPlusSButton.Text = "+Scale";
            this.XPlusSButton.UseVisualStyleBackColor = true;
            this.XPlusSButton.Click += new System.EventHandler(this.XPlusSButton_Click);
            // 
            // CMinusSButton
            // 
            this.CMinusSButton.Location = new System.Drawing.Point(669, 163);
            this.CMinusSButton.Name = "CMinusSButton";
            this.CMinusSButton.Size = new System.Drawing.Size(75, 23);
            this.CMinusSButton.TabIndex = 13;
            this.CMinusSButton.Text = "-Scale";
            this.CMinusSButton.UseVisualStyleBackColor = true;
            this.CMinusSButton.Click += new System.EventHandler(this.CMinusSButton_Click);
            // 
            // CRotateButton
            // 
            this.CRotateButton.Location = new System.Drawing.Point(713, 311);
            this.CRotateButton.Name = "CRotateButton";
            this.CRotateButton.Size = new System.Drawing.Size(75, 23);
            this.CRotateButton.TabIndex = 14;
            this.CRotateButton.Text = "Rotate";
            this.CRotateButton.UseVisualStyleBackColor = true;
            this.CRotateButton.Click += new System.EventHandler(this.CRotateButton_Click);
            // 
            // CRotateOGButton
            // 
            this.CRotateOGButton.Location = new System.Drawing.Point(631, 193);
            this.CRotateOGButton.Name = "CRotateOGButton";
            this.CRotateOGButton.Size = new System.Drawing.Size(75, 23);
            this.CRotateOGButton.TabIndex = 15;
            this.CRotateOGButton.Text = "RotateNC";
            this.CRotateOGButton.UseVisualStyleBackColor = true;
            this.CRotateOGButton.Click += new System.EventHandler(this.CRotateOGButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Angle:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CRotateOGButton);
            this.Controls.Add(this.CRotateButton);
            this.Controls.Add(this.CMinusSButton);
            this.Controls.Add(this.XPlusSButton);
            this.Controls.Add(this.CcenterButton);
            this.Controls.Add(this.CYMinusButton);
            this.Controls.Add(this.CXMinusButton);
            this.Controls.Add(this.CYPlusButton);
            this.Controls.Add(this.CXPlusButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.PCT_Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_Canvas;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button CXPlusButton;
        private System.Windows.Forms.Button CYPlusButton;
        private System.Windows.Forms.Button CXMinusButton;
        private System.Windows.Forms.Button CYMinusButton;
        private System.Windows.Forms.Button CcenterButton;
        private System.Windows.Forms.Button XPlusSButton;
        private System.Windows.Forms.Button CMinusSButton;
        private System.Windows.Forms.Button CRotateButton;
        private System.Windows.Forms.Button CRotateOGButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

