using System;
using System.Linq;

namespace TriangleType
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("To exit the program press the Q then Enter");
            // For multiple testing we put the core of main function into the while(true)
            while (true)
            {
                #region 'General variables of the main function'             
                double[] edges = new double[3];
                bool validInput = false;
                #endregion

                #region ' Entering the valid input or exiting from the program'
                // This loop will be repeat untill entering the valid input for processing
                while (!validInput)
                {
                    validInput = true;
                    edges = new double[3];
                    Console.Write("Please enter values of each sides like 2,5,4 :");

                    string TempInput = Console.ReadLine();
                    
                    // Checking the exit condition
                    if ((TempInput == "Q") || (TempInput == "q")) return 0;

                    // Split the input by ','
                    string[] inputstr = TempInput.Split(',');
                    // compare the count of input to be 3, because triangle has 3 edges
                    if (inputstr.Count() == 3)
                    {
                        for (int i = 0; i < inputstr.Count(); i++)
                        {
                            // examining the item be number
                            if (!Double.TryParse(inputstr[i], out edges[i]))
                            {
                                Console.WriteLine("Please enter valid numbers");
                                validInput = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please follow the input instruction");
                        validInput = false;
                    }
                }
                #endregion

                #region 'Creating the model and testing it'
                // initatiing the triangle
                Triangle testModel = new Triangle(edges[0], edges[1], edges[2]); ;
                
                // Showing the result type in console
                Console.WriteLine("Vectors: ({0},{1},{2})\t{3}", edges[0], edges[1], edges[2], testModel.GetTriangleType());
                #endregion
            }
        }
    }
}
