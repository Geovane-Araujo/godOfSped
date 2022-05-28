
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0600
{
    public String REG { get; } = "0600";
    
    public String DT_ALT { get; set; }
    
    public String COD_CCUS { get; set; }
    
    public String CCUS { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{DT_ALT}|{COD_CCUS}|{CCUS}|";
        
        return ret;
    }
}