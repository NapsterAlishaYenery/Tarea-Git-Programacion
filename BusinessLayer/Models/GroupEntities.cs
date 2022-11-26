using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class GroupEntities
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public string Comentary { get; set; } = "";
        public string Status { get; set; } = "";
        public bool noEliminable { get; set; }
        public DateTime Date { get; set; }

    }
}
