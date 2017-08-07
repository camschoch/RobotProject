using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RobotProject
{
    class Arena
    {
        Random random = new Random();
        RobotJames James = new RobotJames("James", 100);
        RobotSally Sally = new RobotSally("Sally", 100);
        public void setRobots()
        {

            James.turnOnOff();
            string randomOne = James.randomSelect(random.Next(0, 3));
            string randomTwo = Sally.randomSelect(random.Next(0, 3));
            equalHands(randomOne, randomTwo);
            compareHands(randomOne, randomTwo);
        }

        public void equalHands(string randomOne, string randomTwo)
        {
            Console.WriteLine("Robot James: " + randomOne);
            Console.WriteLine("Robot Sally: " + randomTwo);
            Console.ReadLine();
            if (randomOne == "Rock" && randomTwo == "Rock")
            {
                Console.WriteLine("It's a tie");
                Console.ReadLine();

            }
            else if (randomOne == "Paper" && randomTwo == "Paper")
            {
                Console.WriteLine("It's a tie");
                Console.ReadLine();
                
            }
            else if (randomOne == "Scissors" && randomTwo == "Scissors")
            {
                Console.WriteLine("It's a tie");
                Console.ReadLine();
                
            }
        }
        public void loseBatteryJames()
        {
            int randomNumber = random.Next(10, 50);
            int newBattery = James.batteryPercent - randomNumber;
            James.batteryPercent = newBattery;
        }
        public void loseBatterySally()
        {
            int randomNumber = random.Next(10, 50);
            int newBattery = Sally.batteryPercent - randomNumber;
            Sally.batteryPercent = newBattery;
        }
        public void gainBatteryJames()
        {
            int randomNumber = random.Next(10, 50);
            int newBattery = James.batteryPercent + randomNumber;
            James.batteryPercent = newBattery;
        }
        public void gainBatterySally()
        {
            int randomNumber = random.Next(10, 50);
            int newBattery = Sally.batteryPercent + randomNumber;
            Sally.batteryPercent = newBattery;
        }
        public void compareHands(string randomOne, string randomTwo)
        {
            if (randomOne == "Rock" && randomTwo == "Paper")
            {
                Console.WriteLine(randomTwo + " Wins!");
                Console.ReadLine();
                gainBatterySally();
                loseBatteryJames();
                Console.WriteLine("James current battry: " + James.batteryPercent);
                Console.WriteLine("Sally current battry: " + Sally.batteryPercent);



            }
            else if (randomOne == "Rock" && randomTwo == "Scissors")
            {
                Console.WriteLine(randomOne + " Wins!");
                Console.ReadLine();
                gainBatteryJames();
                loseBatterySally();
                Console.WriteLine("James current battry: " + James.batteryPercent);
                Console.WriteLine("Sally current battry: " + Sally.batteryPercent);
               
                
            }
            else if (randomOne == "Paper" && randomTwo == "Rock")
            {
                Console.WriteLine(randomOne + " Wins!");
                Console.ReadLine();
                gainBatteryJames();
                loseBatterySally();
                Console.WriteLine("James current battry: " + James.batteryPercent);
                Console.WriteLine("Sally current battry: " + Sally.batteryPercent);
                
                
            }
            else if (randomOne == "Paper" && randomTwo == "Scissors")
            {
                Console.WriteLine(randomTwo + " Wins!");
                Console.ReadLine();
                gainBatterySally();
                loseBatteryJames();
                Console.WriteLine("James current battry: " + James.batteryPercent);
                Console.WriteLine("Sally current battry: " + Sally.batteryPercent);

            }
            else if (randomOne == "Scissors" && randomTwo == "Rock")
            {
                Console.WriteLine(randomTwo + " Wins!");
                Console.ReadLine();
                gainBatterySally();
                loseBatteryJames();
                Console.WriteLine("James current battry: " + James.batteryPercent);
                Console.WriteLine("Sally current battry: " + Sally.batteryPercent);

            }
            else if (randomOne == "Scissors" && randomTwo == "Paper")
            {
                Console.WriteLine(randomOne + " Wins!");
                Console.ReadLine();
                gainBatteryJames();
                loseBatterySally();
                Console.WriteLine("James current battry: " + James.batteryPercent);
                Console.WriteLine("Sally current battry: " + Sally.batteryPercent);
                

            }
            Console.ReadLine();  
        }
            public void setUp()
            {

            setRobots();
            //equalHands(randomOne, randomTwo);
            //compareHands(randomOne, randomTwo);

        }
       
    }
}
