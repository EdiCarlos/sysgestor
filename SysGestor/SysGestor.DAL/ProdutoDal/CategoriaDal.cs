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
    public class CategoriaDal
    {
        public void Inserir(CategoriaDto categoriaDto)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO categoria(descricao) " +
                                      "VALUES (@Descricao)";

                comando.Parameters.AddWithValue("@Descricao", categoriaDto.Descricao);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.InsertDataErrors + " - " + ex.Message);
            }           
        }

        public void Alterar(CategoriaDto categoriaDto) 
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE categoria SET descricao = @Descricao " +
                                      "WHERE idcategoria = @IdCategoria";

                comando.Parameters.AddWithValue("@Descricao", categoriaDto.Descricao);
                comando.Parameters.AddWithValue("@IdCategoria", categoriaDto.Id);

                Conexao.Crud(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.UpdateDataErrors + " - " + ex.Message);
            }
        }

        public void Remove(int idCategoria) 
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE categoria SET ativo = 1 WHERE idcategoria = @IdCategoria";

                comando.Parameters.AddWithValue("@IdCategoria", idCategoria);

                Conexao.Crud(comando);

            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public void RemoveMass(int[] idCategoria) 
        {
            try
            {
                for (int i = 0; i < idCategoria.Length; i++)
                {
                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE categoria SET ativo = 1 WHERE idcategoria = @IdCategoria";

                    comando.Parameters.AddWithValue("@IdCategoria", idCategoria[i]);

                    Conexao.Crud(comando);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.DeleteDataErros + " - " + ex.Message);
            }
        }

        public CategoriaDto GetCategoria(int idCategoria) 
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idcategoria, descricao, ativo FROM categoria WHERE idcategoria = @IdCategoria";

                comando.Parameters.AddWithValue("@IdCategoria", idCategoria);
                
                MySqlDataReader dr = Conexao.Buscar(comando);

                var categoria = new CategoriaDto();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        categoria.Id = (int)dr["idcategoria"];
                        categoria.Descricao = (string)dr["descricao"];                       
                        categoria.Ativo = (int)dr["ativo"];                      
                    }
                }
                else
                {
                    categoria = null;
                }
                return categoria;
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
                comando.CommandText = "SELECT descricao FROM categoria WHERE descricao = @Descricao";

                comando.Parameters.AddWithValue("@Descricao", descricao);

                MySqlDataReader dr = Conexao.Buscar(comando);

                var categoria = "";

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        categoria = (string)dr["descricao"];
                    }
                }
                else
                {
                    categoria = null;
                }
                return categoria;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }

        public IList<CategoriaDto> FindAll() 
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT idcategoria, descricao, ativo FROM categoria WHERE ativo = 0";

                MySqlDataReader dr = Conexao.Buscar(comando);

                var listaCategoria = new List<CategoriaDto>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var categoria = new CategoriaDto();

                        categoria.Id = (int)dr["idcategoria"];
                        categoria.Descricao = (string)dr["descricao"];
                        categoria.Ativo = (int)dr["ativo"];        

                        listaCategoria.Add(categoria);
                    }
                }
                else
                {
                    listaCategoria = null;
                }
                return listaCategoria;
            }
            catch (Exception ex)
            {
                throw new Exception(Errors.SelectDataErrors + " - " + ex.Message);
            }
        }
    }
}
