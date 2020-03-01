using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface ICarInterface
    {
        string getName();
        void setName(string name);
        void setSpeed(int speed);
        int getSpeed();
        void setMPG(int mpg);
        void drive(int minutes);
        void fill(int gals);
        double gasLeft();
        void setTankCapacity(int gals);
    }
}
