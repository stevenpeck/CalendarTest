using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalendarTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalendarDateRange calDR = new CalendarDateRange();
        List<Dates> dates = new List<Dates>(); /*{ new Dates(new DateTime(2017, 06, 12)), new Dates(new DateTime(2017, 06, 03)), new Dates(new DateTime(2017, 06, 06)) };*/
        
        public MainWindow()
        {
            InitializeComponent();
            dates.Add(new Dates(new DateTime(2017, 06, 12)));
            dates.Add(new Dates(new DateTime(2017, 06, 03)));
            dates.Add(new Dates(new DateTime(2017, 06, 06)));
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //TROUBLE CODE
            if (Calendar1.SelectedDate.HasValue)
            {
                DateTime date = Convert.ToDateTime(Calendar1.SelectedDate.Value.ToShortDateString());
                dates.Add(new Dates(date));
            }
            //WORKING FINE
            //try
            //{
            //    dates.Add(new Dates(new DateTime(Int32.Parse(Year.Text), Int32.Parse(Month.Text), Int32.Parse(Day.Text))));
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Please enter correct data format i.e 2017 01 01 \n ERROR CODE: \n" + ex);
            //}
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var d in dates)
            {
                calDR = new CalendarDateRange(d.Date);
                //THROWING ERROR HERE
                Calendar1.BlackoutDates.Add(calDR);
            }
        }

        private void Calendar1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Calendar1.SelectedDate.HasValue)
            {
                textBlock1.Text = "Selected Date = " + Calendar1.SelectedDate.Value.ToShortDateString();
            }
        }
    }
}
