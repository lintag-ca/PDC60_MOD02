using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using PDC60_MOD02.Model;
using System.ComponentModel;

namespace PDC60_MOD02.ViewModel
{
     class StudentInformationViewModel:INotifyPropertyChanged
    {
        public StudentInformation Studentinfo { get; set; }
        public Command CommandInformationUpdate { get; set; }

        public int sID { get; set; }
        public string Sname { get; set; }
        public string Syearlevel { get; set; }
        public string Ssection { get; set; }
        public string SCoursecode { get; set; }
        public string Scourse { get; set; }




        public StudentInformationViewModel()
        {
            CommandInformationUpdate = new Command(() =>
            {
                Studentinfo = new StudentInformation
                {
                    StudentID = sID,
                    StudentName = Sname,
                    YearLevel = Syearlevel,
                    Section = Ssection,
                    CourseCode = SCoursecode,
                    Course = Scourse,

                };

                OnPropertyChanged(nameof(Studentinfo));

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
