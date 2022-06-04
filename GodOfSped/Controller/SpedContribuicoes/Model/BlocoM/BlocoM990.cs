
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM990
{
    public String REG { get; } = "M990";
    
    public String QTD_LIN_M { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_M}|";
        
        return ret;
    }
}