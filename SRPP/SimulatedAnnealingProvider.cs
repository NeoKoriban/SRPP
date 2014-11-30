using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPP
{
    public class SimulatedAnnealingProvider
    {
        private static Random generator = new Random(765);
        private static int[][] citiesPositions;

 
        public static int[,] GenerateSolution(int k, int[][] positions, double T0)
        {
            if (k == 0)
                return null;

            citiesPositions = positions;

            int[] cities = new int[citiesPositions.GetLength(0)];
            for (int i = 0; i < citiesPositions.GetLength(0); ++i)
                cities[i] = i;

            int dimension = cities.GetLength(0) % k == 0 ? cities.GetLength(0) / k : cities.GetLength(0) / k + 1;
            int[,] start = new int[dimension, k + 2];
            for (int i = 0; i < dimension; ++i)
            {
                start[i, 0] = cities[0];
                for (int j = 1; j < k + 1 && i * k + j +1 < cities.GetLength(0); ++j)
                    start[i, j] = cities[i * k + j];
                start[i, k + 1] = cities[0];
            }

            double t = T0, alpha = 0.97;
            int[,] X = start, Xbest = new int[dimension, k];
            X = LocalSearch(X);
            Xbest = X;

            int maxIteration = 100000;

            for (int i = 0; i < maxIteration; ++i)
            {
                int[,] Xprim = LocalSearch(X);
                if (Fittness(Xprim) < Fittness(X))
                    Xbest = X;
                else
                {
                    double r = generator.NextDouble();
                    double delta = Fittness(Xprim) - Fittness(X);
                    if (r < Math.Pow(Math.E, -delta / t))
                    {
                        X = Xprim;
                    }
                }
                t = alpha * t;
            }

         
            return Xbest;
        }

        private static int[,] LocalSearch(int[,] X)
        {
            for(int i = 0; i < X.GetLength(0); ++i)
            {
                int length = X.GetLength(1);

                if (length < 4)
                    return X;


                int dimension = X.GetLength(0);
             

                int temp1 = generator.Next(length-2) + 1;
                int temp2 = generator.Next(length-2) + 1;

                while (temp2 == temp1)
                    temp2 = generator.Next(length - 2) + 1;

                int start = Math.Min(temp1, temp2);
                int stop = Math.Max(temp1, temp2);

                int firstRoute = generator.Next(dimension - 1);
                int secondRoute = generator.Next(dimension - 1);
                while(firstRoute == secondRoute)
                    secondRoute = generator.Next(dimension - 1);

               for(int k = start; k <= stop; ++k)
               {
                   int temp = X[firstRoute, k];
                   X[firstRoute, k] = X[secondRoute, k];
                   X[secondRoute, k] = temp;
               }

            }
            return X;
        }

        private static double Fittness(int[,] X)
        {
            double distance = 0;
            for (int i = 0; i < X.GetLength(0); ++i)
                for (int j = 0; j < X.GetLength(1) - 1; ++j)
                    distance += ComputeDistance(citiesPositions[X[i, j]], citiesPositions[X[i, j + 1]]);
            return distance;
        }

        private  static double ComputeDistance(int[] m1, int[] m2)
        {
            double dx = m1[0] - m2[0];
            double dy = m1[1] - m2[1];

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }
    }
}
