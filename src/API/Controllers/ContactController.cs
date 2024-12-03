
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BananaApi.Contexts;
using BananaApi.Models;
using BananaApi.Repositories;

namespace BananaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController: ControllerBase {

  private readonly IContactRepository _contactRepository;
  private readonly ContactContext _context;
  private readonly ILogger<ContactController> _logger;

  public ContactController(ContactContext context, IContactRepository contactRepository, ILogger<ContactController> logger) 
  {
    _contactRepository = contactRepository;
    _logger = logger;
    _context = context;
  }


  [HttpGet(Name="GetContactList")]
  public async Task<IActionResult> GetContacts([FromQuery] int step)
  {
    return Ok(await _contactRepository.GetContacts(step));
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetContactById(int id)
  {
    var contact = await _contactRepository.GetContactByIdAsync(id);

    if(contact == null)
    {
      return NotFound();
    }

    return Ok(contact);
  }

  [HttpPost(Name="CreateContact")]
  public async Task<IActionResult> CreateContact([FromBody] ContactDto contactDto)
  {
    if(!ModelState.IsValid)
    {
      return BadRequest(contactDto);
    }

    await _contactRepository.AddContactAsync(new Contact {
      FirstName = contactDto.FirstName,
      LastName = contactDto.LastName,
      Email = contactDto.Email,
    });

    return Ok(contactDto);
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteContactById(int id)
  {
    var contact = await _contactRepository.GetContactByIdAsync(id);
    if(contact == null)
    {
      return NotFound();
    }

    await _contactRepository.RemoveContactAsync(contact);
    return Ok();
  }

}

