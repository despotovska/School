using System;

namespace School
{
    public class SchoolDatabase
    {
        public bool Register(Student student)
        {
            if (student.IsSmart())
            {
                AddStudent();

                return true;
            }

            return false;
        }

        private void AddStudent()
        {
            Console.WriteLine("Student Added");
        }
    }
}
