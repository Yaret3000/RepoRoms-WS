using RepoRomsWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RepoRomsWS
{
    /// <summary>
    /// Descripción breve de RomsWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class RomsWebService : System.Web.Services.WebService
    {

        RomsContext context = new RomsContext();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        #region Plataforma

        [WebMethod]
        public void AgregarRom(string nombre, string sinopsis, byte[] cover, DateTime fecha, string video, int consolaId)
        {
            var oRom = new Rom()
            {
                nombre = nombre,
                sinopsis = sinopsis,
                cover = cover,
                fecha = fecha,
                video = video,
                consolaId = consolaId
            };

            context.Roms.Add(oRom);
            context.SaveChanges();
        }
        [WebMethod]
        public int EliminarRom(int id)
        {
            var oRom = context.Roms.Find(id);
            context.Roms.Remove(oRom);
            return context.SaveChanges();
        }
        [WebMethod]
        public cRom DetalleRom(int id)
        {
            var oRom = context.Roms.Find(id);
            var ocRom = new cRom
            {
                id = oRom.id,
                nombre = oRom.nombre,
                sinopsis = oRom.sinopsis,
                cover = oRom.cover,
                fecha = oRom.fecha,
                video = oRom.video,
                consolaId = oRom.consolaId
            };

            return ocRom;
        }
        [WebMethod]
        public List<cRom> ListarRoms()
        {
            return context.Roms.Select(x => new cRom
            {
                id = x.id,
                nombre = x.nombre,
                sinopsis = x.sinopsis,
                cover = x.cover,
                fecha = x.fecha,
                video = x.video,
                consolaId = x.consolaId
            }).ToList();
        }
        [WebMethod]
        public List<cConsola> ListarConsola()
        {
            return context.Consolas.Select(x => new cConsola
            {
                id = x.id,
                nombre = x.nombre
            }).ToList();
        }
        #endregion

        #region ClasesPublicas
        public class cRom
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string sinopsis { get; set; }
            public byte[] cover { get; set; }
            public System.DateTime fecha { get; set; }
            public string video { get; set; }
            public int consolaId { get; set; }
        }

        public class cConsola
        {
            public int id { get; set; }
            public string nombre { get; set; }
        }
        #endregion
    }
}
