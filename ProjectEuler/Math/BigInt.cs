using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Euler.Math
{
   public class BigInt
   {
      private List<int> _digits = new List<int>();

      public BigInt()
      {
         _digits.Add(0);
      }

      public BigInt( string value )
      {
         for ( int i = value.Length - 1; i >= 0; i-- )
         {
            int d = value[i] - '0';
            if ( d >= 0 && d <= 9 )
            {
               _digits.Add( d );
            }
         }
      }

      public void Add( string value )
      {
         BigInt i = new BigInt( value );
         Add(i);
      }

      public void Add( BigInt value )
      {
         int aCount = _digits.Count;
         int bCount = value._digits.Count;
         int carry = 0;
         for ( int i = 0; i < System.Math.Max( aCount, bCount ); i++ )
         {
            int a = 0;
            int b = 0;
            if ( aCount > i )
               a = _digits[i];
            if ( bCount > i )
               b = value._digits[i];
            int sum = a + b + carry;
            int d;
            carry = System.Math.DivRem(sum, 10, out d);

            if ( aCount > i )
               _digits[i] = d;
            else
               _digits.Add(d);
         }
         if ( carry > 0 )
            _digits.Add(carry);
      }

      public override string ToString()
      {
         StringBuilder str = new StringBuilder(_digits.Count);
         for ( int i = _digits.Count - 1; i >= 0; i-- )
         {
            int d = _digits[i];
            str.Append(d);
         }
         string retval = str.ToString();
         
         if ( retval.Length == 0 )
            return "0";

         if ( retval.Length == 1 )
            return retval;

         return retval.TrimStart('0');
      }
   }
}
