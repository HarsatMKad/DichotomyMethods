
namespace DichotomyMethods
{
  partial class MainForm
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.menuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1040, 33);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // рассчитатьToolStripMenuItem
      // 
      this.рассчитатьToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.рассчитатьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
      this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
      this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
      this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(17, 67);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(148, 67);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 2;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(7, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(169, 26);
      this.label1.TabIndex = 3;
      this.label1.Text = "Функция вида: ";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(17, 143);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 5;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(145, 52);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "B (до)";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 127);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(54, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Точность";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 51);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(34, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "A (от)";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(13, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(176, 24);
      this.label2.TabIndex = 6;
      this.label2.Text = "Укажите значения";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.textBox2);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.textBox3);
      this.panel1.Location = new System.Drawing.Point(12, 136);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(263, 182);
      this.panel1.TabIndex = 10;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.SystemColors.Control;
      this.button1.Location = new System.Drawing.Point(148, 140);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "Применить";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Location = new System.Drawing.Point(334, 55);
      this.chart1.Name = "chart1";
      series1.BorderWidth = 3;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(645, 465);
      this.chart1.TabIndex = 4;
      this.chart1.Text = "chart1";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(12, 77);
      this.label6.Margin = new System.Windows.Forms.Padding(0);
      this.label6.Name = "label6";
      this.label6.Padding = new System.Windows.Forms.Padding(10);
      this.label6.Size = new System.Drawing.Size(236, 44);
      this.label6.TabIndex = 11;
      this.label6.Text = "y = (27-18x+2x^2)*e^-x/3";
      this.label6.Click += new System.EventHandler(this.label6_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(13, 356);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(190, 24);
      this.label7.TabIndex = 12;
      this.label7.Text = "Точка пересечения ";
      this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.label7.Click += new System.EventHandler(this.label7_Click);
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(198, 360);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(130, 20);
      this.textBox4.TabIndex = 13;
      this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(13, 414);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(158, 24);
      this.label8.TabIndex = 14;
      this.label8.Text = "Точка минимума";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(13, 474);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(165, 24);
      this.label9.TabIndex = 15;
      this.label9.Text = "Точка максимума";
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(198, 419);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(130, 20);
      this.textBox5.TabIndex = 16;
      this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(198, 479);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(130, 20);
      this.textBox6.TabIndex = 17;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1040, 559);
      this.Controls.Add(this.textBox6);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox6;
  }
}