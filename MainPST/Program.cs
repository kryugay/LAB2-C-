using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_;
using Student_;
using Teacher_;
using StudentWithAdvisor_;

namespace MainPST
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ivanov", 21, 4, 2);
            Student s1 = new Student("Petrov", 20, 3, 2);
            Student s2 = new Student("Sidorov", 19, 2, 5);
            Student s3 = new Student("Litovka", 22, 4, 1);
            Student s4 = new Student("Kolesnikova", 20, 3, 3);
            Student s5 = new Student("Popova", 18, 1, 4);

            Teacher t = new Teacher("Ivanova", 37, "ADM");
            Teacher t1 = new Teacher("Puchkin", 42, "PMP");
            Teacher t2 = new Teacher("Danilova", 35, "VMIO");
            Teacher t3 = new Teacher("Kolesnikov", 47, "TU");

            Student.ListofStudent.Add(s);
            Student.ListofStudent.Add(s1);
            Student.ListofStudent.Add(s2);
            Student.ListofStudent.Add(s3);
            Student.ListofStudent.Add(s4);
            Student.ListofStudent.Add(s5);

            Teacher.ListofTeacher.Add(t);
            Teacher.ListofTeacher.Add(t1);
            Teacher.ListofTeacher.Add(t2);
            Teacher.ListofTeacher.Add(t3);

            t.addStudents(s1);
            t.addStudents(s4);
            t1.addStudents(s);
            t1.addStudents(s3);
            t2.addStudents(s2);
            t3.addStudents(s5);

            Console.WriteLine("Список студентов:");
            foreach (Student stud in Student.ListofStudent)
                stud.Print();
            Console.WriteLine(" ");
            Console.WriteLine("Список преподавателей:");
            foreach (Teacher teac in Teacher.ListofTeacher)
                teac.Print();

            StudentWithAdvisor sss = new StudentWithAdvisor(Student.RandomStudent(), Teacher.RandomTeacher());
            sss.toApply();

            Console.WriteLine(" ");
            Console.WriteLine("Список студентов с преподавателем:");
            foreach (StudentWithAdvisor stud in sss.studentswithadvisor)
                stud.Print();

            Console.WriteLine(" ");
            Console.WriteLine("Список преподавателей со студентами:");
            foreach (Teacher teac in Teacher.ListofTeacher)
            {
                Console.WriteLine(" ");
                teac.Print();
                foreach (Student stud in teac.getStudents())
                    stud.Print();
            }
                


        }
    }
}
 