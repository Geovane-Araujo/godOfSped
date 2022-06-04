namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC791
{
    public String REG { get; set; } = "C791";
    
    public String UF { get; set; }
    
    public String VL_BC_ICMS_ST { get; set; }
    
    public String VL_ICMS_ST { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{UF}|{VL_BC_ICMS_ST}|{VL_ICMS_ST}|";
        
        return ret;
    }
}