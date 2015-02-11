using MySql.Data.MySqlClient;
using SysGestor.DAL.Repositorio;
using SysGestor.DTO.ProdutoDto;
using SysGestor.RESOURCE.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.DAL.ProdutoDal
{
    public class GradeDal
    {
        public void Inserir(GradeDto gradeDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO grade(descricao) " +
                                      "VALUES (@Descricao)";

                comando.Parameters.AddWithValue("@Descricao", gradeDto.Descricao);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }
        }

        public void Alterar(GradeDto gradeDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE grade SET descricao = @Descricao " +
                                      "WHERE idgrade = @IdGrade";

                comando.Parameters.AddWithValue("@Descricao", gradeDto.Descricao);
                comando.Parameters.AddWithValue("@IdGrade", gradeDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int idGrade)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE grade SET ativo = 1 WHERE idgrade = @IdGrade";

                comando.Parameters.AddWithValue("@IdGrade", idGrade);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public void RemoveMass(int[] idGrade)
        {
            try
            {
                for (int i = 0; i < idGrade.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE grade SET ativo = 1 WHERE idgrade = @IdGrade";

                    comando.Parameters.AddWithValue("@IdGrade", idGrade[i]);

                    Conexao.Crud(comando);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public GradeDto GetGrade(int idGrade)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idgrade, descricao, ativo FROM grade WHERE idgrade = @IdGrade";

                comando.Parameters.AddWithValue("@IdGrade", idGrade);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var grade = new GradeDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        grade.Id = (int)dr["idgrade"];
                        grade.Descricao = (string)dr["descricao"];
                        grade.Ativo = (int)dr["ativo"];
                    }
                }
                else
                {
                    grade = null;
                }
                return grade;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public string GetEqualsCategoria(string descricao)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT descricao FROM grade WHERE descricao = @Descricao";

                comando.Parameters.AddWithValue("@Descricao", descricao);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var grade = "";

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        grade = (string)dr["descricao"];
                    }
                }
                else
                {
                    grade = null;
                }
                return grade;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public List<GradeDto> FindAll()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idgrade, descricao, ativo FROM grade WHERE ativo = 0";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaGrade = new List<GradeDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var grade = new GradeDto();

                        grade.Id = (int)dr["idgrade"];
                        grade.Descricao = (string)dr["descricao"];
                        grade.Ativo = (int)dr["ativo"];

                        listaGrade.Add(grade);
                    }
                }
                else
                {
                    listaGrade = null;
                }
                return listaGrade;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }
    }
}
