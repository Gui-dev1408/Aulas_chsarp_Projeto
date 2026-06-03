using ServicehubClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiceHubClass
{
    public class Nivel
    {
        // Propriedades
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        // Construtores
        public Nivel()
        {
            Id = 0;
        }

        public Nivel(int id)
        {
            this.Id = id; 
        }

        public Nivel(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla; 
        }

        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        // Métodos
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == System.Data.ConnectionState.Open)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_nivel_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);

                // O ExecuteScalar retorna o ID gerado pelo banco
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }

        // Método ObterPorId
        public static Nivel ObterPorId(int id)
        {
            Nivel niv = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                niv = new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close();
            return niv;
        }

        // Listar
        public static List<Nivel> ObterLista(string busca = "")
        {
            List<Nivel> niveis = new List<Nivel>();
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                if (busca != "")
                {
                    cmd.CommandText = "Select * from niveis where nome like '%" + busca + "%' order by nome";
                }
                else
                {
                    cmd.CommandText = "Select * from niveis order by nome";
                }
                cmd.CommandType = CommandType.Text;
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    niveis.Add(new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2) ?? ""));
                }
                dr.Close();
                cmd.Connection.Close();
            }
            return niveis;
        }


        public bool Update()
        {
            bool atualizada = false;
            if (Id < 1) return atualizada;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update niveis set nome = @spnome, sigla = @spsigla WHERE id = @spid";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if (cmd.ExecuteNonQuery() > 0) atualizada = true;
            cmd.Connection.Close();
            return atualizada;
        }

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}