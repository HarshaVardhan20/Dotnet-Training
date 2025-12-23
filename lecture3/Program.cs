using System;
using System.Reflection.Metadata.Ecma335;


public class Lecture3
{
    
    public class Car
    {
        
        String color;
        String name;
        int seats;

        public Car(string c,string n,int s)
        {
            this.color = c;
            this.name = n;
            this.seats = s;
        }

        public String getColor()
        {
            return this.color;
        }

        public int getSeats()
        {
            return this.seats;
        }

        public void setColor(String c)
        {
            this.color = c;
        }

    }
    public static void Main()
    {
        Car c = new Car("black","Lamborgini",4);

        Console.WriteLine(c.getColor());
        Console.WriteLine(c.getSeats());
        c.setColor("gray");
        Console.WriteLine(c.getColor());
    }
}