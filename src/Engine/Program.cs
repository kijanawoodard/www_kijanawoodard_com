// See https://aka.ms/new-console-template for more information
var path = args[0];
var filename = Path.Combine(path, "index.html");
Console.WriteLine($"Hello, World!\n\n{filename}");
Directory.CreateDirectory(path);
File.WriteAllText(filename, "Hello World!");
