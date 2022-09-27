using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {

        public  List<Usuario> LoginUsuario(string usuario, string clave)
        {
            try
            {
                var result = UsuarioDato.LoginUsuario(usuario,clave);
                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Solverix", $"Flujos - gesTbAccion ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }


        }

        public List<Usuario> Usuarios()
        {
            try
            {
                var result = UsuarioDato.Usuarios();
                return result;
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("Solverix", $"Flujos - gesTbAccion ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }


        }

        public int InsertaUsuario(Usuario usuario)
        {
            try
            {
                return new UsuarioDato().InsertaUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public int ActualizaUsuario(Usuario usuario)
        {
            try
            {
                return new UsuarioDato().ActualizaUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int EliminaUsuario(Usuario usuario)
        {
            try
            {
                return new UsuarioDato().EliminaUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
