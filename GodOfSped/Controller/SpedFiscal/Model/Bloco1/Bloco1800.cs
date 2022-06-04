namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1800
{
    public String REG { get; set; } = "1800";

    public String VL_CARGA { get; set; }

    public String VL_PASS { get; set; }

    public String VL_FAT { get; set; }

    public String IND_RAT { get; set; }

    public String VL_ICMS_ANT { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS_APUR { get; set; }

    public String VL_BC_ICMS_APUR { get; set; }

    public String VL_DIF { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_FAT}|{IND_RAT}|{VL_CARGA}|{VL_PASS}|{VL_ICMS_ANT}|{VL_BC_ICMS}|{VL_ICMS_APUR}|{VL_BC_ICMS_APUR}|{VL_DIF}|";
        
        return ret;
    }

    
}