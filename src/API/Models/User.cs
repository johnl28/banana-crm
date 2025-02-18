using System.ComponentModel.DataAnnotations;

namespace BananaApi.Models;


class User {
  [Key]
  public int Id { get; set; }

  [Required]
  [StringLength(100)]
  public string? Name { get; set; }

  [Required]
  [StringLength(100)]
  public string? Email { get; set; }

}

