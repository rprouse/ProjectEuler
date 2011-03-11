#region Using Directives

using System;

#endregion

namespace Project.Euler.Problems
{
    public class Problem317 : IProblem
    {
        public int ProblemNumber
        {
            get { return 317; }
        }

        public string Description
        {
            get { return "Firecracker"; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        public long Solve()
        {
            // Some constants from the problem
            const double a = 9.81;  // Uniform gravitational acceleration
            const double v0 = 20;   // Initial velocity
            const double h = 100;   // Height of burst


            // The radius that particles move out
            double r = System.Math.Sqrt(2*h/a)*v0;

            // Cylinder volume
            double vc = r*r*h*System.Math.PI;

            // Time for upper particles to hit their zenith
            double t = v0/a;

            // Height of the zenith above the burst
            double hz = t + a/2*t*t;

            // Volume of spherical cap
            double vsc = System.Math.PI*hz*(3*r*r + hz*hz)/6;

            // The volume answer
            double v = vsc + vc;

            // We need to return it rounded to 4 decimal places
            return (long) (System.Math.Round(v, 4)*100);
        }
    }
}
