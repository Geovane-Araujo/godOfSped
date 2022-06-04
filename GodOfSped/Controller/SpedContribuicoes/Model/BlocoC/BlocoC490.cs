
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC490
{
    public String REG { get; } = "C490";
    
    public String DT_DOC_INI { get; set; } = "";
    
    public String DT_DOC_FIN { get; set; } = "";
    
    public String COD_MOD { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{DT_DOC_INI}|{DT_DOC_FIN}|{COD_MOD}|";
        
        return ret;
    }
}