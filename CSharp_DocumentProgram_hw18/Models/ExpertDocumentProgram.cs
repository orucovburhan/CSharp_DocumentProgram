namespace CSharp_DocumentProgram_hw18.Models;

public class ExpertDocumentProgram:ProDocumentProgram
{
    public void OpenDocument()=>Console.WriteLine("Document Opened");
    public void EditDocument()=>Console.WriteLine("Document Edited");
    public override void SaveDocument()=>Console.WriteLine("Document Saved in pdf format");
    
}