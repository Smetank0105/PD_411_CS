using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Graduate:Student
	{
		public string Subject { get; set; }
		public Graduate
			(string last_name, string first_name, int age,
			string speciality, string group, double rating, double attendance,
			string subject
			):base(last_name, first_name, age, speciality, group, rating, attendance)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor\t:{this.GetHashCode()}");
		}
		public Graduate(Student student,string subject) : base(student)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor\t:{this.GetHashCode()}");
		}
		public Graduate(string[] str) : base(str)
		{
			if (str.Length >= 9)
			{
				Subject = str[8];
				Console.WriteLine($"GConstructor\t:{this.GetHashCode()}");
			}
			else
				throw new ArgumentException("Ошибка чтения из файла");
		}
		~Graduate()
		{
			Console.WriteLine($"GDestructor\t:{this.GetHashCode()}");
		}
		public override void Info()
		{
			base.Info();
			Console.WriteLine($"\t{Subject}");
		}
		public override string ToString()
		{
			return base.ToString() + Subject.PadRight(25);
		}
		public override string ToFileString()
		{
			return base.ToFileString() + $",{Subject}";
		}
	}
}
