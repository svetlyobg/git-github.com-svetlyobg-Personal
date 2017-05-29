using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frugiplaneti
{
    class PlanetiInfo
    {
        static void Main(string[] args)
        {
            Planet mercury = new Planet("Меркурий", 57, 4880, 47.39, 0, 88, 59, 7, 0.01, 4.6);
            Planet venus = new Planet("Венера", 108, 12104, 35, 0, 224, 243, 3.4, 177.4, 4.6);
            Planet earth = new Planet("Земя", 150, 12756, 29.8, 1, 365, 1, 0, 23.4, 4.6);
            Planet mars = new Planet("Марс", 228, 6786, 24.1, 2, 687, 1.1, 1.9, 25.2, 4.6);
            Planet jupiter = new Planet("Юпитер", 779, 142958, 13.1, 67, 4331, 0.4, 1.3, 3.1, 4.6);
            Planet saturn = new Planet("Сатурн", 1430, 120536, 9.7, 62, 10747, 0.4, 2.5, 26.5, 4.6);
            Planet uranus = new Planet("Уран", 2880, 51118, 6.8, 27, 30589, 0.7, 0.8, 98.7, 4.6);
            Planet neptune = new Planet("Нептун", 4500, 49528, 5.4, 14, 59800, 0.6, 1.8, 28.3, 4.6);
            List<Planet> planet = new List<Planet>()
            {
                mercury,
                venus,
                earth,
                mars,
                jupiter,
                saturn,
                uranus ,
                neptune
        };
            foreach (var planets in planet)
            {
                planets.Output();
            }
        }
    }
    public class Planet
    {
        public string Name { get; set; }
        public int DistanceFromSun { get; set; }
        public int Diameter { get; set; }
        public double OrbitalSpeedKmSec { get; set; }
        public int Moons { get; set; }
        public double DaysAroundSun { get; set; }
        public double DaysAroundAxis { get; set; }
        public double OrbitalTilt { get; set; }
        public double AxisTilt { get; set; }
        public double Age { get; set; }

        public Planet(string name, int distancefromsun, int diameter, double obrbitalspeedkms, int moons, double daysAroundSun, double daysAroundAxis, double orbitaltilit, double axistilt, double age)
        {
            this.Name = name;
            this.DistanceFromSun = distancefromsun;
            this.Diameter = diameter;
            this.OrbitalSpeedKmSec = obrbitalspeedkms;
            this.Moons = moons;
            this.DaysAroundSun = daysAroundSun;
            this.DaysAroundAxis = daysAroundAxis;
            this.OrbitalTilt = orbitaltilit;
            this.AxisTilt = axistilt;
            this.Age = age;
        }
        public void Output()
        {
            Console.WriteLine($"Аз съм планетата {this.Name}. На {this.Age} млрд. години съм и се намирам на {this.DistanceFromSun} милиона километра от Слънцето.\nИмам {this.Moons} на брой луни.\nДиаметърът ми е {this.Diameter} километра.\nОрбиталната ми скорост е {this.OrbitalSpeedKmSec} км/с.\nАз обикалям Слънцето за {this.DaysAroundSun} дни, а оста ми за {this.DaysAroundAxis}.\nОрбиталният ми наклон е {this.OrbitalTilt} градуса, а осовият -> {this.AxisTilt}.\n\n\n".Replace("\n", Environment.NewLine));
        }
    }
}
