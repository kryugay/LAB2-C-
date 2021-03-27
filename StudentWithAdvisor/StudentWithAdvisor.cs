using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_;
using Teacher_;

namespace StudentWithAdvisor_
{
    public class StudentWithAdvisor : Student
    {
        private Teacher advisor;
        public Teacher Advisor
        {
            get { return advisor; }
            set { advisor = value; }
        }
        public List<StudentWithAdvisor> studentswithadvisor = new List<StudentWithAdvisor>();
        public StudentWithAdvisor(Student student, Teacher advisor) : base(student.Name, student.Age, student.Course, student.Group)
        {
            Advisor = advisor;
        }
        public override string ToString() => base.ToString() + $" {Advisor}";
        public void Print() => Console.WriteLine(ToString());
        public void toApply()
        {
            foreach (Teacher teac in Teacher.ListofTeacher)
            {
                foreach(Student stud in teac.getStudents())
                {
                    StudentWithAdvisor s = new StudentWithAdvisor(stud, teac);
                    studentswithadvisor.Add(s);
                }
            }

        }

    }
}
