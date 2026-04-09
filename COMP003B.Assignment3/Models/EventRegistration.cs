using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]

        public string FullName { get; set; }

        [Required]
        [EmailAddress]

        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]

        public string EventCode { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]

        public string EventBlank { get; set; }

        [Required]
        [Range(1,10)]

        public int Tickets { get; set; }

    }
}
