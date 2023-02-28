using CS6;
using static System.Console;

// See https://aka.ms/new-console-template for more information

WriteLine("C# 6");

WriteLine("Static import");
CS6.StaticImport.Test();


WriteLine("Exception filtering");
var result = CS6.ExceptionFiltering.Test("http://noaddress.cz").Result;

WriteLine("Autoproperty initializer");
CS6.AutopropertyInitializer.Test();

ReadLine();




