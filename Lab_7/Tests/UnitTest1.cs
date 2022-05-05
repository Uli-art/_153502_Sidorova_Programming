using Xunit;
using System;

namespace Task_1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            char[] chars = { 'f', 'g', '3', 'e', 'r', '6' };
            Multiplicitycs first = new Multiplicitycs(chars);
            Multiplicitycs second = new Multiplicitycs(chars);

            Assert.Equal(first.getArray(), second.getArray());
            Assert.True(first == second);
            Assert.False(first != second);

            char[] chars1 = { '2', '3', '4', '5', '6', '7' };
            Multiplicitycs third = new Multiplicitycs(chars1);
            Multiplicitycs fourth = new Multiplicitycs(chars1);

            Multiplicitycs test = new Multiplicitycs();

            third = third + fourth;
            string stringTest = "468:<>";
            test = (Multiplicitycs)stringTest;
            Assert.Equal(test.getArray(), third.getArray());

            third = third - fourth;
            stringTest = "234567";
            test = (Multiplicitycs)stringTest;
            Assert.Equal(test.getArray(), third.getArray());

            third = third* fourth;
            stringTest = "49@ITa";
            test = (Multiplicitycs)stringTest;
            Assert.Equal(test.getArray(), third.getArray());

            char[] chars2 = { 'f', 'g', 'g', 'e', 'r', '6' };
            Multiplicitycs fifth = new Multiplicitycs(chars2);
            bool t;
            
            if (fifth)
            {
                t = true;
            }
            else
            {
                t = false;
            }
            Assert.False(t);

            string text = "";
            text = first;
            string te = "fg3er6";
            Assert.Equal(text, te);
            second = (Multiplicitycs)text;
            Assert.Equal(first.getArray(), second.getArray());

        }
    }
}