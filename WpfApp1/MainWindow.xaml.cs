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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Lbx_Loaded(object sender, RoutedEventArgs e)
        {

            //load all robots into the listbox
            robotCreation robotFactory = new robotCreation();
            List<Robot> robots = robotFactory.CreateRobots();
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

        
    }
}