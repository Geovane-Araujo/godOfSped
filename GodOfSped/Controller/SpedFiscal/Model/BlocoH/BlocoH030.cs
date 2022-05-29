namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoH030
{
    public String REG { get; set; } = "H030";

    public String VL_ICMS_OP { get; set; }

    public String VL_BC_ICMS_ST { get; set; }

    public String VL_ICMS_ST { get; set; }

    public String VL_FCP { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_ICMS_OP}|{VL_BC_ICMS_ST}|{VL_ICMS_ST}|{VL_FCP}|";
        
        return ret;
    }
    
    
    
}