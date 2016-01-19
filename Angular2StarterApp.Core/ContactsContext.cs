using Angular2StarterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular2StarterApp.Core
{
    public class ContactsContext
    {
        List<Contact> contacts = new List<Contact>();

        public ContactsContext()
        {
            contacts.Add(new Contact
            {
                ID = new Guid("7FD0838F-7B75-4DF5-964D-2A9AC1EB065A").ToString(),
                Name = "Luke Skywalker",
                Phone = "1597534568",
                Email = "skywalker@theforce.net",
                Image = "http://i.kinja-img.com/gawker-media/image/upload/w4xalikhxwwc4tcrnzor.jpg"
            });
            contacts.Add(new Contact
            {
                ID = new Guid("66BAF446-EF31-40DA-8A21-3ED68486EBC5").ToString(),
                Name = "Leia Organa",
                Phone = "1597534568",
                Email = "leia.organa@theforce.net",
                Image = "http://images-cdn.moviepilot.com/image/upload/c_fill,h_1200,w_1600/t_mp_quality/image-star-wars-episode-vii-does-princess-leia-have-a-larger-role-than-we-think-jpeg-63031.jpg"
            });
            contacts.Add(new Contact
            {
                ID = new Guid("3A0AE713-C4EC-435B-844A-0257AF53920E").ToString(),
                Name = "Han Solo",
                Phone = "1597534568",
                Email = "solo@theforce.net",
                Image = "http://s3.amazonaws.com/digitaltrends-uploads-prod/2012/11/han-solo.jpeg"
            });
            contacts.Add(new Contact
            {
                ID = new Guid("0660B473-8074-4387-BD35-163966E15F4F").ToString(),
                Name = "Chewy",
                Phone = "1597534568",
                Email = "chewy123@wookie.com",
                Image = "http://chewyandthegang.com/sitebuilder/images/CHEWY_CHEWBACCA-221x235.jpg"
            });
            contacts.Add(new Contact
            {
                ID = new Guid("053F450D-053E-46C2-89B9-ADF39F0F9867").ToString(),
                Name = "R2-D2",
                Phone = "1597534568",
                Email = "",
                Image = "http://www.galacticbinder.com/images/articles/R2-D2.jpg"
            });
            contacts.Add(new Contact
            {
                ID = new Guid("8BDD958E-B077-463E-8EAA-7708D865DC4A").ToString(),
                Name = "C-3PO",
                Phone = "1597534568",
                Email = "",
                Image = "https://pbs.twimg.com/profile_images/22039052/03.01.c3po.jpg"
            });
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public Contact GetContact(string id)
        {
            return contacts.Find(i => i.ID == id);
        }

        public Contact AddContact(Contact contact)
        {
            contact.ID = Guid.NewGuid().ToString();
            contacts.Add(contact);

            return GetContact(contact.ID);
        }

        public Contact UpdateContact(Contact contact)
        {
            var index = contacts.IndexOf(contacts.Find(i => i.ID == contact.ID));
            contacts.RemoveAt(index);
            contacts.Insert(index, contact);

            return GetContact(contact.ID);
        }
    }
}
