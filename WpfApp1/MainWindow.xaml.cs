using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// https://github.com/s00268774-NiaNowak/JanExam/tree/Test
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Lbx_Loaded(object sender, RoutedEventArgs e)
        {

            //load all robots into the listbox with names, types, skills, delivery modes, and max loads
            robotCreation robotCreator = new robotCreation();
            List<Robot> robots = robotCreator.CreateRobots();
            Lbx.ItemsSource = robots;

            //whatever is selected in the listbox show the description in the textblock
            Lbx.SelectionChanged += (s, ev) =>
            {
                Robot selectedRobot = (Robot)Lbx.SelectedItem;
                if (selectedRobot != null)
                {
                    TxBx.Text = selectedRobot.DescribeRobot();
                }
            };

            //if household radio button is checked show only household robots in the listbox
            if (HouseRbtRB.IsChecked == true)
            {
                Lbx.ItemsSource = robots.Where(r => r is HouseholdRobot).ToList();
            }
            //if delivery radio button is checked show only delivery robots in the listbox
            else if (DeliRbtRB.IsChecked == true)
            {
                Lbx.ItemsSource = robots.Where(r => r is DeliveryRobot).ToList();
            }
            else if (AllRbtRB.IsChecked == true)
            {
                Lbx.ItemsSource = robots;
            }

        }

        public void AllRbtRB_Checked(object sender, RoutedEventArgs e)
        {
            //in listbox show all robots


        }

        public void HouseRbtRB_Checked(object sender, RoutedEventArgs e)
        {
            //in listbox show only household robots

        }

        public void DeliRbtRB_Checked(object sender, RoutedEventArgs e)
        {
            //in listbox show only delivery robots
        }

        private void ChargeBtn_Click(object sender, RoutedEventArgs e)
        {
            //charge the selected robot in the listbox
            //get the selected robot
            //set its CurrentPowerKWH to its PowerCapacityKWH
            Robot selectedRobot = (Robot)Lbx.SelectedItem;
            if (selectedRobot != null)
            {
                //create a messagebox to show how long a charge has taken
                MessageBox.Show($"Charging {selectedRobot.RobotName}...\n" +
                    $"Charge Complete!\n" +
                    $"It took {selectedRobot.PowerCapacityKWH / 0.5} hours to fully charge.", "Charge Complete", MessageBoxButton.OK, MessageBoxImage.Information);
                selectedRobot.CurrentPowerKWH = selectedRobot.PowerCapacityKWH;
                //update the textblock with the new battery information
                TxBx.Text = selectedRobot.DescribeRobot();

                if (selectedRobot.GetBatteryPercentage() == 100)
                {
                    MessageBox.Show($"{selectedRobot.RobotName}'s battery is now full.", "Battery Full", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }

        }
    }
}