using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class HouseholdRobot(string robotName, string robotType, double powerCapacityKWH) : Robot(robotName, robotType, powerCapacityKWH)
    {
        //private list of skills (enum): cooking, cleaning, laundry, gardening, childcare
        private List<HouseHoldSkill> skills = new List<HouseHoldSkill> { HouseHoldSkill.cooking, HouseHoldSkill.cleaning, HouseHoldSkill.laundry };

        public override string DescribeRobot()
        {
            //make sure stackoverflow does not happen
            string baseDescription = base.DescribeRobot();
            return $"I am a Household robot my name is {RobotName},\n" +
                $"I have the following skills: {string.Join(", ", skills)}.\n" +
                $"{DisplayBatteryInformation()}";

        }
        //create a method to add skills to the robot
        public void AddSkill(HouseHoldSkill skill)
        {
            if (!skills.Contains(skill))
            {
                skills.Add(skill);
            }
        }
    }
}
