namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoG126
{
    public String REG { get; set; } = "G126";

    public String DT_INI { get; set; }

    public String DT_FIM { get; set; }
    
    public String NUM_PARC { get; set; }

    public String VL_PARC_PASS { get; set; }

    public String VL_TRIB_OC { get; set; }

    public String VL_TOTAL { get; set; }

    public String IND_PER_SAI { get; set; }

    public String VL_PARC_APROP { get; set; }

    public String  { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{DT_INI}|{DT_FIM}|{NUM_PARC}|{VL_PARC_PASS}|{VL_TRIB_OC}|{VL_TOTAL}|{IND_PER_SAI}|{VL_PARC_APROP}|";
        
        return ret;
    }
    
    
    
}