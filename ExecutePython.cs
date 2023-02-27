using System.Reflection;

using IronPython.Hosting;

namespace TinkeringApp;

public static class ExecutePython
{
    public static void ReadPythonData()
    {
        var engine = Python.CreateEngine();
        dynamic scope = engine.CreateScope();
        
        //get this path "C:\Users\mmfazrin\RiderProjects\TinkeringApp\"
        
        var path = Directory.GetCurrentDirectory();
        Console.WriteLine(path);

        engine.ExecuteFile($@"{path}\sample.py", scope);
        // dynamic data = scope.data;
        // Console.WriteLine(data);
    }
}