using System;
using System.Collections.Generic;
using System.Text;

namespace Novo
{
    class Pessoa
    {
        public string _Id { get; set; }
        public string Index { get; set; }
        public string Guid { get; set; }
        public string IsActive { get; set; }
        public string Balance { get; set; }
        public string Picture { get; set; }
        public string Age { get; set; }
        public string Eyecolor { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string Registered { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<string> Tags { get; set; }
        public List<Friends> Friends { get; set; }       
        public EmissaoDigital Emissao { get; set; }
       
        public override string ToString()
        {
            return $"posisção: {Index}\nnome: {Name}\nsexo: {Gender}\nemail: {Email}\ntelefone: {Phone}\n ";
        }
    }
}
