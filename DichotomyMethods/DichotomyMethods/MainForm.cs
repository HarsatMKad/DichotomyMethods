using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DichotomyMethods
{
  public partial class MainForm : Form
  {
    private double RestrictionStart, RestrictionEnd, Precision;
    private double x, y;

    public MainForm()
    {
      InitializeComponent();
    }

    private double Function(double x)
    {
      return (27.0 - 18.0 * x + 2.0 * x * x) * Math.Exp(-x / 3.0);
    }

    private void FindTheMinimum()
    {
      double Start = RestrictionStart;
      double End = RestrictionEnd;
      double Midpoint;

      while (End - Start > Precision)
      {
        Midpoint = (End + Start) / 2.0;

        double yA = Function(Start);
        double yX = Function(Midpoint);
        double yB = Function(End);

        if (yA < yX)
        {
          End = Midpoint;
        }
        else
        {
          Start = Midpoint;
        }
        textBox5.Text = Midpoint.ToString();
      }
    }

    private void FindTheMaximum()
    {
      double Start = RestrictionStart;
      double End = RestrictionEnd;
      double Midpoint;

      while (End - Start > Precision)
      {
        Midpoint = (End + Start) / 2.0;

        double yA = -1.0 * Function(Start);
        double yX = -1.0 * Function(Midpoint);
        double yB = -1.0 * Function(End);

        if (yA < yX)
        {
          End = Midpoint;
        }
        else
        {
          Start = Midpoint;
        }
        textBox6.Text = Midpoint.ToString();
      }
    }

    private void FindIntersectionPoints()
    {
      double Start = RestrictionStart;
      double End = RestrictionEnd;

      while (End - Start > Precision)
      {
        double MidPoint = (Start + End) / 2.0;
        if (Function(End) * Function(MidPoint) < 0)
        {
          Start = MidPoint;
        }
        else
        {
          End = MidPoint;
        }
      }
      textBox4.Text = Convert.ToString((Start + End) / 2.0);
    }

    private void chart1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        RestrictionStart = Convert.ToDouble(textBox1.Text);
        RestrictionEnd = Convert.ToDouble(textBox2.Text);
        Precision = Convert.ToDouble(textBox3.Text);
      }
      catch
      {
        MessageBox.Show("Данные введены в неверном формате", "Ошибка", MessageBoxButtons.OK);
      }
      finally
      {
        if(Precision <= 0)
        {
          MessageBox.Show("Точность указана неверно", "Ошибка", MessageBoxButtons.OK);
        }
      }
    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (RestrictionStart < RestrictionEnd)
      {
        x = RestrictionStart;
        this.chart1.Series[0].Points.Clear();
        while (x <= RestrictionEnd)
        {
          y = Function(x);
          this.chart1.Series[0].Points.AddXY(x, y);
          x += Precision;
        }

        FindIntersectionPoints();
        FindTheMinimum();
        FindTheMaximum();
      }
      else
      {
        MessageBox.Show("Данные введены в неверном формате", "Ошибка", MessageBoxButtons.OK);
      }
    }
  }
}
