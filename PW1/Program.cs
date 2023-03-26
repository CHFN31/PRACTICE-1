using System.Reflection;

namespace PW1
{
    class Car
    {
        public double maxSpeed;
        public string carName;
        public Car()
        {
            this.maxSpeed = 180;
            this.carName = "Car Name";
        }
        public Car(double maxSpeed, string carName)
        {
            this.maxSpeed = maxSpeed;
            this.carName = carName;
        }

        public double CalculateTime (double distance)
        {
            return distance / maxSpeed;
        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"Название автомобиля - {carName}");
            Console.WriteLine($"Максимальная скорость - {maxSpeed}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4];

            double distance = 300;

            Car camaro = new Car(240, "Chevrolet Camaro");
            cars[0] = camaro;
            double camaroTime = camaro.CalculateTime(distance);
            camaro.PrintCarInfo();
            Console.WriteLine($"Шевроле Камаро пройдёт 100 км за {camaroTime}\n"); // 1.25 ч.


            Car agera = new Car(450, "Koenigsegg Agera RS");
            cars[1] = agera;
            double ageraTime = agera.CalculateTime(distance);
            agera.PrintCarInfo();
            Console.WriteLine($"Koenigsegg Agera RS пройдёт 100 км за {ageraTime}\n"); // 0,66 ч.


            Car hellcat = new Car(327, "Dodge Challenger Hellcat");
            cars[2] = hellcat;
            double hellcatTime = hellcat.CalculateTime(distance);
            hellcat.PrintCarInfo();
            Console.WriteLine($"Dodge Challenger Hellcat пройдёт 100 км за {hellcatTime}\n"); // 0,91 ч.


            Car aventador = new Car(350, "Lamborghini Aventador SVJ");
            cars[3] = aventador;
            double aventadorTime = aventador.CalculateTime(distance);
            aventador.PrintCarInfo();
            Console.WriteLine($"Lamborghini Aventador SVJ пройдёт 100 км за {aventadorTime}\n"); // 0,85 ч.

            double maxSpeed = 0;

            foreach (Car car in cars)
            {
                if (car.maxSpeed > maxSpeed)
                {
                    maxSpeed = car.maxSpeed;
                }
            }

            Car winner;
            foreach (Car car in cars)
            {
                if (car.maxSpeed == maxSpeed)
                {
                    winner = car;
                    Console.WriteLine($"В гонке победил автомобиль {winner.carName}, который имеет наибольшую скорость.\nЕго характеристики:");
                    winner.PrintCarInfo();
                }
            }


            Console.ReadKey(true);
        }
    }
}