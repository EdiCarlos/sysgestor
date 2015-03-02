using SysGestor.BLL.PessoaBll.UsuarioBLL;
using SysGestor.DAL.AuthenticationDAL;
using SysGestor.DTO.AuthenticationDTO;
using SysGestor.RESOURCE.Resources;
using SysGestor.RESOURCE.Validation;

namespace SysGestor.BLL.AuthenticationBLL
{
    public class AuthenticationBll
    {
        AuthenticationDal _authenticationDal;
        UsuarioBll _usuarioBll;

        public AuthenticationBll()
        {
            _authenticationDal = new AuthenticationDal();
            _usuarioBll = new UsuarioBll();
        }
        public void GetByUsuario(string usuario)
        {
            AssertionConcern.AssertArgumentNotEmpty(usuario, Errors.EmptyUser);

            _authenticationDal.GetByUsuario(usuario);
        }

        public bool Authentication(string usuario, string senha)
        {
            AssertionConcern.AssertArgumentNotEmpty(usuario, Errors.EmptyUser);
            AssertionConcern.AssertArgumentNotEmpty(senha, Errors.EmptyPassword);

            string senhaCifrada = _usuarioBll.GetCriptografiaMD5(senha);

            _authenticationDal.Authentication(usuario, senhaCifrada);

            if (AuthenticationDto.Autenticado) return true;
            else return false;
        }

        public void Logout()
        {
            AuthenticationDto.Id = 0;
            AuthenticationDto.Usuario = null;
            AuthenticationDto.Autenticado = false;
        }
    }
}
