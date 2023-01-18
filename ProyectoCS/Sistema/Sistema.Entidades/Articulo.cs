namespace Sistema.Entidades
{
    public class Articulo
    {
        public int idarticulo { get; set; }
        public int idcategoria { get; set;}
        public string codigo { get; set; }
        public string nombre { get; set; }
        public decimal precioVenta { get; set; }
        public int stock { get; set; }
        public string descripción { get; set; }
        public string imagen { get; set; }
        public bool estado { get; set; }


    }
}
