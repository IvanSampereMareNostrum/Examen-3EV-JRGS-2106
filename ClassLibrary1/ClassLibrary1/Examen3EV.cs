using System.Collections.Generic;

namespace Examen3EV_NS
{
    public class estNotISQ2021  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        private int suspenso;  // Suspensos
        private int aprobados;  // Aprobados
        private int notable;  // Notables
        private int sobresaliente;  // Sobresalientes

        private double media; // Nota media

        // Getters y Setters
        public int Suspenso { get => suspenso; set => suspenso = value; }

        public int Aprobados { get => aprobados; set => aprobados = value; }
        public int Notable { get => notable; set => notable = value; }
        public int Sobresaliente { get => sobresaliente; set => sobresaliente = value; }

        public double Media { get => media; set => media = value; }

        // Constructor vacío
        public estNotISQ2021()
        {
            // inicializamos las variables
            this.suspenso = 0;
            this.aprobados = 0;
            this.notable = 0;
            this.sobresaliente = 0;
            this.media = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        public estNotISQ2021(List<int> listnot)
        {
            this.media = 0.0;

            RealizarMedia(listnot);

        }


        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario	
        public double CalcEst(List<int> listnot)
        {
            this.media = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listnot.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
                return -1;

            for (int i = 0; i < 10; i++)
                if (listnot[i] < 0 || listnot[i] > 10)      // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                    return -1;

            return RealizarMedia(listnot);
        }

        // Función para aumentar al contador de suspensos, aprobados, notable y sobresaliente según las notas.
        public double RealizarMedia(List<int> listnot)
        {

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) this.suspenso++;              // Por debajo de 5 suspenso
                else if (listnot[i] >= 5 && listnot[i] < 7) this.aprobados++;// Nota para aprobar: 5
                else if (listnot[i] >= 7 && listnot[i] < 9) this.notable++;// Nota para notable: 7
                else if (listnot[i] > 9) this.sobresaliente++;         // Nota para sobresaliente: 9

                this.media = this.media + listnot[i];
            }

            return this.media = this.media / listnot.Count;

        }
    }
}
