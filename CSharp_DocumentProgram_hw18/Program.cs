using CSharp_DocumentProgram_hw18.Models;

Console.WriteLine("Welcome!");

Console.WriteLine("Enter an keyword (basic, pro or expert)");
string keyword=Console.ReadLine();
if (keyword == "basic")
{
    DocumentProgram docProgram = new DocumentProgram();
    docProgram.OpenDocument();
    docProgram.EditDocument();
    docProgram.SaveDocument();
}
else if (keyword == "pro")
{
    DocumentProgram docProgram = new ProDocumentProgram(); 
    docProgram.OpenDocument();
    docProgram.EditDocument();
    docProgram.SaveDocument();
}
else if (keyword == "expert")
{
    DocumentProgram docProgram = new ExpertDocumentProgram(); 
    docProgram.OpenDocument();
    docProgram.EditDocument();
    docProgram.SaveDocument();
}
else
{
    Console.WriteLine("Wrong keyword");
}
