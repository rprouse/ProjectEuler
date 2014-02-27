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
            return String.Format( "Problem {0:000}", ProblemNumber );
        }

        /* 
         *   A firecracker explodes at a height of 100 m above level ground. It 
         *   breaks into a large number of very small fragments, which move in every 
         *   direction; all of them have the same initial velocity of 20 m/s. 
         *
         *   We assume that the fragments move without air resistance, in a uniform 
         *   gravitational field with g=9.81 m/s2. 
         *
         *   Find the volume (in m3) of the region through which the fragments move 
         *   before reaching the ground. Give your answer rounded to four decimal 
         *   places.
         *
         * equation of parabola: y = a*x^2 + b 
         * find a,b using (0, max_h) and (max_x, 0)
         * and calc solid of revolution 
         * 
         */
        public long Solve()
        {
            // Some constants from the problem
            const double a = 9.81;  // Uniform gravitational acceleration
            const double v0 = 20;   // Initial velocity
            const double h = 100;   // Height of burst

            //double volume = InternalSolve( a, v0, h );
            //double volume = Volume( v0, h, a );
            double volume = VolumeOfASpheroid(v0, h, a);
            volume = solve();

            // We need to return it rounded to 4 decimal places
            return (long)(System.Math.Round( volume, 4 ) * 10000);
        }

        // https://github.com/dzhou/project-euler/blob/master/problem317.py
        private double solve()
        {
            double max_x = get_max_distance(20, 100);
            double b = get_max_height(20, 90, 100);
            double a = -b/System.Math.Pow(max_x,2);

            // integrate x=[0..max_x]
            double x = 0;
            double volume = 0;
            double increment = 0.0001;
            while ( x <= max_x )
            {
                double h = (f(x,a,b) + f(x + increment, a, b))/2.0;
                volume += System.Math.PI*(System.Math.Pow(x + increment,2) - System.Math.Pow(x,2))*h;
                x += increment;
            }
            return volume;
        }

        private double f(double x, double a, double b)
        {
            return a * System.Math.Pow( x, 2 ) + b;
        }

        private double Volume( double v0, double h, double a )
        {
            return (System.Math.Pow( (v0 * v0) / (2 * a) + h, 2 ) * v0 * v0 * System.Math.PI) / a;
        }

        private double radians( double d )
        {
            return d*System.Math.PI/180;
        }

        private double get_distance( double v, double r, double h, double g=9.81)
        {
            r = radians(r);
            double d = v*System.Math.Cos(r)/g;
            d *= v*System.Math.Sin(r) + System.Math.Sqrt(System.Math.Pow(v*System.Math.Sin(r),2) + 2*g*h);
            return d;
        }

        /// <summary>
        /// Gets the max height of particles
        /// </summary>
        /// <param name="v">The initial velocity.</param>
        /// <param name="r">The angle.</param>
        /// <param name="h">The initial height.</param>
        /// <param name="g">The acceleration.</param>
        /// <returns></returns>
        private double get_max_height( double v, double r, double h, double g=9.81)
        {
            return h + System.Math.Pow((v*System.Math.Sin(radians(r))),2)/(g*2);
        }


        /// <summary>
        /// Gets the max distance a particle will go
        /// </summary>
        /// <param name="v">The initial velocity.</param>
        /// <param name="h">The initial height.</param>
        /// <param name="iteration">The number of iterations.</param>
        /// <returns></returns>
        private double get_max_distance(double v, double h, double iteration=20)
        {
            double increment = 1.0/1000;
            double max_d = 0;
            double r = 0;

            while(iteration > 0)
            {
                double d = get_distance(20, r, 100);
                if ( d > max_d )
                {
                    max_d = d;
                    r += increment;
                }
                else
                {
                    r -= increment;
                    increment /= 10;
                    iteration -= 1;
                }
            }
            return max_d;
        }

        private double VolumeOfASpheroid( double a, double v0, double h )
        {
            // Time to drop 100m
            double td = System.Math.Sqrt( 2 * h / a );

            // The radius that particles move out (equitorial radius)
            double re = (v0 / 2) * td * td;

            // Time for upper particles to hit their zenith
            double t = v0 / a;

            // Height of the zenith above the burst
            double hz = t + a / 2 * t * t;

            // Polar radius
            double rp = hz + h;

            // Half volume of the spheroid
            double v = 2 * System.Math.PI * re * re * rp / 3;

            return v;
        }

        // Wrong
        private double SphereOnACyclinder( double a, double v0, double h )
        {
            // Time to drop 100m
            double td = System.Math.Sqrt( 2 * h / a );

            // The radius that particles move out
            double r = (v0 / 2) * td * td;

            // Time for upper particles to hit their zenith
            double t = v0 / a;

            // Height of the zenith above the burst
            double hz = t + a / 2 * t * t;

            // Volume of spherical cap
            // double vsc = System.Math.PI*hz*(3*r*r + hz*hz)/6;

            // Volume of spherical hemisphere
            double vsc = r * r * r * System.Math.PI * 2 / 3;

            // Height of cylinder
            double hc = r - hz;

            // Cylinder volume
            double vc = r * r * hc * System.Math.PI;

            // The volume answer
            double v = vsc + vc;

            return v;
        }
    }
}
