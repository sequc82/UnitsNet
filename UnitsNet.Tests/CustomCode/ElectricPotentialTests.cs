﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class ElectricPotentialTests : ElectricPotentialTestsBase
    {
        protected override double MicrovoltsInOneVolt => 1e6;

        protected override double MillivoltsInOneVolt => 1e3;

        protected override double VoltsInOneVolt => 1;

        protected override double KilovoltsInOneVolt => 1e-3;

        protected override double MegavoltsInOneVolt => 1e-6;

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(0, int.MaxValue, 0)]
        [InlineData(10, 2, 5)]
        [InlineData(-10, 2, -5)]
        [InlineData(-10, -2, 5)]
        public void ElectricPotentialDividedByElectricCurrentEqualsElectricResistance(float potential, float current, float expected)
        {
            var resistance = ElectricPotential.FromVolts(potential) / ElectricCurrent.FromAmperes(current);
            Assert.Equal(expected, resistance.Ohms);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(0, int.MaxValue, 0)]
        [InlineData(10, 2, 5)]
        [InlineData(-10, 2, -5)]
        [InlineData(-10, -2, 5)]
        public void ElectricPotentialDividedByElectricResistanceEqualsElectricCurrent(float potential, float resistance, float expected)
        {
            var current = ElectricPotential.FromVolts(potential) / ElectricResistance.FromOhms(resistance);
            Assert.Equal(expected, current.Amperes);
        }
    }
}
