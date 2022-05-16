
namespace Laba2Nesterov402
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
            this.BuildButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mC = new System.Windows.Forms.DataGridView();
            this.mB = new System.Windows.Forms.DataGridView();
            this.mSize = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mA)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildButton
            // 
            this.BuildButton.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.BuildButton.Location = new System.Drawing.Point(518, 315);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(126, 33);
            this.BuildButton.TabIndex = 9;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(227, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размерность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(647, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Матрица C";
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
            // mC
            // 
            this.mC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mC.Location = new System.Drawing.Point(568, 55);
            this.mC.Name = "mC";
            this.mC.Size = new System.Drawing.Size(250, 200);
            this.mC.TabIndex = 2;
            // 
            // mB
            // 
            this.mB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mB.Location = new System.Drawing.Point(295, 55);
            this.mB.Name = "mB";
            this.mB.Size = new System.Drawing.Size(250, 200);
            this.mB.TabIndex = 1;
            // 
            // mSize
            // 
            this.mSize.Font = new System.Drawing.Font("Calibri", 14F);
            this.mSize.Location = new System.Drawing.Point(351, 318);
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
            this.mSize.TabIndex = 8;
            this.mSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mC);
            this.panel1.Controls.Add(this.mB);
            this.panel1.Controls.Add(this.mA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 291);
            this.panel1.TabIndex = 5;
            // 
            // mA
            // 
            this.mA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mA.Location = new System.Drawing.Point(25, 55);
            this.mA.Name = "mA";
            this.mA.Size = new System.Drawing.Size(250, 200);
            this.mA.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 380);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mSize);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView mC;
        private System.Windows.Forms.DataGridView mB;
        private System.Windows.Forms.NumericUpDown mSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView mA;
    }
}

