using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace SistemaDeRecursosHumanos
{
    class FuncionarioInfo
    {

        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Código do Funcionário")]
        public string codigoFuncionario { get; set; }

        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("Gênero")]
        public string genero { get; set; }

        [DisplayName("Contato")]
        public string contato { get; set; }

        [DisplayName("Cargo")]
        public string cargo { get; set; }

        [DisplayName("Imagem")]
        public string imagem { get; set; }

        [DisplayName("Salário")]
        public int salario { get; set; }

        [DisplayName("Status")]
        public string status { get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\danie\OneDrive\Área de Trabalho\SistemaDeRecursosHumanos\SistemaDeRecursosHumanos\BancoDeDado.mdf"";Integrated Security=True");
    

        public List<FuncionarioInfo> listaInfoFucionario()
        {
            List<FuncionarioInfo> listdata = new List<FuncionarioInfo>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM VPL_FUNCIONARIO WHERE deletarData IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            FuncionarioInfo ed = new FuncionarioInfo();
                            ed.ID = (int)reader["id"];
                            ed.codigoFuncionario = reader["funcionarioId"].ToString();
                            ed.nome = reader["nomeFuncionario"].ToString();
                            ed.genero = reader["generoFuncionario"].ToString();
                            ed.contato = reader["telefoneFuncionario"].ToString();
                            ed.cargo = reader["cargo"].ToString();
                            ed.imagem = reader["imagemFuncionario"].ToString();
                            ed.salario = (int)reader["salario"];
                            ed.status = reader["statusFuncionario"].ToString();

                            listdata.Add(ed);
                        }
                    }
                        
                }catch(Exception ex)
                {
                    Console.WriteLine("Erro: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

        public List<FuncionarioInfo> listaInfoSalario()
        {
            List<FuncionarioInfo> listdata = new List<FuncionarioInfo>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM VPL_FUNCIONARIO WHERE deletarData IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            FuncionarioInfo ed = new FuncionarioInfo();
                            ed.codigoFuncionario = reader["funcionarioId"].ToString();
                            ed.nome = reader["nomeFuncionario"].ToString();
                            ed.cargo = reader["cargo"].ToString();
                            ed.salario = (int)reader["salario"];

                            listdata.Add(ed);
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
