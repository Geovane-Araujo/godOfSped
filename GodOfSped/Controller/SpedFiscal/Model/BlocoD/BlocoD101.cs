namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD101
{
    public String REG { get; set; } = "D101";
    
    public String VL_FCP_UF_DEST { get; set; }
    
    public String VL_ICMS_UF_DEST { get; set; }
    
    public String VL_ICMS_UF_REM  { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_FCP_UF_DEST}|{VL_ICMS_UF_DEST}|{VL_ICMS_UF_REM}|";
        
        return ret;
    }
}