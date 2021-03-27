using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public static List<Person> ListofPerson = new List<Person>();
        public int Age
        {
            get { return age; }
            set { if (value < 0) value = 0; age = value; }
        }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void IncAge()
        {
            Age += 1;
        }
        
        public override string ToString() => $"{Name} {Age}";
        public void Print() => Console.WriteLine(ToString());
        public override int GetHashCode() => Name.GetHashCode() ^ Age.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            var p = obj as Person;
            return p.Name == Name && p.Age == Age;
        }
        public static Person RandomPerson()
        {
            if (ListofPerson.Count == 0)
                return null;
            Random random = new Random();
            return ListofPerson[random.Next(0, ListofPerson.Count - 1)];
        }
        public virtual Person Clone()
        {
            Person retperson = new Person(Name, Age);
            return retperson;
        }
    }
}
