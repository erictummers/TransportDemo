// <copyright file="AutoIntelliTest.cs" company="Microsoft">Copyright © Microsoft 2014</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voertuig;

namespace Voertuig.intellitest
{
    /// <summary>This class contains parameterized unit tests for Auto</summary>
    [PexClass(typeof(Auto))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public partial class AutoIntelliTest
    {
        /// <summary>Test stub for Vooruit()</summary>
        [PexMethod]
        [PexAllowedExceptionFromType(typeof(Ongeluk), typeof(NaarAchteren))]
        public void VooruitIntelliTest([PexAssumeUnderTest]Auto target)
        {
            target.Vooruit();
            // TODO: add assertions to method AutoIntelliTest.VooruitIntelliTest(Auto)
            Assert.IsInstanceOfType(target.Verplaatsing, typeof(NaarVoren));
        }

        /// <summary>Test stub for Achteruit()</summary>
        [PexMethod]
        [PexAllowedExceptionFromType(typeof(Ongeluk), typeof(NaarVoren))]
        public void AchteruitIntelliTest([PexAssumeUnderTest]Auto target)
        {
            target.Achteruit();
            // TODO: add assertions to method AutoIntelliTest.AchteruitIntelliTest(Auto)
            Assert.IsInstanceOfType(target.Verplaatsing, typeof(NaarAchteren));
        }

        /// <summary>Test stub for Stop()</summary>
        [PexMethod]
        public void StopIntelliTest([PexAssumeUnderTest]Auto target)
        {
            target.Stop();
            // TODO: add assertions to method AutoIntelliTest.StopIntelliTest(Auto)
            Assert.IsInstanceOfType(target.Verplaatsing, typeof(Stilstand));
        }
    }
}
