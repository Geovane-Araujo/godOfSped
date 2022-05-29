
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF990
{
    public String REG { get; } = "F001";
    
    public String QTD_LIN_F { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_F}|";
        
        return ret;
    }
}