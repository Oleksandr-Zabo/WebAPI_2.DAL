using System.ComponentModel.DataAnnotations;

namespace WebAPI_2.DAL.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string NickName { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        
        [Required]
        public string PasswordHash { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Role { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public List<Book> SavedBooks { get; set; } = new List<Book>();
    }
}
