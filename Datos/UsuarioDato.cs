using Dapper;
using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDato
    {
        public static string connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString; }
        }

        public static  List<Usuario> LoginUsuario(string usuario, string clave)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@usuario", usuario);
                    parameters.Add("@clave", clave);

                    var result = db.Query<Usuario>("sp_login", parameters,
                    commandType: CommandType.StoredProcedure).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("ZEUZ", $"Flujos - LoginUsuario ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }


        public static List<Usuario> Usuarios()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                   
                    var result = db.Query<Usuario>("sp_Usuarios", 
                    commandType: CommandType.StoredProcedure).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("ZEUZ", $"Flujos - LoginUsuario ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }

        public int InsertaUsuario(Usuario usuario)
        {

            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();

                    parameters.Add("@usr_cod", usuario.usr_cod);
                    parameters.Add("@usr_nom", usuario.usr_nom);
                    parameters.Add("@usr_est", usuario.usr_est);
                    parameters.Add("@usr_treg", usuario.usr_treg);
                    parameters.Add("@usr_clv", usuario.usr_clv);
                    parameters.Add("@usr_tacc", usuario.usr_tacc);
                    parameters.Add("@grp_cod", usuario.grp_cod);
                    parameters.Add("@usr_aud", usuario.usr_aud);
                    parameters.Add("@usr_fec_ult", usuario.usr_fec_ult);
                    parameters.Add("@usr_vig_clv", usuario.usr_vig_clv);
                    parameters.Add("@usr_dom", usuario.usr_dom);

                    var result = db.Query<int>("sp_InsertaUsuario", parameters, commandType: CommandType.StoredProcedure);


                    return 1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("SOLVERIX - FLUJO", $" gesTbFlujo  ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }



        public int ActualizaUsuario(Usuario usuario)
        {

            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();

                    parameters.Add("@usr_cod", usuario.usr_cod);
                    parameters.Add("@usr_nom", usuario.usr_nom);
                    parameters.Add("@usr_est", usuario.usr_est);
                    parameters.Add("@usr_treg", usuario.usr_treg);
                    parameters.Add("@usr_clv", usuario.usr_clv);
                    parameters.Add("@usr_tacc", usuario.usr_tacc);
                    parameters.Add("@grp_cod", usuario.grp_cod);
                    parameters.Add("@usr_aud", usuario.usr_aud);
                    parameters.Add("@usr_fec_ult", usuario.usr_fec_ult);
                    parameters.Add("@usr_vig_clv", usuario.usr_vig_clv);
                    parameters.Add("@usr_dom", usuario.usr_dom);

                    var result = db.Query<int>("sp_ActualizaUsuario", parameters, commandType: CommandType.StoredProcedure);


                    return 1;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("SOLVERIX - FLUJO", $" gesTbFlujo  ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }
        }

        public int EliminaUsuario(Usuario usuario)
        {
            try
            {
                using (IDbConnection db = new SqlConnection (connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@usr_cod", usuario.usr_cod);
                    parameters.Add("@usr_nom", usuario.usr_nom);
                    parameters.Add("@usr_est", usuario.usr_est);
                    parameters.Add("@usr_treg", usuario.usr_treg);
                    parameters.Add("@usr_clv", usuario.usr_clv);
                    parameters.Add("@usr_tacc", usuario.usr_tacc);
                    parameters.Add("@grp_cod", usuario.grp_cod);
                    parameters.Add("@usr_aud", usuario.usr_aud);
                    parameters.Add("@usr_fec_ult", usuario.usr_fec_ult);
                    parameters.Add("@usr_vig_clv", usuario.usr_vig_clv);
                    parameters.Add("@usr_dom", usuario.usr_dom);

                    var result = db.Query<int>("sp_InactivaUsuario", parameters, commandType: CommandType.StoredProcedure);


                    return 1;
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.EventLog.WriteEntry("SOLVERIX - FLUJO", $" gesTbFlujo  ==> ERROR: {ex.Message} - STACKTRACE: {ex.StackTrace} - INNEREXCEPTION: {ex.InnerException}", System.Diagnostics.EventLogEntryType.Error);
                throw;
            }

        }


    }
}
