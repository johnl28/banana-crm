
using Microsoft.AspNetCore.Mvc;
using BananaApi.Models;
using BananaApi.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BananaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController: ControllerBase {

  private readonly ContactContext _context;
  private readonly ILogger<ContactController> _logger;

  public ContactController(ContactContext context, ILogger<ContactController> logger) 
  {
    _logger = logger;
    _context = context;
  }


  [HttpGet(Name="GetContactList")]
  public async Task<IActionResult> GetContacts()
  {
    ICollection<Contact> contacts = await _context.Contacts.Take(10).ToListAsync();

    return Ok(contacts);
  }

  [HttpPost(Name="CreateContact")]
  public async Task<IActionResult> CreateContact([FromBody] ContactDto contactDto)
  {
    if(!ModelState.IsValid)
    {
      return BadRequest(contactDto);
    }


    await _context.Contacts.AddAsync(new Contact { 
      FirstName = contactDto.FirstName,
      LastName = contactDto.LastName,
      Email = contactDto.Email,

    });

    return Ok(contactDto);
  }

}

