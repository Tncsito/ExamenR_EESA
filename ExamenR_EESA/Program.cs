namespace ExamenR_EESA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datos.Datos datos = new Datos.Datos();
            //######## EJERCICIO CURP ##################################
            datos.Fcurp();
            //##########################################################
            
            //######## EJERCICIO INTERVALO #############################
            /*
            Console.WriteLine("Vamos a sacar un intervalo, desde los numeros que tu proporciones!");
            Console.WriteLine("Dame un numero: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame otro numero: ");
            int fin = Convert.ToInt32(Console.ReadLine());
            datos.Intervalo(inicio, fin);*/
            //#########################################################

            //######## EJERCICIO TABLA DE MULTIPLICAR #################
            /*Console.WriteLine("Dame un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            datos.Tabla(numero);
            */
            //#########################################################
        }
    }
}