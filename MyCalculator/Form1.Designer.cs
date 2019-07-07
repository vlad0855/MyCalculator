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
            this.SuspendLayout();
            // 
            // FirstArgumentTextBox
            // 
            this.FirstArgumentTextBox.Location = new System.Drawing.Point(143, 49);
            this.FirstArgumentTextBox.Name = "FirstArgumentTextBox";
            this.FirstArgumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstArgumentTextBox.TabIndex = 0;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(355, 49);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextBox.TabIndex = 1;
            // 
            // SecondArgumentTextBox
            // 
            this.SecondArgumentTextBox.Location = new System.Drawing.Point(249, 49);
            this.SecondArgumentTextBox.Name = "SecondArgumentTextBox";
            this.SecondArgumentTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondArgumentTextBox.TabIndex = 2;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(143, 75);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(69, 23);
            this.Plus.TabIndex = 3;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(224, 75);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(69, 23);
            this.Minus.TabIndex = 4;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(305, 75);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(69, 23);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(386, 75);
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
            this.label1.Location = new System.Drawing.Point(143, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            // 
            // Squaring
            // 
            this.Squaring.Location = new System.Drawing.Point(143, 104);
            this.Squaring.Name = "Squaring";
            this.Squaring.Size = new System.Drawing.Size(69, 22);
            this.Squaring.TabIndex = 10;
            this.Squaring.Text = "x^2";
            this.Squaring.UseVisualStyleBackColor = true;
            this.Squaring.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // SQRT
            // 
            this.SQRT.Location = new System.Drawing.Point(224, 104);
            this.SQRT.Name = "SQRT";
            this.SQRT.Size = new System.Drawing.Size(69, 22);
            this.SQRT.TabIndex = 11;
            this.SQRT.Text = "√ ";
            this.SQRT.UseVisualStyleBackColor = true;
            this.SQRT.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(305, 104);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(69, 22);
            this.Sin.TabIndex = 12;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.CalculateOneArgument);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyCalculator.Properties.Resources.Безымянный;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(586, 296);
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
    }
}

