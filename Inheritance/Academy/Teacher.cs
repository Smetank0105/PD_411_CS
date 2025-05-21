﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Teacher:Human
	{
		public string Speciality { get; set; }
		public double Experience { get; set; }
		public Teacher
			(
				string lastName, string firstName, int age,
				string speciality, double experience
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine($"TConstructor: {this.GetHashCode()}");
		}
		~Teacher()
		{
			Console.WriteLine($"TDestructor: {this.GetHashCode()}");
		}

		public override void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Experience}");
		}
		public override string ToString()
		{
			return base.ToString() + $", {Speciality} {Experience}";
		}
	}
}
