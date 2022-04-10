using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.EFQuerySample;

public class CourseStoreCommandRepository
{
    private readonly CourseStoreDbContext courseStoreDbContext;

    public CourseStoreCommandRepository(CourseStoreDbContext courseStoreDbContext)
    {
        this.courseStoreDbContext = courseStoreDbContext;
    }

    public void AddTag(string tagName)
    {
        Tag tag = new Tag
        {
            Name = tagName
        };
        Console.WriteLine($"State: {courseStoreDbContext.Entry(tag).State}\t\t| Return Id: {tag.TagId}");
        courseStoreDbContext.Tags.Add(tag);
        Console.WriteLine($"State: {courseStoreDbContext.Entry(tag).State}\t\t| Return Id: {tag.TagId}");
        courseStoreDbContext.SaveChanges();
        Console.WriteLine($"State: {courseStoreDbContext.Entry(tag).State}\t| Return Id: {tag.TagId}");
    }

    public void AddCourseWithComment()
    {
        Course course = new Course
        {
            Name = "Modular Monolith",
            Price = 1000,
            Description = "Modular Monolith Course",
            Comments = new List<Comment>
            {
                new Comment
                {
                    CommentBy = "First Student",
                    CommentText = "That was good."
                }
            }
        };

        Console.WriteLine($"Course State: {courseStoreDbContext.Entry(course).State}\t\t| Return Id: {course.CourseId}");
        Console.WriteLine($"Comment State: {courseStoreDbContext.Entry(course.Comments.First()).State}\t\t| Return Id: {course.Comments.First().CommentId}");

        courseStoreDbContext.Courses.Add(course);
        Console.WriteLine($"Course State: {courseStoreDbContext.Entry(course).State}\t\t| Return Id: {course.CourseId}");
        Console.WriteLine($"Comment State: {courseStoreDbContext.Entry(course.Comments.First()).State}\t\t| Return Id: {course.Comments.First().CommentId}");

        courseStoreDbContext.SaveChanges();
        Console.WriteLine($"Course State: {courseStoreDbContext.Entry(course).State}\t\t| Return Id: {course.CourseId}");
        Console.WriteLine($"Comment State: {courseStoreDbContext.Entry(course.Comments.First()).State}\t| Return Id: {course.Comments.First().CommentId}");
    }

    public void AddCourseWithFullDependencies()
    {
        Course course = new Course
        {
            Name = "MicroService 2030",
            Price = 1000,
            Description = "MicroService 2030 Course",
            Comments = new List<Comment>
            {
                new Comment
                {
                    CommentBy = "Guest",
                    CommentText = "That was awesome."
                }
            },
            Tags = new List<Tag>
            {
                new Tag
                {
                    Name = "Software Architecture"
                },
                new Tag
                {
                    Name = "Software Engineering"
                },
            },
            CourseTeachers = new List<CourseTeachers>
            {
                new CourseTeachers
                {
                    Teacher = new Teacher{FirstName="Yasser",LastName="Fereidouni"},
                    SortOrder = 1,
                }
            },
            Discount = new Discount
            {
                Name = "Nowruz",
                NewPrice = 1000,
            }
        };

        Console.WriteLine("".PadRight(100, '-'));
        Console.WriteLine($"Course State  : {courseStoreDbContext.Entry(course).State}  | CourseId        : {course.CourseId}");
        Console.WriteLine($"Comment State : {courseStoreDbContext.Entry(course.Comments.First()).State}  | CommentId       : {course.Comments.First().CommentId}");
        Console.WriteLine($"Tags State    : {courseStoreDbContext.Entry(course.Tags.First()).State}  | TagsId          : {course.Tags.First().TagId}");
        Console.WriteLine($"CourseTeachers: {courseStoreDbContext.Entry(course.CourseTeachers.First()).State}  | CourseTeachersId: {course.CourseTeachers.First().CourseTeachersId}");
        Console.WriteLine($"Teacher State : {courseStoreDbContext.Entry(course.CourseTeachers.First().Teacher).State}  | TeacherId       : {course.CourseTeachers.First().Teacher.TeacherId}");
        Console.WriteLine($"Discount State: {courseStoreDbContext.Entry(course.Discount).State}  | DiscountId      : {course.Discount.DiscountId}");
        Console.WriteLine("".PadRight(100, '-'));
        courseStoreDbContext.Courses.Add(course);
        Console.WriteLine($"Course State  : {courseStoreDbContext.Entry(course).State}     | CourseId        : {course.CourseId}");
        Console.WriteLine($"Comment State : {courseStoreDbContext.Entry(course.Comments.First()).State}     | CommentId       : {course.Comments.First().CommentId}");
        Console.WriteLine($"Tags State    : {courseStoreDbContext.Entry(course.Tags.First()).State}     | TagsId          : {course.Tags.First().TagId}");
        Console.WriteLine($"CourseTeachers: {courseStoreDbContext.Entry(course.CourseTeachers.First()).State}     | CourseTeachersId: {course.CourseTeachers.First().CourseTeachersId}");
        Console.WriteLine($"Teacher State : {courseStoreDbContext.Entry(course.CourseTeachers.First().Teacher).State}     | TeacherId       : {course.CourseTeachers.First().Teacher.TeacherId}");
        Console.WriteLine($"Discount State: {courseStoreDbContext.Entry(course.Discount).State}     | DiscountId      : {course.Discount.DiscountId}");
        Console.WriteLine("".PadRight(100, '-'));
        courseStoreDbContext.SaveChanges();
        Console.WriteLine($"Course State  : {courseStoreDbContext.Entry(course).State} | CourseId        : {course.CourseId}");
        Console.WriteLine($"Comment State : {courseStoreDbContext.Entry(course.Comments.First()).State} | CommentId       : {course.Comments.First().CommentId}");
        Console.WriteLine($"Tags State    : {courseStoreDbContext.Entry(course.Tags.First()).State} | TagsId          : {course.Tags.First().TagId}");
        Console.WriteLine($"CourseTeachers: {courseStoreDbContext.Entry(course.CourseTeachers.First()).State} | CourseTeachersId: {course.CourseTeachers.First().CourseTeachersId}");
        Console.WriteLine($"Teacher State : {courseStoreDbContext.Entry(course.CourseTeachers.First().Teacher).State} | TeacherId       : {course.CourseTeachers.First().Teacher.TeacherId}");
        Console.WriteLine($"Discount State: {courseStoreDbContext.Entry(course.Discount).State} | DiscountId      : {course.Discount.DiscountId}");
        Console.WriteLine("".PadRight(100, '-'));
    }


}
