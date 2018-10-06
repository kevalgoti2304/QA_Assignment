using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class TriangleSolver
    {
        public TriangleSolver()
        {

        }
        public string Analyze(int dimensionOne, int dimensionTwo, int dimensionThree)
        {
            if (dimensionOne == dimensionTwo && dimensionTwo == dimensionThree)
            {
               return "Equilateral";
            }
            else if (dimensionOne == dimensionTwo || dimensionOne == dimensionThree || dimensionTwo == dimensionThree)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }           
        }
    }
}
