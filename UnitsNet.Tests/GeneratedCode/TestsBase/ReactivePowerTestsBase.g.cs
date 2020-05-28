﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ReactivePower.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ReactivePowerTestsBase
    {
        protected abstract double GigavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double KilovoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double MegavoltamperesReactiveInOneVoltampereReactive { get; }
        protected abstract double VoltamperesReactiveInOneVoltampereReactive { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GigavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double KilovoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double MegavoltamperesReactiveTolerance { get { return 1e-5; } }
        protected virtual double VoltamperesReactiveTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower((double)0.0, ReactivePowerUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ReactivePower();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ReactivePowerUnit.VoltampereReactive, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.PositiveInfinity, ReactivePowerUnit.VoltampereReactive));
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.NegativeInfinity, ReactivePowerUnit.VoltampereReactive));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactivePower(double.NaN, ReactivePowerUnit.VoltampereReactive));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ReactivePower(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void ReactivePower_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ReactivePower(1, ReactivePowerUnit.VoltampereReactive);

            QuantityInfo<ReactivePowerUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ReactivePower.Zero, quantityInfo.Zero);
            Assert.Equal("ReactivePower", quantityInfo.Name);
            Assert.Equal(QuantityType.ReactivePower, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ReactivePowerUnit>().Except(new[] {ReactivePowerUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void VoltampereReactiveToReactivePowerUnits()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(GigavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.GigavoltamperesReactive, GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, voltamperereactive.VoltamperesReactive, VoltamperesReactiveTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ReactivePower.From(1, ReactivePowerUnit.GigavoltampereReactive);
            AssertEx.EqualTolerance(1, quantity00.GigavoltamperesReactive, GigavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.GigavoltampereReactive, quantity00.Unit);

            var quantity01 = ReactivePower.From(1, ReactivePowerUnit.KilovoltampereReactive);
            AssertEx.EqualTolerance(1, quantity01.KilovoltamperesReactive, KilovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.KilovoltampereReactive, quantity01.Unit);

            var quantity02 = ReactivePower.From(1, ReactivePowerUnit.MegavoltampereReactive);
            AssertEx.EqualTolerance(1, quantity02.MegavoltamperesReactive, MegavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.MegavoltampereReactive, quantity02.Unit);

            var quantity03 = ReactivePower.From(1, ReactivePowerUnit.VoltampereReactive);
            AssertEx.EqualTolerance(1, quantity03.VoltamperesReactive, VoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.VoltampereReactive, quantity03.Unit);

        }

        [Fact]
        public void FromVoltamperesReactive_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltamperesReactive_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactivePower.FromVoltamperesReactive(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(GigavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.GigavoltampereReactive), GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.KilovoltampereReactive), KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.MegavoltampereReactive), MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, voltamperereactive.As(ReactivePowerUnit.VoltampereReactive), VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var voltamperereactive = ReactivePower.FromVoltamperesReactive(1);

            var gigavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.GigavoltampereReactive);
            AssertEx.EqualTolerance(GigavoltamperesReactiveInOneVoltampereReactive, (double)gigavoltamperereactiveQuantity.Value, GigavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.GigavoltampereReactive, gigavoltamperereactiveQuantity.Unit);

            var kilovoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.KilovoltampereReactive);
            AssertEx.EqualTolerance(KilovoltamperesReactiveInOneVoltampereReactive, (double)kilovoltamperereactiveQuantity.Value, KilovoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.KilovoltampereReactive, kilovoltamperereactiveQuantity.Unit);

            var megavoltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.MegavoltampereReactive);
            AssertEx.EqualTolerance(MegavoltamperesReactiveInOneVoltampereReactive, (double)megavoltamperereactiveQuantity.Value, MegavoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.MegavoltampereReactive, megavoltamperereactiveQuantity.Unit);

            var voltamperereactiveQuantity = voltamperereactive.ToUnit(ReactivePowerUnit.VoltampereReactive);
            AssertEx.EqualTolerance(VoltamperesReactiveInOneVoltampereReactive, (double)voltamperereactiveQuantity.Value, VoltamperesReactiveTolerance);
            Assert.Equal(ReactivePowerUnit.VoltampereReactive, voltamperereactiveQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(1, ReactivePower.FromGigavoltamperesReactive(voltamperereactive.GigavoltamperesReactive).VoltamperesReactive, GigavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromKilovoltamperesReactive(voltamperereactive.KilovoltamperesReactive).VoltamperesReactive, KilovoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromMegavoltamperesReactive(voltamperereactive.MegavoltamperesReactive).VoltamperesReactive, MegavoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(1, ReactivePower.FromVoltamperesReactive(voltamperereactive.VoltamperesReactive).VoltamperesReactive, VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ReactivePower v = ReactivePower.FromVoltamperesReactive(1);
            AssertEx.EqualTolerance(-1, -v.VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (ReactivePower.FromVoltamperesReactive(3)-v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, (ReactivePower.FromVoltamperesReactive(10)/5).VoltamperesReactive, VoltamperesReactiveTolerance);
            AssertEx.EqualTolerance(2, ReactivePower.FromVoltamperesReactive(10)/ReactivePower.FromVoltamperesReactive(5), VoltamperesReactiveTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ReactivePower oneVoltampereReactive = ReactivePower.FromVoltamperesReactive(1);
            ReactivePower twoVoltamperesReactive = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(oneVoltampereReactive < twoVoltamperesReactive);
            Assert.True(oneVoltampereReactive <= twoVoltamperesReactive);
            Assert.True(twoVoltamperesReactive > oneVoltampereReactive);
            Assert.True(twoVoltamperesReactive >= oneVoltampereReactive);

            Assert.False(oneVoltampereReactive > twoVoltamperesReactive);
            Assert.False(oneVoltampereReactive >= twoVoltamperesReactive);
            Assert.False(twoVoltamperesReactive < oneVoltampereReactive);
            Assert.False(twoVoltamperesReactive <= oneVoltampereReactive);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Equal(0, voltamperereactive.CompareTo(voltamperereactive));
            Assert.True(voltamperereactive.CompareTo(ReactivePower.Zero) > 0);
            Assert.True(ReactivePower.Zero.CompareTo(voltamperereactive) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentException>(() => voltamperereactive.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentNullException>(() => voltamperereactive.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ReactivePower.FromVoltamperesReactive(1);
            var b = ReactivePower.FromVoltamperesReactive(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = ReactivePower.FromVoltamperesReactive(1);
            var b = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ReactivePower.FromVoltamperesReactive(1);
            object b = ReactivePower.FromVoltamperesReactive(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ReactivePower.FromVoltamperesReactive(1);
            Assert.True(v.Equals(ReactivePower.FromVoltamperesReactive(1), VoltamperesReactiveTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ReactivePower.Zero, VoltamperesReactiveTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ReactivePower.FromVoltamperesReactive(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ReactivePower.FromVoltamperesReactive(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.False(voltamperereactive.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ReactivePower voltamperereactive = ReactivePower.FromVoltamperesReactive(1);
            Assert.False(voltamperereactive.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ReactivePowerUnit.Undefined, ReactivePower.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ReactivePowerUnit)).Cast<ReactivePowerUnit>();
            foreach(var unit in units)
            {
                if(unit == ReactivePowerUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ReactivePower.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 Gvar", new ReactivePower(1, ReactivePowerUnit.GigavoltampereReactive).ToString());
                Assert.Equal("1 kvar", new ReactivePower(1, ReactivePowerUnit.KilovoltampereReactive).ToString());
                Assert.Equal("1 Mvar", new ReactivePower(1, ReactivePowerUnit.MegavoltampereReactive).ToString());
                Assert.Equal("1 var", new ReactivePower(1, ReactivePowerUnit.VoltampereReactive).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 Gvar", new ReactivePower(1, ReactivePowerUnit.GigavoltampereReactive).ToString(swedishCulture));
            Assert.Equal("1 kvar", new ReactivePower(1, ReactivePowerUnit.KilovoltampereReactive).ToString(swedishCulture));
            Assert.Equal("1 Mvar", new ReactivePower(1, ReactivePowerUnit.MegavoltampereReactive).ToString(swedishCulture));
            Assert.Equal("1 var", new ReactivePower(1, ReactivePowerUnit.VoltampereReactive).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s1"));
                Assert.Equal("0.12 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s2"));
                Assert.Equal("0.123 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s3"));
                Assert.Equal("0.1235 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s1", culture));
            Assert.Equal("0.12 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s2", culture));
            Assert.Equal("0.123 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s3", culture));
            Assert.Equal("0.1235 var", new ReactivePower(0.123456, ReactivePowerUnit.VoltampereReactive).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ReactivePower)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ReactivePowerUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(QuantityType.ReactivePower, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(ReactivePower.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ReactivePower.FromVoltamperesReactive(1.0);
            Assert.Equal(new {ReactivePower.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ReactivePower.FromVoltamperesReactive(value);
            Assert.Equal(ReactivePower.FromVoltamperesReactive(-value), -quantity);
        }

    }
}
