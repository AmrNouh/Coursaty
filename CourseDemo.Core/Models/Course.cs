using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseDemo.Core.Models
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Course Name Is Required")]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        public byte[] Image { get; set; }

        [Display(Name = "Course PromoLink")]
        [Column(TypeName = "nvarchar(250)")]
        public string PromoLink { get; set; }

        [Display(Name = "Course Website")]
        public string Website { get; set; }

        [Display(Name = "Track")]
        public bool IsTrack { get; set; }

        [ForeignKey("Category")]
        public Guid CategroyId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Course Duration is Required")]
        public string Duration { get; set; }

        [ForeignKey("Type")]
        public Guid TypeId { get; set; }

        [Range(0, 100000)]
        [Column(TypeName = "decimal(10,3)")]
        public decimal Price { get; set; }

        [ForeignKey("Currency")]
        public Guid CurrencyId { get; set; }

        [ForeignKey("Language")]
        public Guid LanguageId { get; set; }

        [Display(Name = "Video Transcript")]
        public string VideoTranscript { get; set; }

        [ForeignKey("Status")]
        public Guid StatusId { get; set; }

        [ForeignKey("Level")]
        public Guid LevelId { get; set; }

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

        [Required(AllowEmptyStrings = false, ErrorMessage = "Instructor Name is required")]
        public string Insetructor { get; set; }
        public bool HasCeritifcate { get; set; }
        public string CertificateComments { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime ApplicationDueDate { get; set; }
        public string Effort { get; set; }
        public int NumberOfSessions { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime RealsedDate { get; set; }
        public int MinNumberOfStudent { get; set; }
        public int MaxNumberOfStudent { get; set; }
        public string CourseFee { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime DiscountEndDate { get; set; }

        [Column(TypeName = "decimal(10,3)")]
        public decimal DiscountPercentage { get; set; }
        public string SearchTags { get; set; }

        // Nav properties
        public Category Category { get; set; }
        public CourseType Type { get; set; }
        public Currency Currency { get; set; }
        public Language Language { get; set; }
        public Status Status { get; set; }
        public Level Level { get; set; }

        public ICollection<CourseGainSkill> CourseGainSkills { get; set; }
        public ICollection<CourseRequiredSkill> CourseRequiredSkills { get; set; }
        public ICollection<CourseModule> CourseModules { get; set; }

        public Course()
        {
            CourseGainSkills = new List<CourseGainSkill>();
            CourseRequiredSkills = new List<CourseRequiredSkill>();
            CourseModules = new List<CourseModule>();
        }
    }
}
