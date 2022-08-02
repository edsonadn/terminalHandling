using System.Diagnostics;
namespace principal
{
    // See https://aka.ms/new-console-template for more information

    class persona : humano,humanod
    {
        private string nombre;
        public persona(string nombre)
        {
            this.nombre = nombre;
        }
        public string imprimirNombre()
        {
            return nombre;
        }
        public string apellido(){
            return "dimas";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
       
            

         
            /*startInfo.FileName = "ls";
            startInfo.Arguments = "-a";
            Process.Start(startInfo);*/
            Process obj = ejecutarGoogle();
            Console.ReadLine();
            Console.WriteLine(obj.MachineName);
        }
        static Process ejecutarGoogle(){
            string url = "\"https://www.google.com/search?q=ejecutar+chrome+en+linux&oq=ejecutar+chrome+en+l&aqs=chrome.0.0i512j69i57j0i22i30l3.7977j1j7&sourceid=chrome&ie=UTF-8\" --new-window";
            Process newProcess = new Process();

            newProcess.StartInfo.Verb = "print";
            newProcess.StartInfo.FileName = "google-chrome";
            newProcess.StartInfo.Arguments = url;
            newProcess.StartInfo.CreateNoWindow = false;

            newProcess.Start();
            return newProcess;
        } 

    }
}