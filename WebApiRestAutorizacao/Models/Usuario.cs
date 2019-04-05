using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiRestAutorizacao.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Role { get; set; }

        public Usuario Get(string Login, string Senha)
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario() { Id = 1, Login = "csilva", Nome = "Claudio Silva", Role = "Admin", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 2, Login = "lsilva", Nome = "Leandro Silva", Role = "Usuario", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 3, Login = "fsilva", Nome = "Fabio Silva", Role = "Usuario", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 4, Login = "gsilva", Nome = "Geraldo Silva", Role = "Usuario", Senha = "123" });

            return usuarios.Find(x => x.Login.Equals(Login) && x.Senha.Equals(Senha));
        }


        public Usuario Get(int Id)
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario() { Id = 1, Login = "csilva", Nome = "Claudio Silva", Role = "Admin", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 2, Login = "lsilva", Nome = "Leandro Silva", Role = "Usuario", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 3, Login = "fsilva", Nome = "Fabio Silva", Role = "Usuario", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 4, Login = "gsilva", Nome = "Geraldo Silva", Role = "Usuario", Senha = "123" });

            return usuarios.Find(x => x.Id.Equals(Id));
        }
        public List<Usuario> list()
        {
            List<Usuario> usuarios = new List<Usuario>();

            usuarios.Add(new Usuario() { Id = 1, Login = "csilva", Nome = "Claudio Silva", Role = "Admin", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 2, Login = "lsilva", Nome = "Leandro Silva", Role = "Usuario", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 3, Login = "fsilva", Nome = "Fabio Silva", Role = "Usuario", Senha = "123" });
            usuarios.Add(new Usuario() { Id = 4, Login = "gsilva", Nome = "Geraldo Silva", Role = "Usuario", Senha = "123" });

            return usuarios;
        }
    }
}