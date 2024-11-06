namespace PlacasSolaresU8_ENT
{
    public class clsCita
    {
        #region Propiedades
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public clsCliente Cliente { get; set; }

      
        #endregion

        #region Constructores
        public clsCita() { }

        public clsCita(int id, string fecha, clsCliente cliente)
        {
            Id = id;
            Fecha = DateTime.Parse(fecha);
            Cliente = cliente;
        }
        #endregion
    }
}