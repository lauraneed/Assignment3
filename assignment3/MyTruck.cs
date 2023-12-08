using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
   internal class MyTruck
    {
        private  string whatbrand;
        private int speed;
        private int NumberOfDoor;
        private int NumberOfWheels;

       public MyTruck (string whatBrand,int Speed, int numberOfDoors,int numberOfWheels) 
       {
            whatbrand = whatBrand;
            speed = Speed;
            NumberOfDoor = numberOfDoors;   
            NumberOfWheels = numberOfWheels;
        
       }
        public string GetBrand()
        { 
            return whatbrand; 
        }

        public int GetSpeed()
        { return speed; }

        public int GetNumberOfDoor()
        { return NumberOfDoor; }

        public int GetNumberOfWheels() 
        {  return NumberOfWheels; }
    }
}
