using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichotomyMethods
{
  public class Exaption
  {
    private string PrecisionError = "Точность указана неверно";
    private string DataEntryError = "Данные введены в неверном формате";
    private string RestrictionsError = "Начальная точка должна быть меньше конечной";

    public void showPrecisionError()
    {
      Console.WriteLine($"Ошибка: " + PrecisionError);
    }

    public void showDataEntryError()
    {
      Console.WriteLine($"Ошибка: " + DataEntryError);
    }

    public void showRestrictionsError()
    {
      Console.WriteLine($"Ошибка: " + RestrictionsError);
    }
  }
}
