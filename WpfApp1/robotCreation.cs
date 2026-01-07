using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class robotCreation
    {
        //write a method that creates 6 ros, 3 household robots and 3 delivery robots
        //name them as follows: Household: HouseBot, GardenMate, Housemate 3000
        //Delivery: DeliverBot, FlyBot, Driver
        public robotCreation()
        {
            HouseholdRobot houseBot = new HouseholdRobot("HouseBot", "Household", 10);
            HouseholdRobot gardenMate = new HouseholdRobot("GardenMate", "Household", 15);
            HouseholdRobot housemate3000 = new HouseholdRobot("Housemate 3000", "Household", 20);
            DeliveryRobot deliverBot = new DeliveryRobot("DeliverBot", "Delivery", 25, 100);
            DeliveryRobot flyBot = new DeliveryRobot("FlyBot", "Delivery", 30, 50);
            DeliveryRobot driver = new DeliveryRobot("Driver", "Delivery", 35, 120);
        }
        //return a list of robots
        public List<Robot> CreateRobots()
        {
            //give household robots their skills and delivery robots their delivery modes
            List<Robot> robots = new List<Robot>();
            robots.Add(new HouseholdRobot("HouseBot", "Household", 10));
            robots.Add(new HouseholdRobot("GardenMate", "Household", 15));
            robots.Add(new HouseholdRobot("Housemate 3000", "Household", 20));
            robots.Add(new DeliveryRobot("DeliverBot", "Delivery", 25, 100));
            robots.Add(new DeliveryRobot("FlyBot", "Delivery", 30, 50));
            robots.Add(new DeliveryRobot("Driver", "Delivery", 35, 120));
            return robots;
        }
    }
}
