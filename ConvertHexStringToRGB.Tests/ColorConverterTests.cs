using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ConvertHexStringToRGB.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestCase("#FF9933", ExpectedResult = 255, 153, 51)]
        public RGBColor ColorConverTests(string hexColor) => ColorConverter.HexStringToRGB(hexColor);
}
}
