using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Euler.Problems
{
   public interface IProblem
   {
      /// <summary>
      /// Gets the problem number.
      /// </summary>
      /// <value>The problem number.</value>
      int ProblemNumber { get; }

      /// <summary>
      /// Gets the description of the problem.
      /// </summary>
      /// <value>The description.</value>
      string Description { get; }

      /// <summary>
      /// Solves the problem
      /// </summary>
      /// <returns>The answer to the problem</returns>
      long Solve();
   }
}
