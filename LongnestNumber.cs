using System;
using System.Collections.Generic;

namespace evalart
{
    class MainClass
    {

        static int[] myArray = { 1, 2, 2, 4, 5, 6, 7, 8, 8, 8 };

        public static void Main(string[] args)
        {
            List<ModelData> times = new List<ModelData>();
            for (int n = 0; n < myArray.Length; n++)
            {
                bool add = true;
                if (times.Count > 0)
                {
                    for (int a = 0; a < times.Count; a++)
                    {
                        if (myArray[n] == times[a].Number)
                        {
                            add = false;
                            times[a].Count++;
                        }
                    }
               } 
                
                if (add)
                {
                    times.Add(new ModelData()
                    {
                        Number = myArray[n],
                        Count = 1
                    });
                }
            }

            var longnest = 0;
            var number = 0;
            for (int a = 0; a < times.Count; a++)
            {
                if(times[a].Count > longnest)
                {
                    longnest = times[a].Count;
                    number = times[a].Number;
                }
            }

            Console.WriteLine("Longnest: " + longnest);
            Console.WriteLine("Number: " + number);

        }

        public class ModelData
        {
            public int Number { get; set; }
            public int Count { get; set; }
        }
    }

    
}
