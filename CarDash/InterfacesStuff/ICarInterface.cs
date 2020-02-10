namespace InterfacesStuff
{
    internal interface ICarInterface
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

        double getMiles();
    }
}