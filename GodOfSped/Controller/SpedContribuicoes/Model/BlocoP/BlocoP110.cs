
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoP110
{
    public String REG { get; } = "P100";
    
    public String NUM_CAMPO { get; set; }
    
    public String COD_DET { get; set; }
    
    public String DET_VALOR { get; set; }
    
    public String INF_COMPL { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_CAMPO}|{COD_DET}|{DET_VALOR}|{INF_COMPL}|";
        
        return ret;
    }
}