using System;

namespace Calculator.Services
{
  public class CalculatorService
  {
    public int StringCalculator(string str)
    {
    
      if (String.IsNullOrEmpty(str))
      {
        return 0;
      }

      if (str.Contains(","))
      {
        string[] strings = str.Split(',');
        return Convert.ToInt32(strings[0]) + Convert.ToInt32(strings[1]);
      }
      if (str.Contains(" "))
      {
        string[] strings = str.Split(' ');
        return Convert.ToInt32(strings[0]) + Convert.ToInt32(strings[1]);
      }
      return Convert.ToInt32(str);
      //throw new NotImplementedException("Please create a test first");
    }
  }
}
