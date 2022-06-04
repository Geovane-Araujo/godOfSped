namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoG110
{
    public String REG { get; set; } = "G110";

    public String DT_INI { get; set; }

    public String DT_FIN { get; set; }
    
    public String SALDO_IN_ICMS { get; set; }

    public String SOM_PARC { get; set; }

    public String VL_TOTAL { get; set; }

    public String IND_PER_SAI { get; set; }

    public String ICMS_APROP { get; set; }

    public String SOM_ICMS_OC { get; set; }
    
    public String VL_TRIB_EXP { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_INI}|{DT_FIN}|{SALDO_IN_ICMS}|{SOM_PARC}|{VL_TOTAL}|{IND_PER_SAI}|{ICMS_APROP}|{SOM_ICMS_OC}|{VL_TRIB_EXP}|";
        
        return ret;
    }
    
    
    
}