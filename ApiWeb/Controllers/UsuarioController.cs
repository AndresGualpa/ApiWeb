using Entidades;
using System.Web.Http;
using Entidades;
using Negocio;
using System.Collections.Generic;
using ApiWeb.Seguridad;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Http.Cors;

namespace ApiWeb.Controllers
{
    public class UsuarioController : ApiController
    {
        //habalita el origen cabecera y methodos que seran consumidos por las peticiones

        [EnableCors(origins:"*",headers:"*", methods:"GET,POST,PUT,PATCH,DELETE,OPTIONS")]
        
        [HttpGet]
        public OperationResult<List<Usuario>> LoginUsuario(string usuario, string clave)
        {

            try
            {
                var result = new UsuarioNegocio().LoginUsuario(usuario,clave);
                if (result.Count() > 0)
                    return OperationResult<List<Usuario>>.CreateSuccessResult(result);
                else
                    return OperationResult<List<Usuario>>.CreateFailure();
            }
            catch (System.Exception ex)
            {
                return OperationResult<List<Usuario>>.CreateFailure(ex);
            }


        }

        [HttpGet]
        public OperationResult<List<Usuario>> Usuarios()
        {

            try
            {
                var result = new UsuarioNegocio().Usuarios();
                if (result.Count() > 0)
                    return OperationResult<List<Usuario>>.CreateSuccessResult(result);
                else
                    return OperationResult<List<Usuario>>.CreateFailure();
            }
            catch (System.Exception ex)
            {
                return OperationResult<List<Usuario>>.CreateFailure(ex);
            }


        }

        //insercion de usuarios

        [HttpPost]
        public OperationResult<int> InsertaUsuario(Usuario usuario)
        {
            try
            {
                var result = new UsuarioNegocio().InsertaUsuario(usuario);
                if (result == 1)
                {
                    return OperationResult<int>.CreateSuccessResult(result);
                }
                else
                {
                    return OperationResult<int>.CreateFailure("Ocurrió un error al crear su Usuario");
                }
            }
            catch (System.Exception ex)
            {
                return OperationResult<int>.CreateFailure(ex);
            }
        }


        [HttpPut]
        public OperationResult<int> ActualizaUsuario(Usuario usuario)
        {
            try
            {
                var result = new UsuarioNegocio().ActualizaUsuario(usuario);
                if (result == 1)
                {
                    return OperationResult<int>.CreateSuccessResult(result);
                }
                else
                {
                    return OperationResult<int>.CreateFailure("Ocurrió un error al Actualizar su Usuario");
                }
            }
            catch (System.Exception ex)
            {
                return OperationResult<int>.CreateFailure(ex);
            }
        }

        [HttpDelete]
        public OperationResult<int> EliminaUsuario (Usuario usuario)
        {
            try
            {
                var result = new UsuarioNegocio().EliminaUsuario(usuario);
                if (result == 1)
                {
                    return OperationResult<int>.CreateSuccessResult(result);
                }
                else
                {
                    return OperationResult<int>.CreateFailure("Ocurrió un error al Eliminar su Usuario");
                }
            }
            catch (System.Exception ex)
            {
                return OperationResult<int>.CreateFailure(ex);
            }
        }

    }
}
