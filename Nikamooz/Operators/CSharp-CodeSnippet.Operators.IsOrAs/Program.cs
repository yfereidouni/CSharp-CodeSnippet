// See https://aka.ms/new-console-template for more information


using CSharp_CodeSnippet.Operators.IsOrAs;

IsOrAs isOrAs = new IsOrAs();

Person person = new Person() { FirstName = "Yasser", LastName = "Fereidouni" };

Student student = new Student() { FirstName = "Shervin", LastName = "Souri", StudentNumber = "ST-10" };

Teacher teacher = new Teacher() { FirstName = "Sroush", LastName = "Sarabi", TeacherNumber = "TC-22" };


isOrAs.CheckIsPerson(person);  //Output: True
isOrAs.CheckIsPerson(student); //Output: True
isOrAs.CheckIsPerson(teacher); //Output: false , because not inherited from person


isOrAs.CheckAsPerson(person);  //Output: IS Person
isOrAs.CheckAsPerson(student); //Output: IS Person , because inherited from person
isOrAs.CheckAsPerson(teacher); //Output: IS NOT a Person , because not inherited from person
