using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<List<string>> clusters = new List<List<string>>();
        List<string> deliveryPoints = new List<string> { "a", "b", "c", "d", "e", "f", "g" };
        Dictionary<(string, string), double> distanceDict = new Dictionary<(string, string), double>();

        for (int i = 0; i < deliveryPoints.Count; i++)
        {
            clusters.Add(new List<string> { deliveryPoints[i] });

            foreach (string eachR in deliveryPoints)
            {
                if (deliveryPoints[i] != eachR)
                {
                    if (clusters[i].Count == 1)
                    {
                        if (!distanceDict.ContainsKey((deliveryPoints[i], eachR)))
                        {
                            Console.Write($"Enter distance between {deliveryPoints[i]} & {eachR}: ");
                            double dis = Convert.ToDouble(Console.ReadLine());
                            distanceDict[(deliveryPoints[i], eachR)] = dis;
                        }
                        else
                        {
                            double dis = distanceDict[(deliveryPoints[i], eachR)];
                            if (dis <= 8)
                            {
                                clusters[i].Add(eachR);
                            }
                        }
                    }
                    else
                    {
                        bool passed = true;
                        foreach (string element in clusters[i])
                        {
                            if (!distanceDict.ContainsKey((element, eachR)))
                            {
                                Console.Write($"Enter distance between {element} & {eachR}: ");
                                double dis = Convert.ToDouble(Console.ReadLine());
                                distanceDict[(element, eachR)] = dis;
                            }
                            else
                            {
                                double dis = distanceDict[(element, eachR)];
                                if (dis > 8)
                                {
                                    passed = false;
                                    break;
                                }
                            }
                        }

                        if (passed)
                        {
                            clusters[i].Add(eachR);
                        }
                    }
                }
            }
        }

        Console.WriteLine("final result");
        foreach (List<string> cluster in clusters)
        {
            Console.WriteLine(string.Join(", ", cluster));
        }
    }
}
