using Microsoft.EntityFrameworkCore;
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

    public void UpdateTag_ConectedScenario(int tagId, string newName)
    {
        var tag = courseStoreDbContext.Tags.Find(tagId);
        Console.WriteLine($"Tags State : {courseStoreDbContext.Entry(tag).State} | TagsId: {tag.TagId}");
        tag.Name = newName;
        Console.WriteLine($"Tags State : {courseStoreDbContext.Entry(tag).State} | TagsId: {tag.TagId}");
        courseStoreDbContext.SaveChanges();
        Console.WriteLine($"Tags State : {courseStoreDbContext.Entry(tag).State} | TagsId: {tag.TagId}");
    }

    public CourseDTO GetCourse(int id)
    {
        var result = courseStoreDbContext.Courses.Where(c => c.CourseId == id).Select(c =>
        new CourseDTO
        {
            Id = c.CourseId,
            Name = c.Name,
            Description = c.Description,
        }).FirstOrDefault();
        return result;
    }

    public void UpdateCourse_DisconnectedScenario_Way1(CourseDTO dto)
    {
        // Specific update command just for updated field
        var course = courseStoreDbContext.Courses.FirstOrDefault(c => c.CourseId == dto.Id);
        // course is an attached object
        course.Description = dto.Description;
        course.Name = dto.Name;
        courseStoreDbContext.SaveChanges();
    }

    public TagDTO GetTag(int id)
    {
        var result =  courseStoreDbContext.Tags.Where(c => c.TagId == id).Select(c=> 
        new TagDTO 
        {
            Id= c.TagId,
            Name= c.Name,
        }).FirstOrDefault();
        return result;
    }
    
    public void UpdateTag_DisconnectedScenario_Way2(TagDTO dto)
    {
        // Disconnected Entity and Unattached
        Tag tag = new Tag 
        {
            TagId = dto.Id,
            Name = dto.Name,
        };
        // Become attached and modified state
        courseStoreDbContext.Update(tag);
        courseStoreDbContext.SaveChanges(true);
    }

    public void DeleteCourse_SoftDelete(int id)
    {
        var course = courseStoreDbContext.Courses.SingleOrDefault(c => c.CourseId == id);
        course.IsDeleted = true;
        courseStoreDbContext.SaveChanges();
    }

    public void DisplayAllCourse()
    {
        var courses = courseStoreDbContext.Courses.ToList();
        //var courses = courseStoreDbContext.Courses.IgnoreQueryFilters().ToList(); // IgnoreQueryFilters
        foreach (var course in courses)
        {
            Console.WriteLine($"{course.CourseId} | {course.Name} | {course.IsDeleted}");
        }
    }
    public void DisplayAllTags()
    {
        var tags = courseStoreDbContext.Tags.ToList();
        //var courses = courseStoreDbContext.Courses.IgnoreQueryFilters().ToList(); // IgnoreQueryFilters
        foreach (var tag in tags)
        {
            Console.WriteLine($"{tag.TagId} | {tag.Name} | {tag.IsDeleted}");
        }
    }

    public void DeleteTag_PhysicalDelete(int id)
    {
        var tag = courseStoreDbContext.Tags.SingleOrDefault(c => c.TagId == id);
        courseStoreDbContext.Remove(tag);
        courseStoreDbContext.SaveChanges();
        Console.WriteLine($"Tag: '{tag.Name}' was deleted");
    }
}
