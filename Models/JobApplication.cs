using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Company")]
        public string Company { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Date Applied")]
        [DataType(DataType.Date)]
        public DateTime DateApplied{ get; set; } = DateTime.Today;

        [Display(Name = "Status")]
        public ApplicationStatus Status { get; set; } = ApplicationStatus.Applied;
        
        [Display(Name = "Job Posting URL")]
        public string? Url { get; set; }

        [Display(Name = "Notes")]
        public string? Notes { get; set; }

        public string UserId { get; set; } = string.Empty;
    }

    public enum  ApplicationStatus
    {
        Applied,
        PhoneScreen,
        Interview,
        Offer,
        Rejected
    }
}
