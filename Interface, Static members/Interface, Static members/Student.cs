using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Static_members
{
	internal class Student:ICodeAcademy
	{
		static int count = 1;
		public int Id;
		public string Name;
		public string Surname;

		public string _id
		{
			get
			{
				return _id;
			}
			set
			{

				value = _id;

			}
		}

		public string _name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value.Length > 3 && value.Length < 25)
				{
					value = _name;
				}
			}
		}

		public string _surname
		{
			get
			{
				return _surname;
			}
			set
			{
				if (value.Length > 3 && value.Length < 25)
				{
					value = _surname;
				}
			}
		}

		public string CodeAcademy { get ; set ; }
		public string CodeEmail { get; set; }

		public Student(string name, string surname)
        {
			Name = name;
			Surname = surname;
			Id = count++;
			
        }

        public static void Capitalize(string name, string surname)
		{
			if (name.All(char.IsLetter) && name.Length > 3 && name.Length < 25 &&
				surname.All(char.IsLetter) && surname.Length > 3 && surname.Length < 25)
			{
				name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
				surname = char.ToUpper(surname[0]) + surname.Substring(1).ToLower();

				Console.WriteLine($"Capitalized Name: {name}");
				Console.WriteLine($"Capitalized Surname: {surname}");
			}else
			{
                Console.WriteLine("Name or Surname is wrong!");
			}
		}

		public static bool CheckName(string name, string surname)
		{

			if (name.All(char.IsLetter) && name.Length > 3 && name.Length < 25 &&
				surname.All(char.IsLetter) && surname.Length > 3 && surname.Length < 25)
			{
				Console.WriteLine(true);
				return true;
			}

			Console.WriteLine(false);
			return false;
		}

		public void GenerateEmail()
		{
			CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
            Console.WriteLine($"Generated Email: {CodeEmail}");
		}
	}
}

