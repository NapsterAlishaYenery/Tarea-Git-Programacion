namespace BusinessLayer
{
    public class TypesIdentities
    {

        public int Id { get; set; }

        public string Description { get; set; } = "";

        public string IdGrupoEntidad { get; set; } = "";

        public string Comentary { get; set; } = "";

        public string Status { get; set; } = "";

        public bool NoEliminable { get; set; }

        public DateTime Date { get; set; }

    }
}