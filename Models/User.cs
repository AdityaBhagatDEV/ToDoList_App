using System.ComponentModel.DataAnnotations;

namespace ToDoList_App.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, EmailAddress,StringLength(225)]
        public string Email { get; set; }
        [Required]
        public string HashPassword { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
    }
}
