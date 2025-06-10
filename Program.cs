using System;
using Final.Models;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    Address = "123 Main Street"
                };

                // Add student to context
                context.Students.Add(student);

                // Save changes to database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.WriteLine($"Added student: {student.FirstName} {student.LastName}");
            }
        }
    }
}