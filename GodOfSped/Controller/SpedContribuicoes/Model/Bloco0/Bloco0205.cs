
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0205
{
    public String REG { get; } = "0205";
    
    public String DESCR_ANT_ITEM { get; set; }
    
    public String DT_INI { get; set; }
    
    public String DT_FIM { get; set; }
    
    public String COD_ANT_ITEM { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{DESCR_ANT_ITEM}|{DT_INI}|{DT_FIM}|{COD_ANT_ITEM}|";
        
        return ret;
    }
}