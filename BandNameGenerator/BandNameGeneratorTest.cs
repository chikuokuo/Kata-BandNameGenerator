﻿using System;
using System.Linq;
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

        [TestMethod]
        public void Input_Testing_ShouldReturn_The_Testing()
        {
            GenerateBandNameShouldEqual("Testing", "The Testing");
        }

        [TestMethod]
        public void Input_testing_ShouldReturn_The_Testing()
        {
            GenerateBandNameShouldEqual("testing", "The Testing");
        }

        [TestMethod]
        public void Input_test_ShouldReturn_Testest()
        {
            GenerateBandNameShouldEqual("test", "Testest");
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
            if (string.IsNullOrEmpty(name))
            {
                return "";
            }
            return string.Equals(name.First(), name.Last()) ? FirstCharToUpper(name) + name.Substring(1) : "The " + FirstCharToUpper(name);
        }

        private string FirstCharToUpper(string name)
        {
            return char.ToUpper(name.First()) + name.Substring(1);
        }
    }
}
