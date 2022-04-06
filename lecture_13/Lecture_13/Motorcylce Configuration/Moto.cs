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

        string _model =string.Empty;
        public string Model
        {
            get { return _model; }
            
            set 
            {
                if (value.Equals(string.Empty,StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine("Input name of a model. Empty field is prohibited.");
                else _model = value;
            }

        }

        string _manufacturer = string.Empty;
        public string Manufacturer
        {
            get { return _manufacturer; }

            set
            {
                if (value.Equals(string.Empty, StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine("Input name of a manufacturer. Empty field is prohibited.");
                else _manufacturer = value;
            }

        }


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

        public Moto.Engine MotoEng { get; set; } = new Moto.Engine("gas",125,50);

        
        public override string ToString()
        {
            return "Motorcycle. Manufacturer: " + Manufacturer + ". Model: " + Model + ". ID: " + Id + ". ReleaseDate: " + ReleaseDate + ".";
        }


            public  Moto (string Model, string Manufacturer, int Odometer)
        {
           
            this.Model = Model;
            this.Manufacturer = Manufacturer;
            this.Odometer = Odometer;
           
            
        }
        public class Engine
        {
            string _enginetype = "electro";

            public string EngineType
            {
                get { return _enginetype; }

                set
                {
                    if (!(value=="gas") && !(value=="electro" ))
                    Console.WriteLine($"Input EngineType gas or electro. You've input {value}."); 
                        
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

            public Engine (string EngineType, int VolEng, int Power)
            {
                this.EngineType = EngineType;
                this.VolEng = VolEng;
                this.Power = Power;
            }
            public override string ToString()
            {
                return "Engine. EngineType: " + EngineType + ". Volume of engine: " + VolEng + " cm3. Engine power: " + Power + " horse powers.";
            }
        }
    }
}
