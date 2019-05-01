using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public bool IsSsn(string ssn)
        {
            string withDash = @"^\d{3}-\d{2}-\d{4}$";
            string withoutDash = @"^\d{9}$";
            Match result = Regex.Match(ssn, withDash);
            Match result2 = Regex.Match(ssn, withoutDash);

            if (result.Success || result2.Success)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            if (numToTest >= minValue && numToTest <= maxValue)
            {
                return true;
            }

            return false;
        }

    }
}
