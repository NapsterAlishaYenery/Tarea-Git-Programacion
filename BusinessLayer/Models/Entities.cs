using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public  class Entities
    {
        public int id { get; set; }
        public string? Descripcion { get; set; }
        public string? Direccion { get; set; }
        public string? Localidad { get; set; }
        public string? TipoEntidad { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Telefonos { get; set; }
        public string? URLPaginaWeb { get; set; }
        public string? URLFacebook { get; set; }
        public string? URLInstagram { get; set; }
        public string? URLTwitter { get; set; }

        public string? URLtiktok { get; set; }
        public string? IdGrupoEntidad { get; set; }
        public string? IdTipoEntidad { get; set; }
        public string? LimiteCredito { get; set; }
        public string? UserNameEntidad { get; set; }
        public string? PasswordEntidad { get; set; }
        public string? Comentario { get; set; }
        public string? RolUserEntidad { get; set; }
        public string? Status1 { get; set; }

        public bool NoEliminable { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
