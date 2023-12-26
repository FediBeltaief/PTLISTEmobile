using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PTLISTEmobile
{
    public class ContactsDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ContactsDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Contact>().Wait();
        }
        public Task<int> SaveContactAsync(Contact contact)
        {
            if (contact.ID != 0)
            {
                return _database.UpdateAsync(contact);
            }
            else
            {
                return _database.InsertAsync(contact);
            }
        }
        public Task<List<Contact>> GetContactAsync()
        {
            return _database.Table<Contact>().ToListAsync();
        }
        public Task<Contact> GetContactAsync(int id)
        {
            return _database.Table<Contact>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> DeleteContactAsync(Contact contact)
        {
            return _database.DeleteAsync(contact);

        }
    }
}
