using System.Collections.Generic;
using NUnit.Framework;

namespace lab_basics
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1_1()
        {
            var input = new List<object> {1, 23 , "unit tests", 4567835, 'r'};
            var output = Functions.GetIntegersFromList(input);
            var expected = new List<int> {1, 23, 4567835};
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test1_2()
        {
            var input = new List<object> {'5', "hello world", 45};
            var output = Functions.GetIntegersFromList(input);
            var expected = new List<int> {45};
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test2_1()
        {
            string output = Functions.first_non_repeating_letter("HEllo WoRlD");
            string expected = "H";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test2_2()
        {
            string output = Functions.first_non_repeating_letter("hheelllloo");
            string expected = "";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test3_1()
        {
            int output = Functions.DigitalRoot(45);
            int expected = 9;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test3_2()
        {
            int output = Functions.DigitalRoot(45783);
            int expected = 9;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test4_1()
        {
            int output = Functions.CountPairs(new int[]{1, 3, 6, 2, 2, 0, 4, 5}, 5);
            int expected = 4;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test4_2()
        {
            int output = Functions.CountPairs(new int[]{1, 3, 4, 5, 8, 6, 2}, 8);
            int expected = 2;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test5_1()
        {
            string output = Functions.SortFriends("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test5_2()
        {
            string output = Functions.SortFriends("Yeva:Koldovska;John:Smith;Bree:Kamp;Gabrielle:Solis");
            string expected = "(KAMP, BREE)(KOLDOVSKA, YEVA)(SMITH, JOHN)(SOLIS, GABRIELLE)";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test6_1()
        {
            int output = Functions.NextBiggerNumber(4567);
            int expected = 4576;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test6_2()
        {
            int output = Functions.NextBiggerNumber(12);
            int expected = 21;
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test7_1()
        {
            string output = Functions.NumToIpv4(2149583361);
            string expected = "128.32.10.1";
            Assert.AreEqual(expected, output);
        }
        
        [Test]
        public void Test7_2()
        {
            string output = Functions.NumToIpv4(32);
            string expected = "0.0.0.32";
            Assert.AreEqual(expected, output);
        }
    }
}