using System;
using System.Linq;

namespace TriangleType
{
    public class Triangle
    {
        #region 'class variable'
        public double[] values { get; set; }
        #endregion
        
        // Class constructor
        public Triangle(double A , double B, double C)
        {
            #region 'Constructing and sorting the edges array'
            // Initialize the array by inputs
            values = new double[3] { A, B, C};

            // Sorting the edges by length
            //values[0] is the lowest value and values[2] is the biggest value
            Array.Sort(values);
            #endregion
        }
        
        // Type detector function
        public string GetTriangleType()
        {
            // all the edges must be greater than zero and greatest edge must be lower than sum of two other edges.
            if (values[0]<=0 ||(values[2]>=(values[1]+values[0])))
            {
                #region 'Returning the fault of edge definition'
                if (values[0] <= 0)
                    return "Edges must be greater than zero";
                else
                    return "Each value must be lower than sum of two other values";
                #endregion
            }else
            {
                #region 'Detecting the type'
                // distinct edges count specifies the triangle's type
                switch (values.Distinct().Count())
                {
                    case 1:
                        return "Equilateral";
                    case 2:
                        return "Isosceles";
                    case 3:
                        return "Scalene";
                }
                #endregion
            }
            return "Exception";
        }
    }
}
