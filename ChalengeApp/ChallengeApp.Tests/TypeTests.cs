
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace ChalengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestIntValueAreEqual()
        {
            // arrange
            int number1 = 2;
            int number2 = 2;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void TestFloatTwoValueSumAreEqual()
        {
            // arrange
            float value1 = -4 ;
            float value2 = 2;
            float value3 = -2;
            float value4 = 0;
            float sum1 = value1 + value2;
            float sum2 = value3 + value4;
            // act

            // assert
            Assert.AreEqual(sum1, sum2);
        }

        [Test]
        public void TwoStringAreEqual()
        {
            // arrange
            var user1 = GetUser("Tomasz");
            var user2 = GetUser("Tomasz");

            // act

            // assert
             Assert.AreEqual(user1.Name , user2.Name);
           
        }
        
        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}
