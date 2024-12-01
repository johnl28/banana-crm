using System.ComponentModel.DataAnnotations;

namespace BananaApi.Models;

public class ContactDto {
  [Required]
  [StringLength(100)]
  public string? FirstName { get; set; }

  [StringLength(100)]
  public string? LastName { get; set; }

  [Required]
  [StringLength(100)]
  public string? Email { get; set; }

  [StringLength(15)]
  public string? Phone { get; set; }

  [MaxLength(200)]
  public string? Note { get; set; }
}

public class Contact {
  [Key]
  public int Id { get; set; } 
  
  [Required]
  [StringLength(100)]
  public string? FirstName { get; set; }

  [StringLength(100)]
  public string? LastName { get; set; }

  [Required]
  [StringLength(100)]
  public string? Email { get; set; }

  [StringLength(15)]
  public string? Phone { get; set; }

  [MaxLength(200)]
  public string? Note { get; set; }

}





