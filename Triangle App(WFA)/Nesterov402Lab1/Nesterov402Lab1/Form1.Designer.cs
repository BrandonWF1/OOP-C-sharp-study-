
namespace Nesterov402Lab1
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
            this.box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createTriangle = new System.Windows.Forms.Button();
            this.firstX = new System.Windows.Forms.NumericUpDown();
            this.firstY = new System.Windows.Forms.NumericUpDown();
            this.randomValues = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.angleRotate = new System.Windows.Forms.NumericUpDown();
            this.rotate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lineLenght = new System.Windows.Forms.NumericUpDown();
            this.createOpOkr = new System.Windows.Forms.Button();
            this.createVpisOkr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.SystemColors.Window;
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.box.Location = new System.Drawing.Point(3, 0);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(625, 325);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Координаты первой точки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(131, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y";
            // 
            // createTriangle
            // 
            this.createTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTriangle.Location = new System.Drawing.Point(466, 339);
            this.createTriangle.Name = "createTriangle";
            this.createTriangle.Size = new System.Drawing.Size(162, 59);
            this.createTriangle.TabIndex = 16;
            this.createTriangle.Text = "Построить треугольник";
            this.createTriangle.UseVisualStyleBackColor = true;
            this.createTriangle.Click += new System.EventHandler(this.createTriangle_Click);
            // 
            // firstX
            // 
            this.firstX.Location = new System.Drawing.Point(39, 365);
            this.firstX.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.firstX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstX.Name = "firstX";
            this.firstX.Size = new System.Drawing.Size(86, 20);
            this.firstX.TabIndex = 17;
            this.firstX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // firstY
            // 
            this.firstY.Location = new System.Drawing.Point(157, 365);
            this.firstY.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.firstY.Name = "firstY";
            this.firstY.Size = new System.Drawing.Size(86, 20);
            this.firstY.TabIndex = 18;
            this.firstY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // randomValues
            // 
            this.randomValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomValues.Location = new System.Drawing.Point(324, 339);
            this.randomValues.Name = "randomValues";
            this.randomValues.Size = new System.Drawing.Size(136, 59);
            this.randomValues.TabIndex = 23;
            this.randomValues.Text = "Случайные значения";
            this.randomValues.UseVisualStyleBackColor = true;
            this.randomValues.Click += new System.EventHandler(this.randomValues_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(324, 495);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(304, 24);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // angleRotate
            // 
            this.angleRotate.Location = new System.Drawing.Point(12, 495);
            this.angleRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleRotate.Name = "angleRotate";
            this.angleRotate.Size = new System.Drawing.Size(236, 20);
            this.angleRotate.TabIndex = 25;
            // 
            // rotate
            // 
            this.rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotate.Location = new System.Drawing.Point(12, 441);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(231, 48);
            this.rotate.TabIndex = 26;
            this.rotate.Text = "Повернуть на заданный угол:";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Длина стороны";
            // 
            // lineLenght
            // 
            this.lineLenght.Location = new System.Drawing.Point(13, 415);
            this.lineLenght.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.lineLenght.Name = "lineLenght";
            this.lineLenght.Size = new System.Drawing.Size(235, 20);
            this.lineLenght.TabIndex = 28;
            this.lineLenght.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // createOpOkr
            // 
            this.createOpOkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOpOkr.Location = new System.Drawing.Point(324, 415);
            this.createOpOkr.Name = "createOpOkr";
            this.createOpOkr.Size = new System.Drawing.Size(136, 74);
            this.createOpOkr.TabIndex = 29;
            this.createOpOkr.Text = "Построить описанную окружность";
            this.createOpOkr.UseVisualStyleBackColor = true;
            this.createOpOkr.Click += new System.EventHandler(this.createOpOkr_Click);
            // 
            // createVpisOkr
            // 
            this.createVpisOkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createVpisOkr.Location = new System.Drawing.Point(466, 415);
            this.createVpisOkr.Name = "createVpisOkr";
            this.createVpisOkr.Size = new System.Drawing.Size(162, 74);
            this.createVpisOkr.TabIndex = 30;
            this.createVpisOkr.Text = "Построить вписанную окружность";
            this.createVpisOkr.UseVisualStyleBackColor = true;
            this.createVpisOkr.Click += new System.EventHandler(this.createVpisOkr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 531);
            this.Controls.Add(this.createVpisOkr);
            this.Controls.Add(this.createOpOkr);
            this.Controls.Add(this.lineLenght);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rotate);
            this.Controls.Add(this.angleRotate);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.randomValues);
            this.Controls.Add(this.firstY);
            this.Controls.Add(this.firstX);
            this.Controls.Add(this.createTriangle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box);
            this.Name = "Form1";
            this.Text = "Правильный треугольник";
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createTriangle;
        private System.Windows.Forms.NumericUpDown firstX;
        private System.Windows.Forms.NumericUpDown firstY;
        private System.Windows.Forms.Button randomValues;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown angleRotate;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lineLenght;
        private System.Windows.Forms.Button createOpOkr;
        private System.Windows.Forms.Button createVpisOkr;
    }
}

