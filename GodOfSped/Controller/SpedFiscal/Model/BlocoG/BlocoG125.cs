namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoG125
{
    public String REG { get; set; } = "G125";

    public String COD_IND_BEM { get; set; }

    public String DT_MOV { get; set; }
    
    public String TIPO_MOV { get; set; }

    public String VL_IMOB_ICMS_OP { get; set; }

    public String VL_IMOB_ICMS_ST { get; set; }

    public String VL_IMOB_ICMS_FRT { get; set; }

    public String VL_IMOB_ICMS_DIF { get; set; }

    public String NUM_PARC { get; set; }
    
    public String VL_PARC_PASS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_IND_BEM}|{DT_MOV}|{TIPO_MOV}|{VL_IMOB_ICMS_OP}|{VL_IMOB_ICMS_ST}|{VL_IMOB_ICMS_FRT}|{VL_IMOB_ICMS_DIF}|{NUM_PARC}|{VL_PARC_PASS}|";
        
        return ret;
    }
    
    
    
}