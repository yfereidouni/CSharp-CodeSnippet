// See https://aka.ms/new-console-template for more information


using iEvents.EventSamples;

Teacher teacher = new Teacher("Yasser");

TeacherNameChangeLogger tl1 = new TeacherNameChangeLogger();

teacher.TeacherNameChange += tl1.Log;

teacher.SetName("Meysam");