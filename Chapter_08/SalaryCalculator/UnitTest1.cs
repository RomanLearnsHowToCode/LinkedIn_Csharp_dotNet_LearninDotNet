using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorFinal;

namespace SalaryCalculatorTestProject
{
    /* REQUIREMENTS REFERENCE
     To get hourly, divide annual salary by 2080
    $100,006.40 / 2080 = $48.08 hr

    To get annual, multiply hourly by 2080
    $48.08 * 2080 = $100,006.40
     */

    /*
    RED - setting failing test
    GREEN - setting passing test
    REFACTOR - update code and retesting again
     */

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange - setting variables
            SalaryCalculator sc = new SalaryCalculator();
            // Act - setting logic
            decimal annaulSalary = sc.GetAnnualSalary(50);
            // Assert - testing logic and results expected
            Assert.AreEqual(10400, annaulSalary);
        }
    }
}
