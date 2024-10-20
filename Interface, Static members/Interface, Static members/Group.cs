using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interface__Static_members
{
	internal class Group
	{
		public static Group[] Groups = new Group[0];
		static int GroupCount = 0;
		public int GroupId { get; set; }
		public string GroupName { get; set; }
		public Student[] Students = new Student[0];



		public Group(string groupname)
		{
			GroupId = ++GroupCount;
			GroupName = groupname;
			Students = new Student[0];
		}

		public void GetGroupInfo()
		{
			Console.WriteLine($"Group Name: {GroupName}\nGroup ID: {GroupId}\nStudent Count: {Students.Length}");
		}

		public Student GetStudent(int id)
		{
			foreach (var student in Students)
			{
				if (student != null && student.Id == id)
				{
					return student;
				}
			}
			return null;
		}


		public void AddStudent(Student student)
		{
			Array.Resize(ref Students, Students.Length + 1);
			Students[Students.Length - 1] = student;
		}

		public void RemoveStudent(int id)
		{

			Student[] newArr = new Student[Students.Length - 1];
			int j = 0;
			for (int i = 0; i < Students.Length; i++)
			{

				if (id != Students[i].Id)
				{
					newArr[j] = Students[i];
					j++;
				}

			}
			Students = newArr;
			Console.WriteLine($"Student with {id} ID was removed");
		}


		public void ShowStudent()
		{
			for (int i = 0; i < Students.Length; i++)
			{

				Console.WriteLine($"{i + 1}){Students[i].Name} {Students[i].Surname} - ID: {Students[i].Id}");

			}
		}


		public static void AddGroup(Group group)
		{
			Array.Resize(ref Groups, Groups.Length + 1);
			Groups[Groups.Length - 1] = group;
		}

		public static void RemoveGroup(int groupid)
		{
			Group[] newArr = new Group[Groups.Length - 1];
			int j = 0;
			for (int i = 0; i < Groups.Length; i++)
			{
				if (groupid != Groups[i].GroupId)
				{
					newArr[j] = Groups[i];
					j++;
				}
			}
			Groups = newArr;
			Console.WriteLine($"Group with {groupid} ID was removed.");
		}

		public static void ShowAllGroups()
		{
			foreach (var group in Groups)
			{
				Console.WriteLine($"Group Name: {group.GroupName}\nGroup Id: {group.GroupId}");

				Console.WriteLine("\nStudents");

				group.ShowStudent();
				Console.WriteLine("-------------------------------");
			}
		}
	}
}
