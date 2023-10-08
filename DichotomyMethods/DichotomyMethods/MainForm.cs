using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
      double xStart = RestrictionStart;
      double xEnd = RestrictionEnd;
      double RestStart = RestrictionStart;
      double RestEnd = RestrictionEnd;

      double xMin = Function(RestrictionStart);
      double RestrMin = Function(RestrictionStart);

      while (xEnd - xStart > Precision)
      {
        double Midpoint = (xEnd + xStart) / 2.0;
        double yX1 = Function(Midpoint - Precision);
        double yX2 = Function(Midpoint + Precision);

        if (yX1 < yX2)
        {
          xEnd = Midpoint;
        }
        else
        {
          xStart = Midpoint;
        }
        xMin = Midpoint;
      }

      while (RestEnd - RestStart > Precision)
      {
        double Midpoint = (RestEnd + RestStart) / 2.0;
        double A = Function(RestStart + Precision);
        double B = Function(RestEnd - Precision);

        if (A < B)
        {
          RestEnd = Midpoint;
        }
        else
        {
          RestStart = Midpoint;
        }
        RestrMin = Midpoint;
      }

      if (Function(xMin) < Function(RestrMin))
      {
        textBox5.Text = xMin.ToString();
      }
      else
      {
        textBox5.Text = RestrMin.ToString();
      }
    }

    private void FindTheMaximum()
    {
      double xStart = RestrictionStart;
      double xEnd = RestrictionEnd;
      double RestStart = RestrictionStart;
      double RestEnd = RestrictionEnd;

      double xMax = Function(RestrictionStart);
      double RestrMax = Function(RestrictionStart);

      while (xEnd - xStart > Precision)
      {
        double Midpoint = (xEnd + xStart) / 2.0;
        double yX1 = Function(Midpoint - Precision);
        double yX2 = Function(Midpoint + Precision);

        if (yX1 > yX2)
        {
          xEnd = Midpoint;
        }
        else
        {
          xStart = Midpoint;
        }
        xMax = Midpoint;
      }

      while (RestEnd - RestStart > Precision)
      {
        double Midpoint = (RestEnd + RestStart) / 2.0;
        double A = Function(RestStart + Precision);
        double B = Function(RestEnd - Precision);

        if (A > B)
        {
          RestEnd = Midpoint;
        }
        else
        {
          RestStart = Midpoint;
        }
        RestrMax = Midpoint;
      }

      if (Function(xMax) > Function(RestrMax))
      {
        textBox6.Text = xMax.ToString();
      }
      else
      {
        textBox6.Text = RestrMax.ToString();
      }
    }

    private void FindIntersectionPoints2()
    {
      double Start = RestrictionStart;
      double End = RestrictionEnd;

      while (Math.Abs(End - Start) > Precision)
      {
        double MidPoint = (End + Start) / 2;
        if (Function(MidPoint) * Function(Start) > 0)
        {
          Start = MidPoint;
        }
        else
        {
          End = MidPoint;
        }
      }
      Console.WriteLine((Start + End) / 2.0);
    }

    private void FindIntersectionPoints3()
    {
      double Start = RestrictionStart;
      double End = RestrictionEnd;
      double e = Precision;
      double MidPoint = (Start + End) / 2;

      while(End - Start > 2 * e)
      {
        if(Function(Start) * Function(MidPoint) < 0)
        {
          End = MidPoint;
        }
        else
        {
          Start = MidPoint;
        }
        MidPoint = (Start + End) / 2;
      }
      Console.WriteLine((Start + End) / 2.0);
      Console.WriteLine(" ");
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
        Exaption ex = new Exaption();
        ex.showDataEntryError();
      }
      if (Precision <= 0)
      {
        Exaption ex = new Exaption();
        ex.showPrecisionError();
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

    private void MainForm_Load(object sender, EventArgs e)
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

        /*
        FindIntersectionPoints2();
        FindIntersectionPoints3();
        */
      }
      else
      {
        Exaption ex = new Exaption();
        ex.showRestrictionsError();
      }
    }
  }
}
