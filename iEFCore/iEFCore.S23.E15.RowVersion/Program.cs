using iEFCore.S23.E15.RowVersion;

var ctx = new RowVersionDbContext();

var person = ctx.People.Find(1);
person.FirstName = "Edited2!";

try
{
    ctx.SaveChanges();
    Console.WriteLine("Record Updated Successful!");

}
catch (Exception ex)
{
    Console.WriteLine("Please reload record again!\r\n");
    Console.WriteLine(ex.Message);
}
