using CourseDemo.Core.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoursesDemo.Models
{
    public class AddCourseViewModel
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Course Name Is Required")]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        public IFormFile Image { get; set; }

        public string ImageDataURL { get; set; }

        [Display(Name = "Course PromoLink")]
        [Column(TypeName = "nvarchar(250)")]
        public string PromoLink { get; set; }

        [Display(Name = "Course Website")]
        public string Website { get; set; }

        [Display(Name = "Track")]
        public bool IsTrack { get; set; }

        [Display(Name ="Couese/Track Category")]
        public Guid CategroyId { get; set; }
        public List<Category> Categories { get; set; }

        [Display(Name="Duration")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Course Duration is Required")]
        public string Duration { get; set; }

        [Required]
        [Display(Name = "Course/Track Type")]
        public Guid TypeId { get; set; }
        public List<CourseType> Types { get; set; }

        [Display(Name ="Price")]
        [Range(0, 100000,ErrorMessage ="Price Must be Greater Than Zero")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Course Price is Requied")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name ="Currency")]
        public Guid CurrencyId { get; set; }
        public List<Currency> Currencies { get; set; }

        [Required]
        [Display(Name ="Language")]
        public Guid LanguageId { get; set; }
        public List<Language> Languages { get; set; }

        [Display(Name = "Video Transcript")]
        public string VideoTranscript { get; set; }

        [Required]
        [Display(Name ="Couese/Track Status")]
        public Guid StatusId { get; set; }
        public List<Status> Statuses { get; set; }

        [Required]
        [Display(Name ="Course/Track Level")]
        public Guid LevelId { get; set; }
        public List<Level> Levels { get; set; }
        
        [Display(Name = "Course Reference")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Course Reference is Required")]
        public string Reference { get; set; }

        [Display(Name = "Course Reference Text")]
        public string ReferenceText { get; set; }

        [Display(Name = "Course Reference Link")]
        public string ReferenceLink { get; set; }

        [Display(Name = "Course Description")]
        public string Description { get; set; }

        [Display(Name = "Course Requirement")]
        public string Requirements { get; set; }
        public List<Skill> Skills { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Instructor Name is required")]
        public string Insetructor { get; set; }

        [Display(Name = "Has Ceritifcate")]
        public bool HasCeritifcate { get; set; }

        [Display(Name = "Certificate Comments")]
        public string CertificateComments { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        [Display(Name = "Application Due Date")]
        public DateTime ApplicationDueDate { get; set; } =  DateTime.Now;
        public string Effort { get; set; }

        [Display(Name = "Number Of Sessions")]
        public int NumberOfSessions { get; set; }

        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        [Display(Name = "Realsed Date")]
        public DateTime RealsedDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Min Number Of Student")]
        public int MinNumberOfStudent { get; set; }

        [Required]
        [Display(Name = "Max Number Of Student")]
        public int MaxNumberOfStudent { get; set; }

        [Display(Name = "Course Fee")]
        public string CourseFee { get; set; }

        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        [Display(Name = "Discount End Date")]
        public DateTime DiscountEndDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(10,3)")]
        [Display(Name = "Discount Percentage")]
        public decimal DiscountPercentage { get; set; }

        [Display(Name = "Search Tags")]
        public string SearchTags { get; set; }

        public List<Module> Modules { get; set; }

        public AddCourseViewModel()
        {
            Id = Guid.NewGuid();
            Categories = new List<Category>();
            Types = new List<CourseType>();
            Currencies = new List<Currency>();
            Languages = new List<Language>();
            Statuses = new List<Status>();
            Levels = new List<Level>();
            Skills = new List<Skill>();
            Modules = new List<Module>();

        }
    }
}
