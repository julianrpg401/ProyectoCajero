using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCajero
{
    public class Usuario
    {
        private string name;
        private string user;
        private uint id;
        private string email;
        private string password;

        public string Name { get => name; set => name = value; }
        public string User { get => user; set => user = value; }
        public uint Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}