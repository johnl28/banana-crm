using BananaApi.Models;
using BananaApi.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BananaApi.Repositories;



public interface IContactRepository {

  Task AddContactAsync(Contact contact);
  Task<Contact?> GetContactByIdAsync(int id);
  Task<int> RemoveContactAsync(Contact user);
  Task<IEnumerable<Contact>> GetContacts(int step);
}


public class ContactRepository : IContactRepository
{
    private readonly ContactContext _contactContext;

    public ContactRepository(ContactContext contactContext)
    {
      _contactContext = contactContext;
    }


    public async Task AddContactAsync(Contact contact)
    {
      await _contactContext.Contacts.AddAsync(contact);
      await _contactContext.SaveChangesAsync();
    }

    public async Task<Contact?> GetContactByIdAsync(int id)
    {
      return await _contactContext.Contacts.FindAsync(id);
    }

    public async Task<IEnumerable<Contact>> GetContacts(int step)
    {
        return await _contactContext.Contacts.Skip(step).Take(Constants.RESULTS_PER_PAGE).ToListAsync();
    }

    public async Task<int> RemoveContactAsync(Contact user)
    {
      _contactContext.Remove(user);
      return await _contactContext.SaveChangesAsync();
    }
}


