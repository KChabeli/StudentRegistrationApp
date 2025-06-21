using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StudentRegistrationApp.Models
{
    // Implements INotifyPropertyChanged to support data binding
    public class Student : INotifyPropertyChanged
    {
        // Private backing fields
        private string firstName, lastName, studentNumber, moduleName, mark, message;

        // Public properties with change notifications
        public string FirstName
        {
            get => firstName;
            set { firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }

        public string LastName
        {
            get => lastName;
            set { lastName = value; OnPropertyChanged(nameof(LastName)); }
        }

        public string StudentNumber
        {
            get => studentNumber;
            set { studentNumber = value; OnPropertyChanged(nameof(StudentNumber)); }
        }

        public string ModuleName
        {
            get => moduleName;
            set { moduleName = value; OnPropertyChanged(nameof(ModuleName)); }
        }

        public string Mark
        {
            get => mark;
            set { mark = value; OnPropertyChanged(nameof(Mark)); }
        }

        public string Message
        {
            get => message;
            set { message = value; OnPropertyChanged(nameof(Message)); }
        }

        // Method to generate a formatted result message
        public void Submit()
        {
            Message = $"Student {FirstName} {LastName} ({StudentNumber}) obtained {Mark}% in {ModuleName}.";
        }

        // Required to notify the UI when a property changes
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
