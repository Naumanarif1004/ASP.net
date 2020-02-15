using System;
using System.Collections.Generic;
using System.Text;

namespace SImpleCsharpCalculator
{
    public class CalculatorHandling
    {
        public CalculatorHandling()
        {

        }

        #region Addition
        public int Add(int no1,int no2)
        {
            return no1 + no2;
        }
        #endregion

        #region Subtraction
        public int Sub(int no1,int no2)
        {
            return no1 - no2;
        }
        #endregion

        #region Multplication
        public int Mult(int no1,int no2)
        {
            return no1 * no2;
        }
        #endregion

        #region Division
        public int Divide(int no1,int no2)
        {
            
            try
            {
                 return no1 / no2;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           
            
        }
        #endregion
    }
}
