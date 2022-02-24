using System;
using System.Globalization;

namespace IComparable.Entities
{
    public class Employee : System.IComparable
    {
        //properties
        public string Name { get; set; }
        public double Salary { get; set; }

        //constructor
        public Employee(string cvsEmployee)
        {
            string[] vect = cvsEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        //methods
        public override string ToString()
        {
            return $"{Name},{Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: arguiment is not and Employee");
            }
            
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}