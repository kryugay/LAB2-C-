using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_;

namespace Student_
{
    public class Student : Person
    {
        public int Course { get; private set; }
        public int Group { get; set; }
        public static List<Student> ListofStudent = new List<Student>();
        public Student(string Name, int Age, int Course, int Group) :
            base(Name, Age)
        {
            this.Course = Course;
            this.Group = Group;
        }
        public void IntCourse()
        {
            Course += 1;
        }
        public override string ToString() => base.ToString() + $" {Course} {Group}";
        public void Print() => Console.WriteLine(ToString());
        public override int GetHashCode() => base.GetHashCode() ^ Course.GetHashCode() ^ Group.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            var p = obj as Student;
            return base.Equals(p) && p.Course == Course && p.Group == Group;
        }

        public static Student RandomStudent()
        {
            if (ListofStudent.Count == 0)
                return null;
            Random random = new Random();
            return ListofStudent[random.Next(0, ListofStudent.Count - 1)];
        }

        public override Person Clone()
        {
            Person retperson = new Student(base.Name, base.Age, Course, Group);
            return retperson;
        }
    }
}
