
namespace prog1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nUD2 = new System.Windows.Forms.NumericUpDown();
            this.nUD1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.nUD1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 203);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.nUD2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 96);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox2.Location = new System.Drawing.Point(288, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(721, 33);
            this.textBox2.TabIndex = 4;
            // 
            // nUD2
            // 
            this.nUD2.Font = new System.Drawing.Font("Calibri", 12F);
            this.nUD2.Location = new System.Drawing.Point(61, 37);
            this.nUD2.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nUD2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD2.Name = "nUD2";
            this.nUD2.Size = new System.Drawing.Size(120, 33);
            this.nUD2.TabIndex = 4;
            this.nUD2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD2.ValueChanged += new System.EventHandler(this.nUD2_ValueChanged);
            // 
            // nUD1
            // 
            this.nUD1.Font = new System.Drawing.Font("Calibri", 12F);
            this.nUD1.Location = new System.Drawing.Point(61, 39);
            this.nUD1.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nUD1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD1.Name = "nUD1";
            this.nUD1.Size = new System.Drawing.Size(120, 33);
            this.nUD1.TabIndex = 2;
            this.nUD1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD1.ValueChanged += new System.EventHandler(this.nUD1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox1.Location = new System.Drawing.Point(288, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(721, 33);
            this.textBox1.TabIndex = 3;
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.Location = new System.Drawing.Point(12, 12);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 2;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanel.Size = new System.Drawing.Size(200, 100);
            this.tlPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.tlPanel);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nUD1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown nUD2;
        private System.Windows.Forms.Panel panel1;
    }
}

