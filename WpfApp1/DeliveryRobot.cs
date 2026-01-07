using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class DeliveryRobot : Robot
    {
        //Modeof Delivery (enum): walking, driving, flying
        private DeliveryMode modeOfDelivery;
        //MaxLoadKg (double)
        private double maxLoadKg;

        public DeliveryRobot(string robotName, string robotType, double powerCapacityKWH, double maxLoadKg) : base(robotName, robotType, powerCapacityKWH)
        {
        }

        //ovveride the abstract DescribeRobot() method to include mode of delivery and max load info
        public override string DescribeRobot()
        {
            string baseDescription = base.DescribeRobot();
            return $"I am a Delivery robot my name is {RobotName},\n" +
                $"I specialise in delivery by {modeOfDelivery}.\n" +
                $"The maximum load I can carry is {maxLoadKg} kg\n" +
                $"{DisplayBatteryInformation()}";
        }
        

    }
}
