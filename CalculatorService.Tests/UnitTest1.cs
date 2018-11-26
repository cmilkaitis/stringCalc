using NUnit.Framework;
using System;
using Calculator.Services;

namespace Calculator.UnitTests.Services
{
  public class Tests
  {

    [Test]
    public void ReturnZeroGivenEmptyString()
    {
      CalculatorService _calculatorService = new CalculatorService();
      string str = "";
      var result = _calculatorService.StringCalculator(str);
      var expectedResult = 0;
      Assert.AreEqual(expectedResult, result);
    }
    [Test]
    public void ReturnValueGivenSingleNumber()
    {
      CalculatorService _calculatorService = new CalculatorService();
      string str = "2";
      var result = _calculatorService.StringCalculator(str);
      var expectedResult = 2;
      Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void ReturnSumGivenTwoNumbersCommaDelimited()
    {
      CalculatorService _calculatorService = new CalculatorService();
      string str = "3,3";
      var expectedResult = 6;
      var result = _calculatorService.StringCalculator(str);
      Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void ReturnSumGivenTwoNumbersNewlineDelimited()
    {
      CalculatorService _calculatorService = new CalculatorService();
      string str = "2 10";
      var expectedResult = 12;
      var result = _calculatorService.StringCalculator(str);
      Assert.AreEqual(expectedResult, result);
    }
  }
}