﻿namespace StringMathCalculator.Calculations
{

    /// <summary>
    /// A stored Operation that requires a pair of numbers to calculate.
    /// </summary>
    /// 
    class OperationPair : OperationCalc
    {
        public int Weight { get; private set; }
        public CalculationPair CalcPair { get; private set; }
        
        public OperationPair(double x, int weight, CalculationPair calcPair) :
            base(x)
        {
            Weight = weight;
            CalcPair = calcPair;
        }
    }
}
