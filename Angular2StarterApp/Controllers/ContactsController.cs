using Angular2StarterApp.Core;
using Angular2StarterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular2StarterApp.Controllers
{
    public class ContactsController : ApiController
    {
        static ContactsContext _context =  new ContactsContext();

        public ContactsController()
        {

        }

        public IHttpActionResult Get()
        {
            return Ok(_context.GetContacts());
        }

        public IHttpActionResult Get(string id)
        {
            return Ok(_context.GetContact(id));
        }

        public IHttpActionResult Post(Contact contact)
        {
            return Ok(_context.AddContact(contact));
        }

        public IHttpActionResult Put(Contact contact)
        {
            return Ok(_context.UpdateContact(contact));
        }
    }
}
