using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls.ScheduleView;
using Telerik.Windows.Data;

namespace RadSchedulViewTest
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            AppointmentSource = new RadObservableCollection<Appointment>
            {
                new Appointment(){Subject="test1",Start=DateTime.Now.Date.AddHours(7),End=DateTime.Now.Date.AddHours(10)}
            };
        }

        public RadObservableCollection<Appointment> AppointmentSource { get; set; }        
    }
}
