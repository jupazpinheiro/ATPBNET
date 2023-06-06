using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyRegister.Models;

namespace MyRegister.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //string fileName = @"C:\Users\julia\OneDrive\Área de Trabalho\SemFake\SemFakeAT\SemFakeAT\ML.py";

            //Process p = new Process();
            //p.StartInfo = new ProcessStartInfo(@"C:\Users\julia\OneDrive\Área de Trabalho\SemFake\SemFakeAT\SemFakeAT\venv\Scripts\python.exe", fileName)
            //{
            //    RedirectStandardOutput = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = true
            //};
            //p.Start();

            //string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();

            //Console.WriteLine(output);

            //Console.ReadLine();

            //string venvActivatePath = "C:\\Users\\julia\\OneDrive\\Área de Trabalho\\SemFake\\SemFakeAT\\SemFakeAT\\venv\\Scripts\\activate.bat";
            //string scriptPath = "C:\\Users\\julia\\OneDrive\\Área de Trabalho\\SemFake\\SemFakeAT\\SemFakeAT\\ML.py";
            //string command = $"{venvActivatePath} && streamlit run {scriptPath}";

            //ProcessStartInfo startInfo = new ProcessStartInfo
            //{
            //    FileName = "cmd.exe",
            //    Arguments = "/C " + command,
            //    RedirectStandardOutput = false,
            //    UseShellExecute = true,
            //    CreateNoWindow = false
            //};

            //using (Process process = new Process())
            //{
            //    process.StartInfo = startInfo;
            //    process.Start();
            //    Console.ReadLine();

            //    // Read the output of the Python script
            //    //string output = process.StandardOutput.ReadToEnd();

            //    process.WaitForExit();

            //    Console.WriteLine(/*output*/);
            //}
            //ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = "C:\\Users\\julia\\OneDrive\\Área de Trabalho\\SemFake\\SemFakeAT\\SemFakeAT\\venv\\Scripts\\python.exe";
            //start.Arguments = "/C " + command;
            //start.UseShellExecute = false;
            //start.RedirectStandardOutput = true;
            //using (Process process = Process.Start(start))
            //{
            //    using (StreamReader reader = process.StandardOutput)
            //    {
            //        string result = reader.ReadToEnd();
            //        Console.Write(result);
            //    }
            //}
















            //string command = "streamlit run ..\\..\\SemFakeAT\\ML.py"; // Replace with your specific command

            //ProcessStartInfo startInfo = new ProcessStartInfo
            //{
            //    FileName = "cmd.exe",
            //    Arguments = "/C " + command,
            //    RedirectStandardOutput = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = false
            //};

            //using (Process process = new Process())
            //{
            //    process.StartInfo = startInfo;
            //    process.Start();

            //    // Read the output of the Python script
            //    string output = process.StandardOutput.ReadToEnd();

            //    process.WaitForExit();

            //    Console.WriteLine(output);
            //}


            // Create an instance of the IronPython engine
            //var engine = Python.CreateEngine();

            //// Create a scope to execute the Python script in
            //var scope = engine.CreateScope();

            //// Execute the Python script file
            //var scriptSource = engine.CreateScriptSourceFromFile("..\\..\\SemFakeAT\\ML.py");
            //scriptSource.Execute(scope);

            //// Get a reference to the 'prediction' function from the script
            //dynamic predictionFunction = scope.GetVariable("prediction");

            //// Call the 'prediction' function
            //string inputText = "Lula";
            //dynamic result = predictionFunction(inputText);
            //..\..\SemFakeAT\ML.py


            //string pythonScriptPath = @"..\..\SemFakeAT\ML.py";
            //string pythonInterpreterPath = @"C:\path\to\python\interpreter\python.exe";

            //// Cria um processo de execução para o interpretador Python
            //ProcessStartInfo psi = new ProcessStartInfo();
            //psi.FileName = pythonInterpreterPath;
            //psi.Arguments = pythonScriptPath;
            //psi.UseShellExecute = false;
            //psi.RedirectStandardOutput = true;

            //// Inicia o processo
            //Process process = new Process();
            //process.StartInfo = psi;
            //process.Start();

            //// Lê a saída do script Python
            //StreamReader reader = process.StandardOutput;
            //string output = reader.ReadToEnd();

            //// Aguarda a conclusão do processo
            //process.WaitForExit();

            //ViewBag.Output = output;

            return View();
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
