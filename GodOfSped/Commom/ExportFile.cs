using System.Security.Cryptography;

namespace GodOfSped.Commom;

public class ExportFile
{
    public static void GenerateFile(List<String> exp)
    {
        using (StreamWriter writer = new StreamWriter(@"C:\Workspace\godOfSped\godOfSped\GodOfSped\Exported\sped.txt", true))
        {
            exp.ForEach(item =>
            {
                writer.WriteLine(item);
            });
        }
    }
}