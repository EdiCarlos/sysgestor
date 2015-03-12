using System;
using SysGestor.DAL.ProdutoDal;
using SysGestor.DTO.Produto;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System.Collections.Generic;
using System.Linq;

namespace SysGestor.BLL.ProdutoBLL
{
    public class ProdutoBll
    {
        ProdutoDal _produtoDal;
        ProdutoDto _produtoDto;

        public ProdutoBll()
        {
            _produtoDal = new ProdutoDal();
            _produtoDto = new ProdutoDto();
        }

        public void Inserir(ProdutoDto produtoDto)
        {
            AssertionConcern.AssertArgumentNotNull(produtoDto.IdInterno, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotEmpty(produtoDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotNull(produtoDto.CategoriaDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(produtoDto.UnidadeDto.IdUnidMedida, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotEquals(produtoDto.Descricao,
                                                 GetEqualsProduto(produtoDto.Descricao),
                                                 Errors.EqualsValue);

            _produtoDal.Inserir(produtoDto);
        }

        public void Alterar(ProdutoDto produtoDto)
        {
            AssertionConcern.AssertArgumentNotNull(produtoDto.IdInterno, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotEmpty(produtoDto.Descricao, Errors.EmptyDescription);
            AssertionConcern.AssertArgumentNotNull(produtoDto.CategoriaDto.Id, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(produtoDto.UnidadeDto.IdUnidMedida, Errors.InvalidValue);
          
            _produtoDal.Alterar(produtoDto);
        }

        public void Remove(int idProduto)
        {
            AssertionConcern.AssertArgumentNotNull(idProduto, Errors.InvalidId);

            _produtoDal.Remove(idProduto);
        }

        public void RemoveMass(int[] idProduto)
        {
            AssertionConcern.AssertArgumentNotNull(idProduto, Errors.InvalidId);

            _produtoDal.RemoveMass(idProduto);
        }

        public ProdutoDto GetProdutoById(int idProduto)
        {
            AssertionConcern.AssertArgumentNotNull(idProduto, Errors.InvalidId);

            return _produtoDal.GetProdutoById(idProduto);
        }

        public ProdutoDto GetProdutoByIdInterno(string idInterno)
        {
            AssertionConcern.AssertArgumentNotNull(idInterno, Errors.InvalidId);

            return _produtoDal.GetProdutoByIdInterno(idInterno);
        }

        public ProdutoDto GetProdutoByDescricao(string descricao)
        {
            AssertionConcern.AssertArgumentNotEmpty(descricao, Errors.EmptyDescription);

            return _produtoDal.GetProdutoByDescricao(descricao);
        }

        public int GetIdProduto()
        {
            return _produtoDal.GetIdProduto();
        }

        public string GetEqualsProduto(string descricao)
        {
            return _produtoDal.GetEqualsProduto(descricao);
        }

        public List<ProdutoDto> FindAll()
        {
            var lista = new List<ProdutoDto>();

            lista = null;

            lista = _produtoDal.FindAll().ToList();

            if (lista != null) return lista;
            else return null;
        }

        public int GetIdListaProduto(string produto)
        {
            int id = 0;

            if (!string.IsNullOrEmpty(produto))
            {
                var listaProduto = new List<ProdutoDto>();

                listaProduto = FindAll();

                if (listaProduto != null)
                {
                    var p = from x in listaProduto where x.Descricao == produto select x.Id; //consulta linq

                    id = p.FirstOrDefault();
                }
            }
            return id;
        }

        public string GetIdListaCodigoInterno(string produto)
        {
            string idInterno = string.Empty;

            if (!string.IsNullOrEmpty(produto))
            {
                var listaProduto = new List<ProdutoDto>();

                listaProduto = FindAll();

                if (listaProduto != null)
                {
                    var p = from x in listaProduto where x.Descricao == produto select x.IdInterno; //consulta linq

                    idInterno = p.FirstOrDefault();
                }
            }
            return idInterno;
        }

        public List<ProdutoDto> FindAllByDescricaoCategoriaIdInterno(string searchType, object filter)
        {
            AssertionConcern.AssertArgumentNotEmpty(searchType, Errors.InvalidFilter);
            AssertionConcern.AssertArgumentNotNull(filter, Errors.InvalidValue);

            var lista = new List<ProdutoDto>();

            //lista = _produtoDal.FindAllByDescricaoCategoriaIdInterno();

            //if (lista != null)
            //{
            //    if (searchType == "Descricao" && filter != "")
            //        lista = lista.Where(x => x.Descricao.ToUpper().Contains(Convert.ToString(filter).ToUpper())).ToList();

            //    if (searchType == "Categoria" && filter != "")
            //        lista = lista.Where(x => x.Categoria.ToUpper().Contains(Convert.ToString(filter).ToUpper())).ToList();

            //    if (searchType == "IdInterno" && filter != "")
            //        lista = lista.Where(x => x.IdInterno.ToUpper().Contains(Convert.ToString(filter).ToUpper())).ToList();

            //    if (searchType == "Id" && filter != "")
            //        lista = lista.Where(x => x.Id == (Convert.ToInt32(filter))).ToList();
            //}


            lista = _produtoDal.FindAllByDescricaoCategoriaIdInterno(searchType,filter);


            return lista;
        }

        public double CalculaMargemLucro(double valorCompra, double margem)
        {
            double valorVenda = 0;

            AssertionConcern.AssertArgumentNotNull(valorCompra, Errors.InvalidValue);
            AssertionConcern.AssertArgumentNotNull(margem, Errors.InvalidValue);

            valorVenda = valorCompra + (valorCompra * (margem / 100));

            return valorVenda;
        }       

        public void AumentaEstoque(decimal qtdAumentada , int idProduto)
        {
            decimal qtdEstoque;

           qtdEstoque = _produtoDal.GetEstoqueByIdProduto(idProduto);

           if (qtdAumentada < 0)
               throw new Exception("Quantidade não pode ser menor que 0.");

           if (idProduto == 0 || idProduto == null)
               throw new Exception("Produto não cadastrado.");

           qtdEstoque += qtdAumentada;

           _produtoDal.AlteraEstoque(qtdEstoque, idProduto);
        }

        public void BaixaEstoque(decimal qtdBaixa, int idProduto)
        {
            decimal qtdEstoque = 0;

            qtdEstoque = _produtoDal.GetEstoqueByIdProduto(idProduto);

            if (qtdEstoque <= 0 || qtdEstoque < qtdBaixa) 
                throw new Exception("Quantidade no estoque menor que a quantidade a baixar.");

            if (idProduto == 0 || idProduto == null)
                throw new Exception("Produto não cadastrado.");

            qtdEstoque -= qtdBaixa;

            _produtoDal.AlteraEstoque(qtdEstoque, idProduto);
        }

        public string VerificaCodigoInternoCadastrado()
        {
            return _produtoDal.VerificaCodigoInternoCadastrado();
        }
    }
}
