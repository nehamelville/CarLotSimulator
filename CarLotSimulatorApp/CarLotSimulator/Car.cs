using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }
        public Car( string make,string model,int year,string engineNoise,string honkNoise,bool isDrivable)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.EngineNoise = engineNoise;
            this.HonkNoise = honkNoise;
            this.IsDrivable = isDrivable;
        }
        public string Make
        {
            get;
            set;
        }
        public string Model
        {
            get;set;
        }
        public int Year
        {
            get;set;
        }
        public string EngineNoise
        {
            get;
            set;
        }
        public string HonkNoise
        {
            get;set;
        }
        public bool IsDrivable
        {
            get;set;
        }
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"EngineNoise: {engineNoise}");
            
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"HonkNoise: {honkNoise}");
        }
       
    }
}
