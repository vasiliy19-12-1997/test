using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    enum Models
    {
        Audi, Nissan, Toyota, Volkswagen,Porshe,Ford  
    }
    class Cars
    {
         public int wheels = 4;
         private float speed;
         protected bool isWorking = true;
         public static int test = 0;
         public Models model;
        
         public static void Test()
         {
             Console.Write("Hi");
         }

         public void setValues(float speed, bool isWorking)
         {
             this.speed = speed;
             this.isWorking = isWorking;
         }      
         public virtual void getValues()
         {
      Console.WriteLine($"Car speed is {this.speed}, Car is working {this.isWorking}");
         }

         public Cars(int wheels, float speed, bool isWorking)
         {
             this.speed = speed;
             this.isWorking = isWorking;
             this.wheels = wheels;
         }
         public Cars(){}
    }

    class Trucks : Cars
    {
        public int passengers;
        
        public Trucks(int wheels, float speed, bool isWorking, int passengers):base(wheels, speed, isWorking)
        {
            this.passengers = passengers;
            
        }

        public override void getValues()
        {
            base.getValues();
            Console.WriteLine($"Passengers:{passengers}");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Cars.Test();
            // Cars.test = 5;
            // Console.WriteLine(Cars.test);

            Trucks man = new Trucks(8, 130.5f, true, 50);
            man.getValues();
            // Console.WriteLine(man.passengers);
            
            Cars audi = new Cars(4, 240.5f, false);
            audi.model = Models.Audi;
            // audi.setValues(250.5f, true);
            audi.getValues();
            Cars toyota = new Cars();
            toyota.wheels = 6;
            toyota.model = Models.Toyota;
            toyota.setValues(150.9f, false);
            toyota.getValues();
            // Console.WriteLine(toyota.wheels);
        }
    }
}
