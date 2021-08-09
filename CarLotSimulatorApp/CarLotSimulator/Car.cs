using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
            {

            }
        public Car(int year, string make, string model, string enginenoise, string hornnoise, bool isdrivable = true)
        {
            Year = year;
            Make = make;
            EngineNoise = enginenoise;
            HornNoise = hornnoise;
            IsDrivable = isdrivable;
        }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; } 
        public string EngineNoise{ get; set; }
        public string HornNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            if (noise == "low")
                Console.WriteLine("The engine is in good condition");
            if (noise == "loud")
                Console.WriteLine("The engine is not in good condition");
        }

        public void MakeHornNoise(string noise)
        {
            if (noise == "low")
                Console.WriteLine("Need to fix the volume of the horn");
            if (noise == "loud")
                Console.WriteLine("The horn sounds good");
        }
    }
}