using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace SistemaDeRecursosHumanos
{
    class SalarioInfo
    {
        [DisplayName("ID")]
        public string Id { set; get; }

        [DisplayName("Nome")]
        public string Nome { set; get; }

        [DisplayName("Gênero")]
        public string Genero { set; get; }

        [DisplayName("Contato")]
        public string Contato { set; get; }

        [DisplayName("Cargo")]
        public string Cargo { set; get; }

        [DisplayName("Salário")]
        public int Salario { set; get; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\danie\OneDrive\Área de Trabalho\SistemaDeRecursosHumanos\SistemaDeRecursosHumanos\BancoDeDado.mdf"";Integrated Security=True");

        public List<SalarioInfo> listaInfoSalario()
        {
            List<SalarioInfo> listdata = new List<SalarioInfo>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM VPL_FUNCIONARIO WHERE statusFuncionario = 'Ativo' " +
                        "AND deletarData IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalarioInfo sd = new SalarioInfo();
                            sd.Id = reader["funcionarioId"].ToString();
                            sd.Nome = reader["nomeFuncionario"].ToString();
                            sd.Genero = reader["generoFuncionario"].ToString();
                            sd.Contato = reader["telefoneFuncionario"].ToString();
                            sd.Cargo = reader["cargo"].ToString();
                            sd.Salario = (int)reader["salario"];

                            listdata.Add(sd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

    }
}
