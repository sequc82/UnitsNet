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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricCurrent.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricCurrentTestsBase
    {
        protected abstract double AmperesInOneAmpere { get; }
        protected abstract double CentiamperesInOneAmpere { get; }
        protected abstract double KiloamperesInOneAmpere { get; }
        protected abstract double MegaamperesInOneAmpere { get; }
        protected abstract double MicroamperesInOneAmpere { get; }
        protected abstract double MilliamperesInOneAmpere { get; }
        protected abstract double NanoamperesInOneAmpere { get; }
        protected abstract double PicoamperesInOneAmpere { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesTolerance { get { return 1e-5; } }
        protected virtual double CentiamperesTolerance { get { return 1e-5; } }
        protected virtual double KiloamperesTolerance { get { return 1e-5; } }
        protected virtual double MegaamperesTolerance { get { return 1e-5; } }
        protected virtual double MicroamperesTolerance { get { return 1e-5; } }
        protected virtual double MilliamperesTolerance { get { return 1e-5; } }
        protected virtual double NanoamperesTolerance { get { return 1e-5; } }
        protected virtual double PicoamperesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrent((double)0.0, ElectricCurrentUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrent(double.PositiveInfinity, ElectricCurrentUnit.Ampere));
            Assert.Throws<ArgumentException>(() => new ElectricCurrent(double.NegativeInfinity, ElectricCurrentUnit.Ampere));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrent(double.NaN, ElectricCurrentUnit.Ampere));
        }

        [Fact]
        public void AmpereToElectricCurrentUnits()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(AmperesInOneAmpere, ampere.Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(CentiamperesInOneAmpere, ampere.Centiamperes, CentiamperesTolerance);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, ampere.Kiloamperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, ampere.Megaamperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, ampere.Microamperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, ampere.Milliamperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, ampere.Nanoamperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, ampere.Picoamperes, PicoamperesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Ampere).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Centiampere).Centiamperes, CentiamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Kiloampere).Kiloamperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Megaampere).Megaamperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Microampere).Microamperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Milliampere).Milliamperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Nanoampere).Nanoamperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Picoampere).Picoamperes, PicoamperesTolerance);
        }

        [Fact]
        public void FromAmperes_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricCurrent.FromAmperes(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricCurrent.FromAmperes(double.NegativeInfinity));
        }

        [Fact]
        public void FromAmperes_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricCurrent.FromAmperes(double.NaN));
        }

        [Fact]
        public void As()
        {
            var ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(AmperesInOneAmpere, ampere.As(ElectricCurrentUnit.Ampere), AmperesTolerance);
            AssertEx.EqualTolerance(CentiamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Centiampere), CentiamperesTolerance);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Kiloampere), KiloamperesTolerance);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Megaampere), MegaamperesTolerance);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Microampere), MicroamperesTolerance);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Milliampere), MilliamperesTolerance);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Nanoampere), NanoamperesTolerance);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Picoampere), PicoamperesTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var ampere = ElectricCurrent.FromAmperes(1);

            var ampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Ampere);
            AssertEx.EqualTolerance(AmperesInOneAmpere, (double)ampereQuantity.Value, AmperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Ampere, ampereQuantity.Unit);

            var centiampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Centiampere);
            AssertEx.EqualTolerance(CentiamperesInOneAmpere, (double)centiampereQuantity.Value, CentiamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Centiampere, centiampereQuantity.Unit);

            var kiloampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Kiloampere);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, (double)kiloampereQuantity.Value, KiloamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Kiloampere, kiloampereQuantity.Unit);

            var megaampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Megaampere);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, (double)megaampereQuantity.Value, MegaamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Megaampere, megaampereQuantity.Unit);

            var microampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Microampere);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, (double)microampereQuantity.Value, MicroamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Microampere, microampereQuantity.Unit);

            var milliampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Milliampere);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, (double)milliampereQuantity.Value, MilliamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Milliampere, milliampereQuantity.Unit);

            var nanoampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Nanoampere);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, (double)nanoampereQuantity.Value, NanoamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Nanoampere, nanoampereQuantity.Unit);

            var picoampereQuantity = ampere.ToUnit(ElectricCurrentUnit.Picoampere);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, (double)picoampereQuantity.Value, PicoamperesTolerance);
            Assert.Equal(ElectricCurrentUnit.Picoampere, picoampereQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromAmperes(ampere.Amperes).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromCentiamperes(ampere.Centiamperes).Amperes, CentiamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromKiloamperes(ampere.Kiloamperes).Amperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMegaamperes(ampere.Megaamperes).Amperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMicroamperes(ampere.Microamperes).Amperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMilliamperes(ampere.Milliamperes).Amperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromNanoamperes(ampere.Nanoamperes).Amperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromPicoamperes(ampere.Picoamperes).Amperes, PicoamperesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCurrent v = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(-1, -v.Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrent.FromAmperes(3)-v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrent.FromAmperes(10)/5).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, ElectricCurrent.FromAmperes(10)/ElectricCurrent.FromAmperes(5), AmperesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCurrent oneAmpere = ElectricCurrent.FromAmperes(1);
            ElectricCurrent twoAmperes = ElectricCurrent.FromAmperes(2);

            Assert.True(oneAmpere < twoAmperes);
            Assert.True(oneAmpere <= twoAmperes);
            Assert.True(twoAmperes > oneAmpere);
            Assert.True(twoAmperes >= oneAmpere);

            Assert.False(oneAmpere > twoAmperes);
            Assert.False(oneAmpere >= twoAmperes);
            Assert.False(twoAmperes < oneAmpere);
            Assert.False(twoAmperes <= oneAmpere);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Equal(0, ampere.CompareTo(ampere));
            Assert.True(ampere.CompareTo(ElectricCurrent.Zero) > 0);
            Assert.True(ElectricCurrent.Zero.CompareTo(ampere) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentException>(() => ampere.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentNullException>(() => ampere.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricCurrent.FromAmperes(1);
            var b = ElectricCurrent.FromAmperes(2);

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
        public void EqualsIsImplemented()
        {
            var a = ElectricCurrent.FromAmperes(1);
            var b = ElectricCurrent.FromAmperes(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ElectricCurrent.FromAmperes(1);
            Assert.True(v.Equals(ElectricCurrent.FromAmperes(1), AmperesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricCurrent.Zero, AmperesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.False(ampere.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.False(ampere.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricCurrentUnit.Undefined, ElectricCurrent.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricCurrentUnit)).Cast<ElectricCurrentUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricCurrentUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricCurrent.BaseDimensions is null);
        }
    }
}
