namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD360
{
    public String REG { get; set; } = "D360";
    
    public String VL_PIS { get; set; }
    
    public String VL_COFINS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_PIS}|{VL_COFINS}|";
        
        return ret;
    }
}