using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcylce_Configuration
{
    public class Moto
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Model { get; set; } = "Underfined";

        public string Manufacturer { get; set; } = "Underfined";



        int _odometer = 5;

        public int Odometer
        {
            get { return _odometer; }

            set
            { if (value > 100)
                    Console.WriteLine("Input value less than 100 km.");
                else _odometer = value;
            }
        }

        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        private protected void FactoryReset()
        {
            _odometer = 5;
        }

        public override string ToString()
        {
            return $"Motocycle. Manufacturer {Manufacturer}. Model :{Model}. ID: {Id}. ReleaseDate: {ReleaseDate:yyyy}.";

        }


        public void Moto(Guid guid, string Model, string Manufacturer, int Odometer, DateTime ReleaseDate, Engine engine)
        {
           
            this.Model = Model;
            this.Manufacturer = Manufacturer;
            this.Odometer = Odometer;
            this.ReleaseDate = ReleaseDate;
            
        }
        public class Engine
        {
            string _enginetype = "gas";

            public string EngineType
            {
                get { return _enginetype; }

                set
                {
                    if (value!="gas" || value!="electro" )
                        Console.WriteLine("Input EngineType gas or electro.");
                    else _enginetype = value;
                }
            }

            int _voleng = 125;

            public int VolEng
            {
                get { return _voleng; }

                set
                {
                    if (value < 125 || value > 1300)
                        Console.WriteLine("Input value between 125 and 1300 cm3.");
                    else _voleng = value;
                }
            }

            int _power = 50;

            public int Power
            {
                get { return _power; }

                set
                {
                    if (value < 50 || value > 400)
                        Console.WriteLine("Input value between 50 and 400 horse power.");
                    else _power = value;
                }
            }
        }
    }
}
