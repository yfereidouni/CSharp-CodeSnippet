using iEFCore.TablePerHierarchy;

TphDbContext ctx = new TphDbContext();

Person p = new Person { FirstName = "Person-FN-01", LastName = "Person-LN-01" };
Student s = new Student { FirstName = "Student-FN-01", LastName = "Student-LN-01", StudentNumber = "SN-01" };
Teacher t = new Teacher { FirstName = "Teacher-FN-01", LastName = "Teacher-LN-01", TeacherNumber = "TN-01" };

ctx.Add(p);
ctx.Add(s);
ctx.Add(t);
ctx.SaveChanges();

var p1 = ctx.People.ToList();
var s1 = ctx.Students.ToList();
var t1 = ctx.Teachers.ToList();

Console.ReadLine();

