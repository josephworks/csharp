using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    interface ICarInterface
    {
        void setName(string name);
        string getName();
        void setSpeed(int speed);
        int getSpeed();
        void setMPG(int mpg);
        void drive(int minutes);
        void fill(int gals);
        double gasLeft();
        void setTankCapacity(int gals);
    }


}
