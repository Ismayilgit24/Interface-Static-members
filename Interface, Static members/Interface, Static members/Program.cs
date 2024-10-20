namespace Interface__Static_members
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Student classinin tetbiq olundugu hisse

			//Student student = new Student("Ismayil", "ibrahimzade");
			//student.GenerateEmail();
			//Student student9 = new Student("Nigar", "Abbasova");
			//student9.GenerateEmail();
			//Student student10 = new Student("Seref", "Serefov");
			//student10.GenerateEmail();

			//Student.Capitalize("seBinE", "meHTiyeva");
			//Student.CheckName("Islam", "Abbasov");



			//Group classinin tetbiq olundugu hisse

			Group group = new Group("BP217");
			Group group2 = new Group("BP218");


			Student student1 = new Student("Guler", "Esgerova");
			Student student2 = new Student("Cavid", "Memmedov");
			Student student3 = new Student("Leyla", "Abdullayeva");
			Student student4 = new Student("Mehemmed", "Eliyev");

			Student student5 = new Student("Rehim", "Quliyev");
			Student student6 = new Student("Jale", "Kerimova");
			Student student7 = new Student("Memmed", "Eliyev");
			Student student8 = new Student("Nigar", "Melikzade");


			group.AddStudent(student1);
			group.AddStudent(student2);
			group.AddStudent(student3);
			group.AddStudent(student4);


			group2.AddStudent(student5);
			group2.AddStudent(student6);
			group2.AddStudent(student7);
			group2.AddStudent(student8);




			Group.AddGroup(group);
			Group.AddGroup(group2);
			//group.RemoveStudent(1);
			//group2.RemoveStudent(5);
			//Group.ShowAllGroups();


			Group.ShowAllGroups();
			Group.RemoveGroup(2);
			//Group.ShowAllGroups();
			//group.RemoveStudent(2);
			Group.ShowAllGroups();
		}
	}
}



