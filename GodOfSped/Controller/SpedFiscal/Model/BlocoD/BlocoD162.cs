namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD162
{
    public String REG { get; set; } = "D162";

    public String COD_MOD { get; set; }

    public String SER { get; set; }

    public String NUM_DOC{ get; set; }
    
    public String DT_DOC { get; set; }

    public String VL_DOC { get; set; }

    public String VL_MERC { get; set; }

    public String QTD_VOL { get; set; }

    public String PESO_BRT { get; set; }

    public String PESO_LIQ { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{SER}||{NUM_DOC	}|{DT_DOC}|{VL_DOC}|{VL_MERC}|{QTD_VOL}|{PESO_BRT}|{PESO_LIQ}|";
     
        return ret;
    }
}