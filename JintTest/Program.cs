using Jint;
using JintTest;

string scriptPath = "./dist/app.js";
var engine = new Engine();
engine = new Engine();
engine.SetValue("window", typeof(Windows));
engine.SetValue("TextEncoder", typeof(JSEncoder));
engine.SetValue("TextDecoder", typeof(JSDecoder));
engine.SetValue("console.log", new Action<object>(msg => Console.WriteLine($"consol.log => :  {msg}")));

engine.SetValue("log", new Action<object>(msg => Console.WriteLine($"FROM JS => :  {msg}")));
try {
	engine.Execute(File.ReadAllText(scriptPath));
} catch (Exception ex) {
	Console.WriteLine(ex.Message);
}

Console.ReadLine();
