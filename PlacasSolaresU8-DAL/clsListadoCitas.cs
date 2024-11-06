using PlacasSolaresU8_ENT;

namespace PlacasSolaresU8_DAL
    
{
    public class clsListadoCitas
    {
        /// <summary>
        /// Función que obtiene todas las citas disponibles y las devuelve como una lista
        /// </summary>
        /// <returns>Lista de las citas disponibles</returns>
        public static List<clsCita> obtenerCitas()
        {
            return new List<clsCita> {
                new clsCita(9, "07/11/2024 12:30" , new clsCliente(10, "Amaro", "Coria del Rio, 41100", 223456789)),
                new clsCita(11, "08/11/2024 16:30" , new clsCliente(12, "Jenri", "Lepe, 21440", 287654321)),
                new clsCita(13, "09/11/2024 18:30" , new clsCliente(14, "Rubén", "Rota, 11520", 397654321)),
                new clsCita(15, "10/11/2024 10:30" , new clsCliente(16, "Marco", "Dos Hermanas, 41700", 492345678)),


            };
        }

        public static List<clsCita> obtenerCitasNoCompletadas()
        {
            return new List<clsCita> {
                new clsCita(17, "12/10/2024 12:30", new clsCliente(18, "Auri", "Mairena del Aljarafe, 41927", 554321987)),
                new clsCita(19, "11/10/2024 16:30", new clsCliente(20, "Messi", "Chipiona, 11550", 645678912)),
                new clsCita(21, "10/10/2024 18:30", new clsCliente(22, "Lucia", "Paterna del Campo, 21880", 778912345)),
                new clsCita(23, "09/09/2024 12:30", new clsCliente(24, "Cristiano", "Coria del Lago, 98198", 889123456)),


            };
        }



        /// <summary>
        /// Función que obtiene una cita específica por su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve una cita específica</returns>
        public static clsCita obtenerCitaByID(int id)
        {
            List<clsCita> citas = obtenerCitas();
            clsCita cita1 = new clsCita();

            foreach (clsCita cita in citas)
            {
                if (cita.Id == id)
                {
                    cita1 = cita;
                }
            }

            return cita1;
        }


        /// <summary>
        /// Función que obtiene una cita específica por su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve una cita específica</returns>
        public static clsCita obtenerCitaByIDNoCompletadas(int id)
        {
            List<clsCita> citas = obtenerCitasNoCompletadas();
            clsCita cita1 = new clsCita();

            foreach (clsCita cita in citas)
            {
                if (cita.Id == id)
                {
                    cita1 = cita;
                }
            }

            return cita1;
        }
    }
}
