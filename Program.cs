using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpclass
{
    public class Program
    {
        // STEP 1: The following methods are incorrect! Read what they are supposed to do, and write them correctly. Inputs and outputs should be good as-is.
        // You can run this program, and the console output will let you know how well you did!
        // For the purposes of this exercise, please do not use LINQ, or any external C# libraries.

        // Challenge 1: Say hello! Generate a message to send to this student, include their name, and return the message!
        private static string SayHello(Student student)
        {
            return "hello doggy";
        }

        // Challenge 2: Say hello to everyone! Do what you did in challenge 1, but do it for the entire class!
        private static string SayHello(List<Student> students)
        {
            return "hello doggies";
        }

        // Challenge 3: Are you in my group? Return true if the student is in the selected group, false if they are not.
        private static bool IsInGroup(Student student, string groupName)
        {
            return false;
        }

        // Challenge 4: Create and add a new student! Use console inputs to define and create a new student object, then add that object to the existing students list.
        // Extra credit: Reject the student if they do not belong to one of the existing student groups.
        private static List<Student> AddNewStudent(string studentName, string studentEmail, string studentGroup, List<Student> existingStudents)
        {
            return existingStudents;
        }

        // Challenge 5: Expel a student from the class! Find the student by name, and kick them out of the class, by removing them from the student list!
        private static List<Student> ExpelStudent(string studentNameToExpel, List<Student> students)
        {
            return students;
        }

        // Challenge 6: Get the longest name in the class! Find the student who has the most letters or characters in their name, and return them in this method!
        private static Student GetLongestNamedStudent(List<Student> students)
        {
            return students[0];
        }

        // Challenge 7: Automatically generate a username for a student!
        // Username should be the first letter of their first name, and full last name. Only letters are allowed in usernames, and all usernames should be all lowercase.
        private static string GenerateUsername(Student student)
        {
            return "";
        }

        // Challenge 8: Populate usernames! Reuse your method above to populate the Username field on all the student objects!
        private static List<Student> PopulateUsernames(List<Student> students)
        {
            return students;
        }

        // Challenge 9: Generate an anagram of the student's name, and return it. Reverse all the letters! Don't change character casing
        private static string GenerateAnagramOfName(Student student)
        {
            return "sdrawkcaB";
        }

        // An in-memory database of students in this class
        private static List<Student> LoadStudentDatabase()
        {
            var students = new List<Student>();

            students.Add(new Student() { Name = "Noah Yoskowitz", EmailAddress = "noah.yosko@gmail.com", GroupName = "Lexington High"} );
            students.Add(new Student() { Name = "Philip Gross", EmailAddress = "antonymaus90@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Gergana Beluhova", EmailAddress = "gbeluhova@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Tomek Regulski", EmailAddress = "tomek.regulski@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Chris Bartlo", EmailAddress = "christopher.h.bartlo@gmail.com", GroupName = "Pascack Hills"} );
            students.Add(new Student() { Name = "Sarah Napolitano", EmailAddress = "snapolit@binghamton.edu", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Maxwell Madzar", EmailAddress = "maxwell.d.madzar@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Jamie Smith", EmailAddress = "jamiesmith357@gmail.com", GroupName = "Lexington High"} );
            students.Add(new Student() { Name = "Alex Schneider", EmailAddress = "francissteez@yahoo.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Dan Intriligator", EmailAddress = "Dintriligator@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Alex Waldbaum", EmailAddress = "waldbauma686@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Kyrie McCormick", EmailAddress = "kyrie.mccormick@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Drew Angus", EmailAddress = "angusa01@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Jared Jones", EmailAddress = "jjoneslf@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Cameron Brown-Cross", EmailAddress = "ccross0902@gmail.com", GroupName = "Bentley"} );
            students.Add(new Student() { Name = "Gitanjali Stevens", EmailAddress = "gitanjalistevens1@gmail.com", GroupName = "Bentley"} );
            students.Add(new Student() { Name = "Justin Sikora", EmailAddress = "gameofwhat88@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Jared Babinec", EmailAddress = "jbabinec1@gmail.com", GroupName = "Hartwick"} );
            students.Add(new Student() { Name = "Samantha Rowen", EmailAddress = "samanthaschreiner14@gmail.com", GroupName = "Family"} );

            return students;
        }

        // This method tests all of the challenges above, and lets you know how you did!
        public static void Main(string[] args)
        {
            var students = LoadStudentDatabase();

            var firstStudent = students[0];
            var hello = SayHello(firstStudent);
            var challenge1 = hello.Contains(firstStudent.Name) && hello != firstStudent.Name;

            var helloAll = SayHello(students);
            var challenge2 = students.All(student => helloAll.Contains(student.Name));

            var challenge3 = IsInGroup(firstStudent, firstStudent.GroupName) && !IsInGroup(firstStudent, "bogus group name");
            
            students = AddNewStudent("Jack Bauerle", "jackcbauerle@gmail.com", "Self", students);
            var challenge4 = students.Any(student => student.Name == "Jack Bauerle" && student.EmailAddress == "jackcbauerle@gmail.com" && student.GroupName == "Self");

            students.Add(new Student() { Name="jeek" });
            students = ExpelStudent("jeek", students);
            var challenge5 = !students.Any(student => student.Name == "jeek");

            students = students.Where(student => student.Name != "jeek").ToList();

            var fakeStudents = AddNewStudent("John Jacob Jingleheimer-Schmitt", "whatever", "whatever", students);
            var challenge6 = GetLongestNamedStudent(fakeStudents).Name == "John Jacob Jingleheimer-Schmitt";

            var cameron = students.First(student => student.Name == "Cameron Brown-Cross");
            var camUsername = "cbrowncross";
            var challenge7 = GenerateUsername(cameron) == camUsername;
            var originalCount = students.Count;
            var populatedStudents = PopulateUsernames(students);
            var challenge8 = true;
            foreach (var student in populatedStudents) 
            {
                if (UsernamesByStudentName[student.Name] != student.Username)
                {
                    challenge8 = false;
                }
            }

            if (originalCount != populatedStudents.Count)
            {
                challenge8 = false;
            }
            
            var jack = new Student() { Name = "Jack Bauerle"};
            var challenge9 = GenerateAnagramOfName(jack) == "elreuaB kcaJ";
            
            Console.WriteLine("Challenge 1: " + PassOrFail(challenge1));
            Console.WriteLine("Challenge 2: " + PassOrFail(challenge2));
            Console.WriteLine("Challenge 3: " + PassOrFail(challenge3));
            Console.WriteLine("Challenge 4: " + PassOrFail(challenge4));
            Console.WriteLine("Challenge 5: " + PassOrFail(challenge5));
            Console.WriteLine("Challenge 6: " + PassOrFail(challenge6));
            Console.WriteLine("Challenge 7: " + PassOrFail(challenge7));
            Console.WriteLine("Challenge 8: " + PassOrFail(challenge8));
            Console.WriteLine("Challenge 9: " + PassOrFail(challenge9));
        }

        private static Dictionary<string,string> UsernamesByStudentName = new Dictionary<string,string>() 
        {
            { "Noah Yoskowitz", "nyoskowitz" },
            { "Philip Gross", "pgross" },
            { "Gergana Beluhova", "gbeluhova" },
            { "Tomek Regulski", "tregulski" },
            { "Chris Bartlo", "cbartlo" },
            { "Sarah Napolitano", "snapolitano" },
            { "Maxwell Madzar", "mmadzar" },
            { "Jamie Smith", "jsmith" },
            { "Alex Schneider", "aschneider" },
            { "Dan Intriligator", "dintrilligator" },
            { "Alex Waldbaum", "awaldbaum" },
            { "Kyrie McCormick", "kmccormick" },
            { "Drew Angus", "dangus" },
            { "Jared Jones", "jjones" },
            { "Cameron Brown-Cross", "cbrowncross" },
            { "Gitanjali Stevens", "gstevens" },
            { "Justin Sikora", "jsikora" },
            { "Jared Babinec", "jbabinec" },
            { "Samantha Rowen", "srowen" }
        };

        private static string PassOrFail(bool result)
        {
            return result ? "Pass" : "Fail";
        }
    }

    class Student 
    {
        public string Name;
        public string EmailAddress;
        public string GroupName;
        public bool IsHere = false;

        public string Username = null;
    }
}
