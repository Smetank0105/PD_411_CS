using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Student:Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }
		public Student
			(
			string last_name, string first_name, int age,
			string speciality, string group, double rating, double attendance
			):base(last_name,first_name,age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"SConstructor\t:{this.GetHashCode()}");
		}
		public Student(Human human, string speciality, string group, double rating, double attendance):base(human)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"SConstructor\t:{this.GetHashCode()}");
		}
		~Student()
		{
			Console.WriteLine($"SDestructor\t:{this.GetHashCode()}");
		}
		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");
		}
	}
}