using Models.Generics.Exceptions;
using System;
using System.Diagnostics.Contracts;

namespace Models.Generics.ValueObjects
{
    /*
     * Used to describe the proportion of an activity when calculating the subject's average
     */
    public class Proportion
    {
        private int _numerator;
        private int _denominator;
        public decimal Fraction { get { return _numerator / _denominator; } }

        public Proportion(int numerator, int denominator)
        {
            Contract.Requires(numerator > 0, "Numerator must be positive!");
            Contract.Requires(denominator > 0, "Denominator must be positive!");
            Contract.Requires<HighNumeratorException>(numerator < denominator, "Numerator is higher than denominator!");

            _numerator = numerator;
            _denominator = denominator;
        }
    }
}
