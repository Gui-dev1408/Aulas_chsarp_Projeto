using ServicehubClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHubClass
{
    public class Usuario
    {


        //atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }


        //metodos
        public Usuario(int id, string nome, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public bool Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Ativo);
        }
        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_alterar";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Ativo);

            if (cmd.ExecuteNonQuery() > 0)
                atualizado = true;

            cmd.Connection.Close();

            return atualizado;
        }

    }
}

