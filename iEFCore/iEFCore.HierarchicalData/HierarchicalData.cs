using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.HierarchicalData;

public class HierarchicalData
{
    private readonly HierarchicalDbContext hierarchicalDbContext;

    public HierarchicalData(HierarchicalDbContext hierarchicalDbContext)
    {
        this.hierarchicalDbContext = hierarchicalDbContext;
    }

    public Employee GetEmployees()
    {
        return hierarchicalDbContext.Employees.Include(c => c.Children).ToList().Where(c => !c.ParentId.HasValue).FirstOrDefault();
    }

    public void PrintHierarchicalEmployee(Employee employee)
    {
        //var employee = hierarchicalData.GetEmployees();

        Console.WriteLine($"(0) {employee.FirstName},{employee.LastName}");
        foreach (var level1 in employee.Children)
        {
            Console.WriteLine($"\t(1) {level1.FirstName},{level1.LastName}");
            foreach (var level2 in level1.Children)
            {
                Console.WriteLine($"\t\t(2) {level2.FirstName},{level2.LastName}");
                foreach (var level3 in level2.Children)
                {
                    Console.WriteLine($"\t\t\t(3) {level3.FirstName},{level3.LastName}");
                    foreach (var level4 in level3.Children)
                    {
                        Console.WriteLine($"\t\t\t\t(4) {level4.FirstName},{level3.LastName}");
                    }
                }
                //Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}
