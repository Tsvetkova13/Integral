namespace integralTest
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelh = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(539, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.Black;
            this.textBoxA.ForeColor = System.Drawing.Color.Red;
            this.textBoxA.Location = new System.Drawing.Point(225, 46);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Black;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.ForeColor = System.Drawing.Color.Red;
            this.labelA.Location = new System.Drawing.Point(77, 37);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(117, 39);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "Low A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Black;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.ForeColor = System.Drawing.Color.Red;
            this.labelB.Location = new System.Drawing.Point(77, 103);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(101, 39);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "UP B";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(225, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // labelh
            // 
            this.labelh.AutoSize = true;
            this.labelh.BackColor = System.Drawing.Color.Black;
            this.labelh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelh.ForeColor = System.Drawing.Color.Red;
            this.labelh.Location = new System.Drawing.Point(77, 180);
            this.labelh.Name = "labelh";
            this.labelh.Size = new System.Drawing.Size(37, 39);
            this.labelh.TabIndex = 5;
            this.labelh.Text = "h";
            // 
            // textBoxH
            // 
            this.textBoxH.BackColor = System.Drawing.Color.Black;
            this.textBoxH.ForeColor = System.Drawing.Color.Red;
            this.textBoxH.Location = new System.Drawing.Point(225, 180);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 20);
            this.textBoxH.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::integralTest.Properties.Resources.IMG_2109;
            this.ClientSize = new System.Drawing.Size(798, 368);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.labelh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tsvetkova, Shepeleva 3-46";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelh;
        private System.Windows.Forms.TextBox textBoxH;
    }
}

