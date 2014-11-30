using System;

namespace SRPP
{
    public class SimulatedAnnealing
    {
        private int[][] citiesList;
        private double temperature;
        private int k;
        private int numberOfCities;
        private double distanceSummary = 0;
        public SimulatedAnnealing(int[][] citiesListFromFile, double userTemperature, int kFromFile, int numberOfCity)
        {
            citiesList = citiesListFromFile;
            temperature = userTemperature;
            k = kFromFile;
            numberOfCities = numberOfCity;
            var result = SimulatedAnnealingProvider.GenerateSolution(k, citiesList, userTemperature);
        }

        private int[] citiesTrack(int city, int index, int [] trackList)
        {
            trackList[index] = city;
            return trackList;
        }
        private void summaryTrace(double distancePart)
        {
            distanceSummary += distancePart;
        }

        public double returnValeDistanceSummary()
        {
            return distanceSummary;
        }

        private double distanceOperation (int city1x, int city1y, int city2x, int city2y)
        {
            double distance;
            double dx = city2x - city1x;
            double dy = city2y - city1y;
            distance = Math.Sqrt(Math.Pow(dx, 2.0) + Math.Pow(dy, 2.0));

            return distance;
        }

        private void tracing()
        {
            int i = 0;
            while(i < citiesList.Length)
            {
                for (int j = 0; j < k; j++)
                {
                  
                }
            }
        }

      /*  public int[][] trackingCities()
        {
     
            return nowy;
        }*/
    }
}
