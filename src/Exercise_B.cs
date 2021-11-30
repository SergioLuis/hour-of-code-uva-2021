using System;

namespace HourOfCode
{
    // Modifica tu ejemplo anterior de forma que:
    // * El calculo del factorial se haga en un método.
    // * La interacción con el usuario se haga a través de una interfaz IUserInterface.
    // * Implementar la interfaz IUserInterface para acceso a través de la consola.
    public class Factorial2
    {
        public static int Main(string[] args)
        {
            // Aquí va el cuerpo de tu programa. ¡Recuerda lo aprendido, joven aprendiz!
            //           .--.
            // ::\`--._,'.::.`._.--'/::::
            // ::::.  ` __::__ '  .::::::
            // ::::::-:.`'..`'.:-::::::::
            // ::::::::\ `--' /::::::::::

            // Esto no parece correcto...
            IUserInterface userInterface = null;

            return 0;
        }

        static ulong CalculaFactorial(uint number)
        {
            // Espera... esto no puede estar bien!
            return ulong.MinValue;
        }

        interface IUserInterface
        {
            int ReadNumber();
            void ShowText(string text);
        }
        
        // Descomenta estas líneas. El IDE se te debería comenzar a quejar
        // porque los métodos declarados por IUserInterface no están implementados
        // class MiConsole : IUserInterface
        // {
        //     
        // }
    }
}
