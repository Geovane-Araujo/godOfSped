
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD990
{
    public String REG { get; } = "D990";
    
    public String QTD_LIN_D { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_D}|";
        
        return ret;
    }
}