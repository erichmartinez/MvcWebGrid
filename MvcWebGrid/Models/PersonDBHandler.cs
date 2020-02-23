using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebGrid.Models
{
    public class PersonDBHandler
    {
        readonly int id;
        readonly string name;
        readonly string address;
        readonly string phone;
        readonly string email;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public string Phone { get { return phone; } }
        public string Email { get { return email; } }

        public PersonDBHandler(int id, string name, string address, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        PersonDBHandler() { }

        public static List<PersonDBHandler> GetPersonList()
        {
            return new List<PersonDBHandler>
                       {
                           new PersonDBHandler(id:1, name: "Eric", address: "Austin, TX", phone: "1234567894", email: "eric@email.com"),
                           new PersonDBHandler(id:2, name: "Dan", address: "Austin, TX", phone: "2234567894", email: "dan@email.com"),
                           new PersonDBHandler(id:3, name: "Alex", address: "Austin, TX", phone: "3234567894", email: "alex@email.com"),
                           new PersonDBHandler(id:4, name: "John", address: "Austin, TX", phone: "4234567894", email: "john@email.com"),
                           new PersonDBHandler(id:5, name: "Chris", address: "Austin, TX", phone: "5234567894", email: "chris@email.com"),
                           new PersonDBHandler(id:6, name: "Stan", address: "Austin, TX", phone: "6234567894", email: "stan@email.com"),
                           new PersonDBHandler(id:7, name: "Adam", address: "Austin, TX", phone: "7234567894", email: "adam@email.com"),
                           new PersonDBHandler(id:8, name: "Steve", address: "Austin, TX", phone: "8234567894", email: "steve@email.com"),
                           new PersonDBHandler(id:9, name: "Chad", address: "Austin, TX", phone: "9234567894", email: "chad@email.com"),
                           new PersonDBHandler(id:10, name: "Dave", address: "Austin, TX", phone: "0234567894", email: "dave@email.com")
                       };
        }
    }
}