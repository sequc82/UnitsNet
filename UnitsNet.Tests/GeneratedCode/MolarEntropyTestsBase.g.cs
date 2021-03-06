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
    /// Test of MolarEntropy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MolarEntropyTestsBase
    {
        protected abstract double JoulesPerMoleKelvinInOneJoulePerMoleKelvin { get; }
        protected abstract double KilojoulesPerMoleKelvinInOneJoulePerMoleKelvin { get; }
        protected abstract double MegajoulesPerMoleKelvinInOneJoulePerMoleKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double JoulesPerMoleKelvinTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerMoleKelvinTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerMoleKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarEntropy((double)0.0, MolarEntropyUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarEntropy(double.PositiveInfinity, MolarEntropyUnit.JoulePerMoleKelvin));
            Assert.Throws<ArgumentException>(() => new MolarEntropy(double.NegativeInfinity, MolarEntropyUnit.JoulePerMoleKelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarEntropy(double.NaN, MolarEntropyUnit.JoulePerMoleKelvin));
        }

        [Fact]
        public void JoulePerMoleKelvinToMolarEntropyUnits()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            AssertEx.EqualTolerance(JoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.KilojoulesPerMoleKelvin, KilojoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.MegajoulesPerMoleKelvin, MegajoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, MolarEntropy.From(1, MolarEntropyUnit.JoulePerMoleKelvin).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(1, MolarEntropy.From(1, MolarEntropyUnit.KilojoulePerMoleKelvin).KilojoulesPerMoleKelvin, KilojoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(1, MolarEntropy.From(1, MolarEntropyUnit.MegajoulePerMoleKelvin).MegajoulesPerMoleKelvin, MegajoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void FromJoulesPerMoleKelvin_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MolarEntropy.FromJoulesPerMoleKelvin(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => MolarEntropy.FromJoulesPerMoleKelvin(double.NegativeInfinity));
        }

        [Fact]
        public void FromJoulesPerMoleKelvin_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MolarEntropy.FromJoulesPerMoleKelvin(double.NaN));
        }

        [Fact]
        public void As()
        {
            var joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            AssertEx.EqualTolerance(JoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.As(MolarEntropyUnit.JoulePerMoleKelvin), JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.As(MolarEntropyUnit.KilojoulePerMoleKelvin), KilojoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleKelvinInOneJoulePerMoleKelvin, joulepermolekelvin.As(MolarEntropyUnit.MegajoulePerMoleKelvin), MegajoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);

            var joulepermolekelvinQuantity = joulepermolekelvin.ToUnit(MolarEntropyUnit.JoulePerMoleKelvin);
            AssertEx.EqualTolerance(JoulesPerMoleKelvinInOneJoulePerMoleKelvin, (double)joulepermolekelvinQuantity.Value, JoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.JoulePerMoleKelvin, joulepermolekelvinQuantity.Unit);

            var kilojoulepermolekelvinQuantity = joulepermolekelvin.ToUnit(MolarEntropyUnit.KilojoulePerMoleKelvin);
            AssertEx.EqualTolerance(KilojoulesPerMoleKelvinInOneJoulePerMoleKelvin, (double)kilojoulepermolekelvinQuantity.Value, KilojoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.KilojoulePerMoleKelvin, kilojoulepermolekelvinQuantity.Unit);

            var megajoulepermolekelvinQuantity = joulepermolekelvin.ToUnit(MolarEntropyUnit.MegajoulePerMoleKelvin);
            AssertEx.EqualTolerance(MegajoulesPerMoleKelvinInOneJoulePerMoleKelvin, (double)megajoulepermolekelvinQuantity.Value, MegajoulesPerMoleKelvinTolerance);
            Assert.Equal(MolarEntropyUnit.MegajoulePerMoleKelvin, megajoulepermolekelvinQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            AssertEx.EqualTolerance(1, MolarEntropy.FromJoulesPerMoleKelvin(joulepermolekelvin.JoulesPerMoleKelvin).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(1, MolarEntropy.FromKilojoulesPerMoleKelvin(joulepermolekelvin.KilojoulesPerMoleKelvin).JoulesPerMoleKelvin, KilojoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(1, MolarEntropy.FromMegajoulesPerMoleKelvin(joulepermolekelvin.MegajoulesPerMoleKelvin).JoulesPerMoleKelvin, MegajoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MolarEntropy v = MolarEntropy.FromJoulesPerMoleKelvin(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(2, (MolarEntropy.FromJoulesPerMoleKelvin(3)-v).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(2, (MolarEntropy.FromJoulesPerMoleKelvin(10)/5).JoulesPerMoleKelvin, JoulesPerMoleKelvinTolerance);
            AssertEx.EqualTolerance(2, MolarEntropy.FromJoulesPerMoleKelvin(10)/MolarEntropy.FromJoulesPerMoleKelvin(5), JoulesPerMoleKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MolarEntropy oneJoulePerMoleKelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            MolarEntropy twoJoulesPerMoleKelvin = MolarEntropy.FromJoulesPerMoleKelvin(2);

            Assert.True(oneJoulePerMoleKelvin < twoJoulesPerMoleKelvin);
            Assert.True(oneJoulePerMoleKelvin <= twoJoulesPerMoleKelvin);
            Assert.True(twoJoulesPerMoleKelvin > oneJoulePerMoleKelvin);
            Assert.True(twoJoulesPerMoleKelvin >= oneJoulePerMoleKelvin);

            Assert.False(oneJoulePerMoleKelvin > twoJoulesPerMoleKelvin);
            Assert.False(oneJoulePerMoleKelvin >= twoJoulesPerMoleKelvin);
            Assert.False(twoJoulesPerMoleKelvin < oneJoulePerMoleKelvin);
            Assert.False(twoJoulesPerMoleKelvin <= oneJoulePerMoleKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.Equal(0, joulepermolekelvin.CompareTo(joulepermolekelvin));
            Assert.True(joulepermolekelvin.CompareTo(MolarEntropy.Zero) > 0);
            Assert.True(MolarEntropy.Zero.CompareTo(joulepermolekelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.Throws<ArgumentException>(() => joulepermolekelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.Throws<ArgumentNullException>(() => joulepermolekelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = MolarEntropy.FromJoulesPerMoleKelvin(1);
            var b = MolarEntropy.FromJoulesPerMoleKelvin(2);

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
            var a = MolarEntropy.FromJoulesPerMoleKelvin(1);
            var b = MolarEntropy.FromJoulesPerMoleKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.True(v.Equals(MolarEntropy.FromJoulesPerMoleKelvin(1), JoulesPerMoleKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MolarEntropy.Zero, JoulesPerMoleKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.False(joulepermolekelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MolarEntropy joulepermolekelvin = MolarEntropy.FromJoulesPerMoleKelvin(1);
            Assert.False(joulepermolekelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MolarEntropyUnit.Undefined, MolarEntropy.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MolarEntropyUnit)).Cast<MolarEntropyUnit>();
            foreach(var unit in units)
            {
                if(unit == MolarEntropyUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MolarEntropy.BaseDimensions is null);
        }
    }
}
