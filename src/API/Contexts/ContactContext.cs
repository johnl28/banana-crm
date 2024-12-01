using Microsoft.EntityFrameworkCore;
using BananaApi.Models;


namespace BananaApi.Contexts;

public class ContactContext : DbContext {
  public ContactContext(DbContextOptions options) : base(options) { }


  public DbSet<Contact> Contacts { get; set; }


}

