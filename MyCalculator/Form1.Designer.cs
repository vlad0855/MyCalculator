namespace MyCalculator
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
            this.FirstArgumentTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SecondArgumentTextBox = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Squaring = new System.Windows.Forms.Button();
            this.SQRT = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Ctan = new System.Windows.Forms.Button();
            this.Abs = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.PowFloat = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.DivInt = new System.Windows.Forms.Button();
            this.PowTwo = new System.Windows.Forms.Button();
            this.PowTen = new System.Windows.Forms.Button();
            this.ExpPow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgumentTextBox
            // 
            this.FirstArgumentTextBox.Location = new System.Drawing.Point(141, 28);
            this.FirstArgumentTextBox.Name = "FirstArgumentTextBox";
            this.FirstArgumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstArgumentTextBox.TabIndex = 0;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(353, 28);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextBox.TabIndex = 1;
            // 
            // SecondArgumentTextBox
            // 
            this.SecondArgumentTextBox.Location = new System.Drawing.Point(247, 28);
            this.SecondArgumentTextBox.Name = "SecondArgumentTextBox";
            this.SecondArgumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondArgumentTextBox.TabIndex = 2;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(225, 54);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(69, 23);
            this.Plus.TabIndex = 3;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(300, 54);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(69, 23);
            this.Minus.TabIndex = 4;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(375, 54);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(69, 23);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(150, 54);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(69, 23);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            // 
            // Squaring
            // 
            this.Squaring.Location = new System.Drawing.Point(22, 85);
            this.Squaring.Name = "Squaring";
            this.Squaring.Size = new System.Drawing.Size(69, 22);
            this.Squaring.TabIndex = 10;
            this.Squaring.Text = "x^2";
            this.Squaring.UseVisualStyleBackColor = true;
            this.Squaring.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // SQRT
            // 
            this.SQRT.Location = new System.Drawing.Point(97, 85);
            this.SQRT.Name = "SQRT";
            this.SQRT.Size = new System.Drawing.Size(69, 22);
            this.SQRT.TabIndex = 11;
            this.SQRT.Text = "√ ";
            this.SQRT.UseVisualStyleBackColor = true;
            this.SQRT.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(172, 85);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(69, 22);
            this.Sin.TabIndex = 12;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(22, 113);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(69, 22);
            this.Cos.TabIndex = 13;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(97, 113);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(69, 22);
            this.Tan.TabIndex = 14;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(172, 113);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(69, 22);
            this.Arcsin.TabIndex = 15;
            this.Arcsin.Text = "Arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(22, 141);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(69, 22);
            this.Arccos.TabIndex = 16;
            this.Arccos.Text = "Arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Ctan
            // 
            this.Ctan.Location = new System.Drawing.Point(97, 141);
            this.Ctan.Name = "Ctan";
            this.Ctan.Size = new System.Drawing.Size(69, 22);
            this.Ctan.TabIndex = 17;
            this.Ctan.Text = "Ctan";
            this.Ctan.UseVisualStyleBackColor = true;
            this.Ctan.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Abs
            // 
            this.Abs.Location = new System.Drawing.Point(172, 141);
            this.Abs.Name = "Abs";
            this.Abs.Size = new System.Drawing.Size(69, 22);
            this.Abs.TabIndex = 18;
            this.Abs.Text = "Abs";
            this.Abs.UseVisualStyleBackColor = true;
            this.Abs.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(22, 169);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(69, 22);
            this.Div.TabIndex = 19;
            this.Div.Text = "1/x";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "1/x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(438, 84);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(69, 23);
            this.Log.TabIndex = 21;
            this.Log.Text = "logx(y)";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(513, 84);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(69, 23);
            this.Pow.TabIndex = 22;
            this.Pow.Text = "x^y";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // PowFloat
            // 
            this.PowFloat.Location = new System.Drawing.Point(363, 84);
            this.PowFloat.Name = "PowFloat";
            this.PowFloat.Size = new System.Drawing.Size(69, 23);
            this.PowFloat.TabIndex = 23;
            this.PowFloat.Text = "x^(1/y)";
            this.PowFloat.UseVisualStyleBackColor = true;
            this.PowFloat.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(438, 113);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(69, 23);
            this.Min.TabIndex = 24;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(513, 113);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(69, 23);
            this.Max.TabIndex = 25;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(363, 113);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(69, 23);
            this.Mod.TabIndex = 26;
            this.Mod.Text = "Mod";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(363, 140);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(69, 23);
            this.Negative.TabIndex = 27;
            this.Negative.Text = "-x";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // DivInt
            // 
            this.DivInt.Location = new System.Drawing.Point(438, 140);
            this.DivInt.Name = "DivInt";
            this.DivInt.Size = new System.Drawing.Size(69, 23);
            this.DivInt.TabIndex = 28;
            this.DivInt.Text = "DivInt";
            this.DivInt.UseVisualStyleBackColor = true;
            this.DivInt.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // PowTwo
            // 
            this.PowTwo.Location = new System.Drawing.Point(513, 141);
            this.PowTwo.Name = "PowTwo";
            this.PowTwo.Size = new System.Drawing.Size(69, 23);
            this.PowTwo.TabIndex = 29;
            this.PowTwo.Text = "2^x";
            this.PowTwo.UseVisualStyleBackColor = true;
            this.PowTwo.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // PowTen
            // 
            this.PowTen.Location = new System.Drawing.Point(513, 169);
            this.PowTen.Name = "PowTen";
            this.PowTen.Size = new System.Drawing.Size(69, 23);
            this.PowTen.TabIndex = 30;
            this.PowTen.Text = "10^x";
            this.PowTen.UseVisualStyleBackColor = true;
            this.PowTen.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // ExpPow
            // 
            this.ExpPow.Location = new System.Drawing.Point(438, 169);
            this.ExpPow.Name = "ExpPow";
            this.ExpPow.Size = new System.Drawing.Size(69, 23);
            this.ExpPow.TabIndex = 31;
            this.ExpPow.Text = "e^x";
            this.ExpPow.UseVisualStyleBackColor = true;
            this.ExpPow.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyCalculator.Properties.Resources.Безымянный;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(594, 296);
            this.Controls.Add(this.ExpPow);
            this.Controls.Add(this.PowTen);
            this.Controls.Add(this.PowTwo);
            this.Controls.Add(this.DivInt);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.PowFloat);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Abs);
            this.Controls.Add(this.Ctan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.SQRT);
            this.Controls.Add(this.Squaring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.SecondArgumentTextBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.FirstArgumentTextBox);
            this.Name = "Form1";
            this.Text = "KAVO";
            this.Click += new System.EventHandler(this.CalculateOneArgument);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstArgumentTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox SecondArgumentTextBox;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Squaring;
        private System.Windows.Forms.Button SQRT;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Ctan;
        private System.Windows.Forms.Button Abs;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button PowFloat;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button DivInt;
        private System.Windows.Forms.Button PowTwo;
        private System.Windows.Forms.Button PowTen;
        private System.Windows.Forms.Button ExpPow;
    }
}

