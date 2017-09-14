using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BandNameGenerator
{
    [TestClass]
    public class BandNameGeneratorTest
    {
        //My friend wants a new band name for her band. She like bands that use the formula: 'The' + a noun with first letter 
        //capitalized.

        //dolphin -> The Dolphin

        //However, when a noun STARTS and ENDS with the same letter, she likes to repeat the noun twice 
        //and connect them together with the first and last letter, combined into one word like so (WITHOUT a 'The' in front):

        //alaska -> Alaskalaska

        //europe -> Europeurope

        //Can you write a function that takes in a noun as a string, and returns her preferred band name written as a string?
        [TestMethod]
        public void Input_Empty_ShouldReturn_StringEmpty()
        {
            GenerateBandNameShouldEqual(string.Empty, string.Empty);
        }

        private static void GenerateBandNameShouldEqual(string input, string expected)
        {
            BandNameGenerator bandNameGenerator = new BandNameGenerator();
            var result = bandNameGenerator.GenerateBandName(input);
            Assert.AreEqual(expected, result);
        }
    }

    public class BandNameGenerator
    {
        public string GenerateBandName(string name)
        {
            return "";
        }
    }
}
