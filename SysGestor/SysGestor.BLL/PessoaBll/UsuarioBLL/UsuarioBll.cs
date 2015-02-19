using SysGestor.DAL.PessoaDal;
using SysGestor.DAL.PessoaDal.UsuarioDAL;
using SysGestor.DTO.PessoaDto.UsuarioDTO;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SysGestor.BLL.PessoaBll.UsuarioBLL
{
    public class UsuarioBll
    {
        UsuarioDal _usuarioDal;

        public UsuarioBll()
        {
            _usuarioDal = new UsuarioDal();
        }

        public void Inserir(UsuarioDto usuarioDto)
        {
            AssertionConcern.AssertArgumentNotEmpty(usuarioDto.Login, Errors.InvalidEmptyLogin);
            AssertionConcern.AssertArgumentNotEmpty(usuarioDto.Senha, Errors.InvalidEmptyPassword);

            PessoaDal  _pessoaDal = new PessoaDal();

            _pessoaDal.Inserir(usuarioDto);

            int idPessoa = _pessoaDal.GetIdPessoa();

            AssertionConcern.AssertArgumentNotNull(idPessoa, Errors.InvalidId);

            _usuarioDal.Inserir(usuarioDto, idPessoa);
        }

        public void Alterar(UsuarioDto usuarioDto)
        {
            AssertionConcern.AssertArgumentNotNull(usuarioDto.IdUsuario, Errors.InvalidId);
            AssertionConcern.AssertArgumentNotEmpty(usuarioDto.Login, Errors.InvalidEmptyLogin);
            AssertionConcern.AssertArgumentNotEmpty(usuarioDto.Senha, Errors.InvalidEmptyPassword);

            PessoaDal _pessoaDal = new PessoaDal();

            AssertionConcern.AssertArgumentNotNull(usuarioDto.Id, Errors.InvalidId);

            _pessoaDal.Alterar(usuarioDto,usuarioDto.Id);

            _usuarioDal.Alterar(usuarioDto);
        }

        public UsuarioDto GetUsuarioById(int idUsuario)
        {
            AssertionConcern.AssertArgumentNotNull(idUsuario, Errors.InvalidId);

            return _usuarioDal.GetUsuarioById(idUsuario);
        }

        public List<UsuarioDto> FindAll()
        {
            return _usuarioDal.FindAll().ToList();
        }

        public List<UsuarioDto> FindAllFilter(string searchValue, object filter)
        {
            var lista = new List<UsuarioDto>();

            lista = _usuarioDal.FindAll().ToList();

            if (searchValue == "Nome" && filter != "")
                return lista.Where(x => x.Nome.ToUpper().Contains(Convert.ToString(filter).ToUpper())).ToList();

            if (searchValue == "Login" && filter != "")
                return lista.Where(x => x.Login.ToUpper().Contains(Convert.ToString(filter).ToUpper())).ToList();

            return lista;
        }

        public void Remove(int idUsuario)
        {
            AssertionConcern.AssertArgumentNotNull(idUsuario, Errors.InvalidId);

            _usuarioDal.Remove(idUsuario);
        }

        public void RemoveMass(int[] idUsuario)
        {
            AssertionConcern.AssertArgumentNotNull(idUsuario, Errors.InvalidId);

            _usuarioDal.RemoveMass(idUsuario);
        }

        /// <summary>
        /// Criptografia de sentido único, unilateral.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>String criptografada</returns>
        public string GetCriptografiaMD5(string valor)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(valor));
            StringBuilder retorno = new StringBuilder();
            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                retorno.Append(valorCriptografado[i].ToString("x2"));
            }
            return retorno.ToString();
        }

        /// <summary>
        /// Compara as dua senhas digitadas para cadastro se são iguais.
        /// </summary>
        /// <param name="senha1"></param>
        /// <param name="senha2"></param>
        /// <returns>Verdadeiro ou Falso</returns>
        public bool ConfirmaSenha(string senha1, string senha2)
        {
            bool retorno;
            if (senha1 != senha2)
            {
                retorno = false;              
            }
            else
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
