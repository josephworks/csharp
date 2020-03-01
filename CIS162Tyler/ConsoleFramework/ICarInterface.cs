using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFramework
{
    interface ICarInterface
    {
        void getName();
        string setName();
        int setSpeed(int speed);
        int getSpeed();
        void setMPG(int mpg);
        void drive(int minutes);
        void fill(int gals);
        double gasLeft();
        void setTankCapacity(int gals);
    }
}
