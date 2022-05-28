using System.Data.SqlTypes;

namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0035
{
    public String REG { get; } = "0035";
    
    public String COD_SCP { get; set; }
    
    public String DESC_SCP { get; set; }
    
    public String INF_COMP { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_SCP}|{DESC_SCP}|{INF_COMP}|";
        
        return ret;
    }
}