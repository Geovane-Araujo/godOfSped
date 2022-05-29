namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1510
{
    public String REG { get; set; } = "1510";

    public String NUM_ITEM { get; set; }

    public String COD_ITEM { get; set; }

    public String COD_CLASS { get; set; }

    public String QTD { get; set; }

    public String UNID { get; set; }

    public String VL_ITEM { get; set; }

    public String VL_DESC { get; set; }

    public String CST_ICMS { get; set; }

    public String CFOP { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String ALIQ_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String VL_BC_ICMS_ST { get; set; }

    public String ALIQ_ST { get; set; } 

    public String VL_ICMS_ST { get; set; }

    public String IND_REC { get; set; }

    public String COD_PART { get; set; }

    public String VL_PIS { get; set; }

    public String VL_COFINS { get; set; }
    
    public String COD_CTA { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{COD_CLASS}|{QTD}|{NUM_ITEM}|{COD_ITEM}|{UNID}|{VL_ITEM}|{VL_DESC}|{CST_ICMS}|{CFOP}|{VL_BC_ICMS}|{ALIQ_ICMS}|{VL_ICMS}|{VL_BC_ICMS_ST}|{ALIQ_ST}|{VL_ICMS_ST}|{IND_REC}|{COD_PART}|{VL_PIS}|{VL_COFINS}|{COD_CTA}|";
        
        return ret;
    }

    
}