namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE520
{
    public String REG { get; set; } = "E520";

    public String VL_SD_ANT_IPI { get; set; }

    public String VL_DEB_IPI { get; set; }

    public String VL_CRED_IPI { get; set; }

    public String VL_OD_IPI { get; set; }

    public String VL_OC_IPI { get; set; } 

    public String VL_SC_IPI { get; set; }

    public String VL_SD_IPI { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_SD_ANT_IPI}|{VL_DEB_IPI}|{VL_CRED_IPI}|{VL_OD_IPI}|{VL_OC_IPI}|{VL_SC_IPI}|{VL_SD_IPI}|";
        
        return ret;
    }
    
}