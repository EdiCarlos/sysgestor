using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.ProdutoDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.ProdutoBll
{
    public class CategoriaBll
    {
        CategoriaDal _categoriaDal;

        public CategoriaBll()
        {
            _categoriaDal = new CategoriaDal();
        }

        public void Inserir(CategoriaDto categoriaDto)
        {
            if (String.IsNullOrEmpty(categoriaDto.Descricao))
            {
                throw new Exception("Descrição não pode ser vazio.");
                return;
            }

            _categoriaDal.Inserir(categoriaDto);
        }

        public void Alterar(CategoriaDto categoriaDto)
        {
            if (String.IsNullOrEmpty(categoriaDto.Descricao))
            {
                throw new Exception("Descrição não pode ser vazio.");
                return;
            }

            _categoriaDal.Alterar(categoriaDto);
        }

        public void Remove(int idCategoria)
        {
            if (idCategoria == null || idCategoria == 0)
            {
                throw new Exception("Erro ao excluir categoria. Id não informado");
                return;
            }

            _categoriaDal.Remove(idCategoria);
        }

        public void RemoveMass(int[] idCategoria)
        {
            if (idCategoria == null)
            {
                throw new Exception("Erro ao excluir categoria. Id(s) não informado");
                return;
            }

            _categoriaDal.RemoveMass(idCategoria);
        }

        public CategoriaDto GetCategoria(int idCategoria)
        {
            if (idCategoria == null)
            {
                throw new Exception("Erro ao buscar categoria. Id não informado");
            }

            return _categoriaDal.GetCategoria(idCategoria);
        }

        public IList<CategoriaDto> FindAll()
        {
            return _categoriaDal.FindAll().ToList();
        }
    }
}
