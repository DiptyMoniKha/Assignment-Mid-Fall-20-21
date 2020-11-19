using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Program
    {
        static void Main(string[] args)
        {

            Department d = new Department("CSE");
            Course oop2 = new Course("Course1", "Courseid");
            Course oop1= new Course("Course1", "Courseid");
            d.AddCourse(oop2);
            d.AddCourse(oop1);
            Section A = new Section("Section");
            Section B = new Section("Section");
            oop2.AddSection(A);
            oop1.AddSection(B);
            Faculty F = new Faculty("Faculty name", "Faculty ID",10.5f);
            Faculty F2 = new Faculty("Dipty", "###ID###", 9.5f);
            F.AddSection(A);
            F2.AddSection(B);
            A.AddTeacher(F);
            B.AddTeacher(F2);
            Console.WriteLine("\nCourse object");
            oop1.ShowSectionFaculty();
            Console.WriteLine("\nFaculty object");
            F.ShowSectionDetails();
            Console.ReadLine();
        }
   
    }
}
