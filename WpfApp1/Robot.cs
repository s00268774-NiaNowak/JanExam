using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Robot
    {
        //create an abstract class named robot
        //properties: RobotName, PowerCapacityKWH (double), CurrentPowerKWH (double)
        public enum HouseHoldSkill { cooking, cleaning, laundry, gardening, childcare }
        public enum DeliveryMode { walking, driving, flying }
        public string RobotName { get; set; }
        public string RobotType { get; set; }
        public double PowerCapacityKWH { get; set; }
        public double CurrentPowerKWH { get; set; }
        public Robot(string robotName,string robotType, double powerCapacityKWH)
        {
            RobotName = robotName;
            RobotType = robotType;
            PowerCapacityKWH = powerCapacityKWH;
            CurrentPowerKWH = 0;
        }

        public double GetBatteryPercentage()
        {
            return (CurrentPowerKWH / PowerCapacityKWH) * 100;
        }

        public string DisplayBatteryInformation()
        {
            return $"Battery Information \n" +
                $"Capacity: {PowerCapacityKWH} KWH \n" +
                $"Current Power: {CurrentPowerKWH} KWH \n" +
                $"Battery Percentage: {GetBatteryPercentage()} %";
        }
        //DescribeRobot() method used in subclasses to display text info about robot like name and ty
        public virtual string DescribeRobot()
        {
            return $"{RobotName} - [{RobotType}]";

        }
        public override string ToString()
        {
            return DescribeRobot();
        }

    }
}
