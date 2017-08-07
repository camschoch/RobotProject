using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotProject
{
    public abstract class RobotParent
    {
        Random random = new Random();
        public string name;
        public int batteryPercent;
        public RobotParent()
        {
        
        }
        public string randomSelect(int randomNumber)
        {
            string[] selectionArray = { "Rock", "Paper", "Scissors" };
         
            string randomMove = selectionArray[randomNumber];
            return randomMove;
        }
        
        public void turnOnOff()
        {
            Console.WriteLine("James is powered on.\n");
            Console.WriteLine("Sally is powered on.\n");
            Console.ReadLine();
            /*string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "on":
                    Console.WriteLine("Robot is on.");
                    Console.ReadLine();
                    return true;

                case "off":
                    Console.WriteLine("Robot is off.");
                    Console.ReadLine();
                    return false;

                default:
                    Console.WriteLine("We didn't understand please try again.");
                    Console.ReadLine();
                    turnOnOff();
                    return false;
            }*/
        }
       
    }
}
