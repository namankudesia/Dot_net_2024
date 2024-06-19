using System;
class Distance
{
    public int dist1;
    public Distance(int d = 0)
    {
        dist1 = d;
    }
    public static Distance operator ++(Distance dis)
    {
        dis.dist1++;
        return dis;
    }
    public static Distance operator +(Distance dis1, Distance dis2)
    {
        Distance temp = new Distance();
        temp.dist1 = dis1.dist1 + dis2.dist1;
        return temp;
    }
}
class Operator_Overloading
{
    static void Main()
    {
        Distance d1 = new Distance(60);
        Distance d2 = new Distance(100);
        Distance totalDistance = d1 + d2;
        Console.WriteLine("The Total Distance is {0}", totalDistance.dist1);
        totalDistance = d1++;
        Console.WriteLine("The Total Distance after post-increment is {0}", totalDistance.dist1);
        Console.Read();
    }
}
