namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD300
{
    public String REG { get; set; } = "D300";
    
    public String COD_MOD { get; set; }
    
    public String SER { get; set; }
    
    public String SUB  { get; set; }
    
    public String NUM_DOC_INI { get; set; }
    
    public String NUM_DOC_FIN { get; set; }
    
    public String CST_ICMS { get; set; }

    public String CFOP { get; set; }
    
    public String ALIQ_ICMS { get; set; }

    public String DT_DOC { get; set; }

    public String VL_OPR { get; set; }

    public String VL_DESC { get; set; }

    public String VL_SERV { get; set; }
    
    public String VL_SEG { get; set; }
    
    public String VL_OUT_DESP { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String VL_RED_BC { get; set; }

    public String COD_OBS { get; set; }
    
    public String COD_CTA { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{SER}|{SUB}|{NUM_DOC_INI}|" +
                     $"{NUM_DOC_FIN}|{CST_ICMS}|{CFOP}|{ALIQ_ICMS}|{DT_DOC}|" +
                     $"{VL_OPR}|{VL_DESC}|{VL_SERV}|{VL_SEG}|{VL_OUT_DESP}|{VL_BC_ICMS}|" +
                     $"{VL_ICMS}|{VL_RED_BC}|{COD_OBS}|{COD_CTA}|";
        
        return ret;
    }
}