namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC591
{
    public String REG { get; set; } = "C591";
    
    public String VL_FCP_OP { get; set; }
    
    public String VL_FCP_ST { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_FCP_OP}|{VL_FCP_ST}|";
        
        return ret;
    }
}