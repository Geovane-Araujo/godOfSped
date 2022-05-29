
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM605
{
    public String REG { get; } = "M605";
    
    public String NUM_CAMPO { get; set; } = "";
    
    public String COD_REC { get; set; } = "";
    
    public String VL_DEBITO { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_CAMPO}|{COD_REC}|{VL_DEBITO}|";
        
        return ret;
    }
}