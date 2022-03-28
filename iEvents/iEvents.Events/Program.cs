// See https://aka.ms/new-console-template for more information

using iEvents.Events;



Teacher teacher = new Teacher("Yasser","Student");

TeacherNameChangeLogger tl1 = new TeacherNameChangeLogger();

teacher.TeacherNameChange += tl1.Log;

teacher.SetName("Meysam");
