
using Microsoft.AspNetCore.Mvc;

using BananaApi.Contexts;
using BananaApi.Models;
using BananaApi.Repositories;

namespace BananaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase {

  private readonly IContactRepository _contactRepository;
  private readonly ContactContext _context;
  private readonly ILogger<UserController> _logger;

  public UserController(ContactContext context, IContactRepository contactRepository, ILogger<UserController> logger) 
  {
    _contactRepository = contactRepository;
    _logger = logger;
    _context = context;
  }


}

