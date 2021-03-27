using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_;
using Student_;

namespace Teacher_
{
    public class Teacher : Person
    {
        private List<Student> Students = new List<Student>();
        public string Department { get; set; }
        public static List<Teacher> ListofTeacher = new List<Teacher>();
        public Teacher(string Name, int Age, string Department) :
            base(Name, Age)
        {
            this.Department = Department;
        }
        public override string ToString() => base.ToString() + $" {Department}";
        public void Print() => Console.WriteLine(ToString());

        public void printStudents()
        {
            foreach (Student stud in Students)
                stud.Print();
        }
        public List<Student> getStudents()
        {
            return Students;
        }
        public void addStudents(Student student)
        {
            Students.Add(student);
        }
                    

        public override int GetHashCode() => base.GetHashCode() ^ Department.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            var p = obj as Teacher;
            return base.Equals(p) && p.Department == Department;
        }
        public static Teacher RandomTeacher()
        {
            if (ListofTeacher.Count == 0)
                return null;
            Random random = new Random();
            return ListofTeacher[random.Next(0, ListofTeacher.Count - 1)];
        }
        public override Person Clone()
        {
            Person retperson = new Teacher(base.Name, base.Age, Department);
            return retperson;
        }
    }
}
