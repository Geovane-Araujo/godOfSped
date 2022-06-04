namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD697
{
    public String REG { get; set; } = "D697";
    
    public String UF { get; set; }
    
    public String VL_BC_ICMS { get; set; }
    
    public String VL_ICMS  { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{UF}|{VL_BC_ICMS}|{VL_ICMS}|";
        
        return ret;
    }
}