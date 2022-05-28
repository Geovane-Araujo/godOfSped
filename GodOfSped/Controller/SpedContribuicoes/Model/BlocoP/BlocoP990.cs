
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoP990
{
    public String REG { get; } = "P990";
    
    public String QTD_LIN_P { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_P}|";
        
        return ret;
    }
}