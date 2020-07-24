﻿// Copyright (c) 2020 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using JuliusSweetland.OptiKey.Extensions;
using JuliusSweetland.OptiKey.UnitTests.Properties;
using NUnit.Framework;

namespace JuliusSweetland.OptiKey.UnitTests.Extensions
{
    [TestFixture]
    public class DoubleExtensionsTests
    {
        [SetUp]
        public void BaseSetUp()
        {
            Settings.Initialise();
        }

        [Test]
        public void TestCoerceToUpperLimit()
        {
            Assert.AreEqual(10, 100.5.CoerceToUpperLimit(10));
            Assert.AreEqual(50.5, 50.5.CoerceToUpperLimit(100));
        }

        [Test]
        public void TestCoerceToLowerLimit()
        {
            Assert.AreEqual(100.5, 100.5.CoerceToLowerLimit(10));
            Assert.AreEqual(100, 50.5.CoerceToLowerLimit(100));
        }

    }
}
