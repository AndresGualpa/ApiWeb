using ApiWeb.Seguridad;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWeb.Controllers
{
    public class pruebaController : ApiController
    {
        [HttpGet]
        public OperationResult<List<Usuario>> LoginUsuario(string usuario, string clave)
        {

            try
            {
                var result = new UsuarioNegocio().LoginUsuario(usuario, clave);
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

    }
}
