
namespace Lab2Matrixpractice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mSize = new System.Windows.Forms.NumericUpDown();
            this.BuildButton = new System.Windows.Forms.Button();
            this.mA = new System.Windows.Forms.DataGridView();
            this.mB = new System.Windows.Forms.DataGridView();
            this.mC = new System.Windows.Forms.DataGridView();
            this.mTA = new System.Windows.Forms.DataGridView();
            this.mTB = new System.Windows.Forms.DataGridView();
            this.mTC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonMult);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mC);
            this.panel1.Controls.Add(this.mB);
            this.panel1.Controls.Add(this.mA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 177);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.buttonC);
            this.panel2.Controls.Add(this.buttonB);
            this.panel2.Controls.Add(this.buttonA);
            this.panel2.Controls.Add(this.mTC);
            this.panel2.Controls.Add(this.mTB);
            this.panel2.Controls.Add(this.mTA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 181);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(166, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размерность:";
            // 
            // mSize
            // 
            this.mSize.Font = new System.Drawing.Font("Calibri", 14F);
            this.mSize.Location = new System.Drawing.Point(290, 243);
            this.mSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.mSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mSize.Name = "mSize";
            this.mSize.Size = new System.Drawing.Size(120, 30);
            this.mSize.TabIndex = 3;
            this.mSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BuildButton
            // 
            this.BuildButton.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.BuildButton.Location = new System.Drawing.Point(457, 240);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(126, 33);
            this.BuildButton.TabIndex = 4;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // mA
            // 
            this.mA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mA.Location = new System.Drawing.Point(46, 55);
            this.mA.Name = "mA";
            this.mA.Size = new System.Drawing.Size(199, 97);
            this.mA.TabIndex = 0;
            // 
            // mB
            // 
            this.mB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mB.Location = new System.Drawing.Point(321, 55);
            this.mB.Name = "mB";
            this.mB.Size = new System.Drawing.Size(199, 97);
            this.mB.TabIndex = 1;
            // 
            // mC
            // 
            this.mC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mC.Location = new System.Drawing.Point(567, 55);
            this.mC.Name = "mC";
            this.mC.Size = new System.Drawing.Size(199, 97);
            this.mC.TabIndex = 2;
            // 
            // mTA
            // 
            this.mTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mTA.Location = new System.Drawing.Point(46, 72);
            this.mTA.Name = "mTA";
            this.mTA.Size = new System.Drawing.Size(199, 97);
            this.mTA.TabIndex = 3;
            // 
            // mTB
            // 
            this.mTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mTB.Location = new System.Drawing.Point(321, 72);
            this.mTB.Name = "mTB";
            this.mTB.Size = new System.Drawing.Size(199, 97);
            this.mTB.TabIndex = 4;
            // 
            // mTC
            // 
            this.mTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mTC.Location = new System.Drawing.Point(567, 72);
            this.mTC.Name = "mTC";
            this.mTC.Size = new System.Drawing.Size(199, 97);
            this.mTC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(92, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Матрица А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(371, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Матрица B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(616, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Матрица C";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonPlus.Location = new System.Drawing.Point(264, 55);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(38, 28);
            this.buttonPlus.TabIndex = 6;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonMinus.Location = new System.Drawing.Point(264, 89);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(38, 28);
            this.buttonMinus.TabIndex = 7;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Calibri", 12F);
            this.buttonMult.Location = new System.Drawing.Point(264, 123);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(38, 28);
            this.buttonMult.TabIndex = 8;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonA
            // 
            this.buttonA.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonA.Location = new System.Drawing.Point(84, 33);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(126, 33);
            this.buttonA.TabIndex = 5;
            this.buttonA.Text = "Трансп A\\";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonB.Location = new System.Drawing.Point(362, 33);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(126, 33);
            this.buttonB.TabIndex = 6;
            this.buttonB.Text = "Трансп B/";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.buttonC.Location = new System.Drawing.Point(605, 33);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(126, 33);
            this.buttonC.TabIndex = 7;
            this.buttonC.Text = "Реверс C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(531, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(822, 519);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.mSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Работа с матрицами";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView mA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mSize;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.DataGridView mC;
        private System.Windows.Forms.DataGridView mB;
        private System.Windows.Forms.DataGridView mTC;
        private System.Windows.Forms.DataGridView mTB;
        private System.Windows.Forms.DataGridView mTA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonA;
    }
}

