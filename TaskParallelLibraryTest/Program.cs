// See https://aka.ms/new-console-template for more information
var source = new char[] { 'a', 'b', 'c', 'd', '1', '2', '3' };
System.Threading.Tasks.Parallel.For(0, source.Length, (i,s) => { });
Console.WriteLine("Done");
