﻿using iCourseStore.NLayer.DAL.EF;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("------ iCourseStore ------");

var optionBuilder = new DbContextOptionsBuilder<CourseStoreDbContext>();
optionBuilder.UseSqlServer("Server=.;Initial Catalog=S26E01.iCourseStore_DB;User Id=dbuser;Password=1qaz!QAZ;");
CourseStoreDbContext ctx = new CourseStoreDbContext(optionBuilder.Options);

var result = ctx.Courses.ToList();

foreach (var course in result)
{
    Console.WriteLine($"{course.Id} {course.Title} {course.Description} {course.Price} {course.StartDate}");

}