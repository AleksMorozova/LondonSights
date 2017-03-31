using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Services.Implementation
{
    public class ContactsService : IContactsService
    {
        public Contacts GetContacts()
        {
            //Get contacts from repository
            return new Contacts();
        }
    }
}
