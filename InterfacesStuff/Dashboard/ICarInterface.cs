namespace InterfacesStuff
{
    public interface ICarInterface
    {
        string getName();
        void setName(string name);
        void setSpeed(int speed);
        int getSpeed();
        void setMPG(int mpg);
        void drive(double minutes);
        void fill(int gals);
        double gasLeft();
        void setTankCapacity(int gals);
        double getMiles();
        double getMPG();
        double getCapacity();
    }

}
