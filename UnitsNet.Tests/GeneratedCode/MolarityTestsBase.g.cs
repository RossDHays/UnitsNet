﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using NUnit.Framework;
using UnitsNet.Units;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Molarity.
    /// </summary>
    [TestFixture]
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MolarityTestsBase
    {
        protected abstract double CentimolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double DecimolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double MicromolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double MillimolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double MolesPerCubicMeterInOneMolesPerCubicMeter { get; }
        protected abstract double MolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double NanomolesPerLiterInOneMolesPerCubicMeter { get; }
        protected abstract double PicomolesPerLiterInOneMolesPerCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double DecimolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MicromolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MillimolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MolesPerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double MolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double NanomolesPerLiterTolerance { get { return 1e-5; } }
        protected virtual double PicomolesPerLiterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Test]
        public void MolesPerCubicMeterToMolarityUnits()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.AreEqual(CentimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.CentimolesPerLiter, CentimolesPerLiterTolerance);
            Assert.AreEqual(DecimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.DecimolesPerLiter, DecimolesPerLiterTolerance);
            Assert.AreEqual(MicromolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.MicromolesPerLiter, MicromolesPerLiterTolerance);
            Assert.AreEqual(MillimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.MillimolesPerLiter, MillimolesPerLiterTolerance);
            Assert.AreEqual(MolesPerCubicMeterInOneMolesPerCubicMeter, molespercubicmeter.MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(MolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.MolesPerLiter, MolesPerLiterTolerance);
            Assert.AreEqual(NanomolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.NanomolesPerLiter, NanomolesPerLiterTolerance);
            Assert.AreEqual(PicomolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.PicomolesPerLiter, PicomolesPerLiterTolerance);
        }

        [Test]
        public void FromValueAndUnit()
        {
            Assert.AreEqual(1, Molarity.From(1, MolarityUnit.CentimolesPerLiter).CentimolesPerLiter, CentimolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.From(1, MolarityUnit.DecimolesPerLiter).DecimolesPerLiter, DecimolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.From(1, MolarityUnit.MicromolesPerLiter).MicromolesPerLiter, MicromolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.From(1, MolarityUnit.MillimolesPerLiter).MillimolesPerLiter, MillimolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.From(1, MolarityUnit.MolesPerCubicMeter).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(1, Molarity.From(1, MolarityUnit.MolesPerLiter).MolesPerLiter, MolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.From(1, MolarityUnit.NanomolesPerLiter).NanomolesPerLiter, NanomolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.From(1, MolarityUnit.PicomolesPerLiter).PicomolesPerLiter, PicomolesPerLiterTolerance);
        }

        [Test]
        public void As()
        {
            var molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.AreEqual(CentimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.CentimolesPerLiter), CentimolesPerLiterTolerance);
            Assert.AreEqual(DecimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.DecimolesPerLiter), DecimolesPerLiterTolerance);
            Assert.AreEqual(MicromolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.MicromolesPerLiter), MicromolesPerLiterTolerance);
            Assert.AreEqual(MillimolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.MillimolesPerLiter), MillimolesPerLiterTolerance);
            Assert.AreEqual(MolesPerCubicMeterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.MolesPerCubicMeter), MolesPerCubicMeterTolerance);
            Assert.AreEqual(MolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.MolesPerLiter), MolesPerLiterTolerance);
            Assert.AreEqual(NanomolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.NanomolesPerLiter), NanomolesPerLiterTolerance);
            Assert.AreEqual(PicomolesPerLiterInOneMolesPerCubicMeter, molespercubicmeter.As(MolarityUnit.PicomolesPerLiter), PicomolesPerLiterTolerance);
        }

        [Test]
        public void ConversionRoundTrip()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.AreEqual(1, Molarity.FromCentimolesPerLiter(molespercubicmeter.CentimolesPerLiter).MolesPerCubicMeter, CentimolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.FromDecimolesPerLiter(molespercubicmeter.DecimolesPerLiter).MolesPerCubicMeter, DecimolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.FromMicromolesPerLiter(molespercubicmeter.MicromolesPerLiter).MolesPerCubicMeter, MicromolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.FromMillimolesPerLiter(molespercubicmeter.MillimolesPerLiter).MolesPerCubicMeter, MillimolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.FromMolesPerCubicMeter(molespercubicmeter.MolesPerCubicMeter).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(1, Molarity.FromMolesPerLiter(molespercubicmeter.MolesPerLiter).MolesPerCubicMeter, MolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.FromNanomolesPerLiter(molespercubicmeter.NanomolesPerLiter).MolesPerCubicMeter, NanomolesPerLiterTolerance);
            Assert.AreEqual(1, Molarity.FromPicomolesPerLiter(molespercubicmeter.PicomolesPerLiter).MolesPerCubicMeter, PicomolesPerLiterTolerance);
        }

        [Test]
        public void ArithmeticOperators()
        {
            Molarity v = Molarity.FromMolesPerCubicMeter(1);
            Assert.AreEqual(-1, -v.MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(2, (Molarity.FromMolesPerCubicMeter(3)-v).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(2, (v + v).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(10, (v*10).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(10, (10*v).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(2, (Molarity.FromMolesPerCubicMeter(10)/5).MolesPerCubicMeter, MolesPerCubicMeterTolerance);
            Assert.AreEqual(2, Molarity.FromMolesPerCubicMeter(10)/Molarity.FromMolesPerCubicMeter(5), MolesPerCubicMeterTolerance);
        }

        [Test]
        public void ComparisonOperators()
        {
            Molarity oneMolesPerCubicMeter = Molarity.FromMolesPerCubicMeter(1);
            Molarity twoMolesPerCubicMeter = Molarity.FromMolesPerCubicMeter(2);

            Assert.True(oneMolesPerCubicMeter < twoMolesPerCubicMeter);
            Assert.True(oneMolesPerCubicMeter <= twoMolesPerCubicMeter);
            Assert.True(twoMolesPerCubicMeter > oneMolesPerCubicMeter);
            Assert.True(twoMolesPerCubicMeter >= oneMolesPerCubicMeter);

            Assert.False(oneMolesPerCubicMeter > twoMolesPerCubicMeter);
            Assert.False(oneMolesPerCubicMeter >= twoMolesPerCubicMeter);
            Assert.False(twoMolesPerCubicMeter < oneMolesPerCubicMeter);
            Assert.False(twoMolesPerCubicMeter <= oneMolesPerCubicMeter);
        }

        [Test]
        public void CompareToIsImplemented()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.AreEqual(0, molespercubicmeter.CompareTo(molespercubicmeter));
            Assert.Greater(molespercubicmeter.CompareTo(Molarity.Zero), 0);
            Assert.Less(Molarity.Zero.CompareTo(molespercubicmeter), 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CompareToThrowsOnTypeMismatch()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            molespercubicmeter.CompareTo(new object());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareToThrowsOnNull()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            molespercubicmeter.CompareTo(null);
        }


        [Test]
        public void EqualityOperators()
        {
            Molarity a = Molarity.FromMolesPerCubicMeter(1);
            Molarity b = Molarity.FromMolesPerCubicMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Test]
        public void EqualsIsImplemented()
        {
            Molarity v = Molarity.FromMolesPerCubicMeter(1);
            Assert.IsTrue(v.Equals(Molarity.FromMolesPerCubicMeter(1)));
            Assert.IsFalse(v.Equals(Molarity.Zero));
        }

        [Test]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.IsFalse(molespercubicmeter.Equals(new object()));
        }

        [Test]
        public void EqualsReturnsFalseOnNull()
        {
            Molarity molespercubicmeter = Molarity.FromMolesPerCubicMeter(1);
            Assert.IsFalse(molespercubicmeter.Equals(null));
        }
    }
}