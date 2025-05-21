﻿using System;
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
		public Student(Student other) : base(other) //здесь неявно происходит Upcast - преобразование объекта дочернего класса в объект базового класса
		{
			this.Speciality = other.Speciality;
			this.Group = other.Group;
			this.Rating = other.Rating;
			this.Attendance = other.Attendance;
			Console.WriteLine($"SCopyConstructor\t:{this.GetHashCode()}");
		}
		public Student(string[] str) : base(str)
		{
			if (str.Length >= 8)
			{
				Speciality = str[4];
				Group = str[5];
				Rating = Convert.ToDouble(str[6]);
				Attendance = Convert.ToDouble(str[7]);
				Console.WriteLine($"SConstructor\t:{this.GetHashCode()}");
			}
			else
				throw new ArgumentException("Ошибка чтения из файла");
		}
		~Student()
		{
			Console.WriteLine($"SDestructor\t:{this.GetHashCode()}");
		}
		public override void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");
		}
		public override string ToString()
		{
			return base.ToString() 
				+ $"{Speciality.PadRight(25)}{Group.PadRight(8)}{Rating.ToString().PadRight(8)}{Attendance.ToString().PadRight(8)}";
		}
		public override string ToFileString()
		{
			return base.ToFileString() + $",{Speciality},{Group},{Rating},{Attendance}";
		}
	}
}