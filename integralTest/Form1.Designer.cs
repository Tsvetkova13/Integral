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
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.labelh = new System.Windows.Forms.Label();
			this.textBoxH = new System.Windows.Forms.TextBox();
			this.textFunc = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxRec = new System.Windows.Forms.TextBox();
			this.textBoxSim = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(575, 90);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 78);
			this.button1.TabIndex = 0;
			this.button1.Text = "Count";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxA
			// 
			this.textBoxA.BackColor = System.Drawing.Color.Black;
			this.textBoxA.ForeColor = System.Drawing.Color.Red;
			this.textBoxA.Location = new System.Drawing.Point(300, 164);
			this.textBoxA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(132, 22);
			this.textBoxA.TabIndex = 1;
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.BackColor = System.Drawing.Color.Black;
			this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelA.ForeColor = System.Drawing.Color.Red;
			this.labelA.Location = new System.Drawing.Point(81, 164);
			this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(149, 52);
			this.labelA.TabIndex = 2;
			this.labelA.Text = "Low A";
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.BackColor = System.Drawing.Color.Black;
			this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelB.ForeColor = System.Drawing.Color.Red;
			this.labelB.Location = new System.Drawing.Point(103, 238);
			this.labelB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(129, 52);
			this.labelB.TabIndex = 3;
			this.labelB.Text = "UP B";
			// 
			// textBoxB
			// 
			this.textBoxB.BackColor = System.Drawing.Color.Black;
			this.textBoxB.ForeColor = System.Drawing.Color.Red;
			this.textBoxB.Location = new System.Drawing.Point(300, 238);
			this.textBoxB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.Size = new System.Drawing.Size(132, 22);
			this.textBoxB.TabIndex = 4;
			// 
			// labelh
			// 
			this.labelh.AutoSize = true;
			this.labelh.BackColor = System.Drawing.Color.Black;
			this.labelh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelh.ForeColor = System.Drawing.Color.Red;
			this.labelh.Location = new System.Drawing.Point(188, 304);
			this.labelh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelh.Name = "labelh";
			this.labelh.Size = new System.Drawing.Size(48, 52);
			this.labelh.TabIndex = 5;
			this.labelh.Text = "h";
			// 
			// textBoxH
			// 
			this.textBoxH.BackColor = System.Drawing.Color.Black;
			this.textBoxH.ForeColor = System.Drawing.Color.Red;
			this.textBoxH.Location = new System.Drawing.Point(300, 304);
			this.textBoxH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxH.Name = "textBoxH";
			this.textBoxH.Size = new System.Drawing.Size(132, 22);
			this.textBoxH.TabIndex = 6;
			// 
			// textFunc
			// 
			this.textFunc.BackColor = System.Drawing.Color.Black;
			this.textFunc.ForeColor = System.Drawing.Color.Red;
			this.textFunc.Location = new System.Drawing.Point(300, 90);
			this.textFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textFunc.Name = "textFunc";
			this.textFunc.Size = new System.Drawing.Size(132, 22);
			this.textFunc.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(64, 90);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 46);
			this.label1.TabIndex = 8;
			this.label1.Text = "Fuction";
			// 
			// textBoxRec
			// 
			this.textBoxRec.BackColor = System.Drawing.Color.Black;
			this.textBoxRec.Location = new System.Drawing.Point(548, 238);
			this.textBoxRec.Name = "textBoxRec";
			this.textBoxRec.Size = new System.Drawing.Size(233, 22);
			this.textBoxRec.TabIndex = 9;
			// 
			// textBoxSim
			// 
			this.textBoxSim.BackColor = System.Drawing.Color.Black;
			this.textBoxSim.Location = new System.Drawing.Point(548, 303);
			this.textBoxSim.Name = "textBoxSim";
			this.textBoxSim.Size = new System.Drawing.Size(233, 22);
			this.textBoxSim.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.BackgroundImage = global::integralTest.Properties.Resources.IMG_2109;
			this.ClientSize = new System.Drawing.Size(1064, 453);
			this.Controls.Add(this.textBoxSim);
			this.Controls.Add(this.textBoxRec);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textFunc);
			this.Controls.Add(this.textBoxH);
			this.Controls.Add(this.labelh);
			this.Controls.Add(this.textBoxB);
			this.Controls.Add(this.labelB);
			this.Controls.Add(this.labelA);
			this.Controls.Add(this.textBoxA);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelh;
        private System.Windows.Forms.TextBox textBoxH;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox textFunc;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxRec;
		private System.Windows.Forms.TextBox textBoxSim;
	}
=======
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
	}
>>>>>>> dd4b0f0f24d613e2d1bd29e88f39c976aedf9962
}

