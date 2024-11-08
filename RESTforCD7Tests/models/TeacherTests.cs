using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTforCD7.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTforCD7.models.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod]
        public void ValidateSalaryTest()
        {
            Teacher teacherSalaryPositive = new() { Salary = -1 };
            Teacher teacherSalaryZero = new() { Salary = 0 };
            Teacher teacherSalaryNegative = new() { Salary = -1 };
            teacherSalaryPositive.ValidateSalary();
            teacherSalaryZero.ValidateSalary();
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => teacherSalaryNegative.ValidateSalary());
        }
    }
}