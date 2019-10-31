﻿Feature: NotifyPropertyChangedGeneration
	I am checking the Notify Property Changed Generation strategy


Scenario: Notify Property Changed Generation
	Given I have a class defined as 
	"""
using System.ComponentModel;
using System.Windows.Media;

namespace AssemblyCore
{
    public class PropertyChange : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertChanged("Name");
                OnPropertChanged("FullName");
            }
        }

        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertChanged("LastName");
                OnPropertChanged("FullName");
            }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertChanged("FullName");
            }
        }

        private Color color;

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertChanged("Color");
            }
        }

		public string notChange { get}

        public PropertyChange()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
	"""
	And I set my test framework to 'NUnit3'
	And I set my mock framework to 'FakeItEasy'
	When I generate tests for the property using the strategy 'NotifyPropertyChangedGenerationStrategy'
	Then I expect a method called 'CanSetAndGetName'
		And I expect it to contain the statement '_testClass.CheckProperty(x => x.Name);'
	And I expect a method called 'CanSetAndGetLastName'
		And I expect it to have the attribute 'Test'
	And I expect a method called 'CanSetAndGetFullName'
	And I expect a method called 'CanSetAndGetColor'
		And I expect it to contain the statement '_testClass.CheckProperty(x => x.Color, default(Color), default(Color));'
	And I expect no method with a name like '.*notChange.*'