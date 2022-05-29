namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD400
{
    public String REG { get; set; } = "D400";

    public String COD_PART { get; set; }
    
    public String COD_MOD { get; set; }
    
    public String COD_SIT  { get; set; }
    
    public String SER { get; set; }

    public String SUB { get; set; }

    public String NUM_DOC { get; set; }
    
    public String DT_DOC { get; set; }
    
    public String VL_DOC  { get; set; }
    
    public String VL_DESC { get; set; }

    public String VL_SERV { get; set; }

    public String VL_BC_ICMS  { get; set; }
    
    public String VL_ICMS { get; set; }

    public String VL_PIS { get; set; }

    public String VL_COFINS { get; set; }

    public String COD_CTA { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART}|{COD_MOD}|{COD_SIT}|{SER}||{SUB}|{NUM_DOC}|{DT_DOC}|{VL_DOC}|{VL_DESC}|{VL_SERV}||{VL_BC_ICMS}|{VL_ICMS}|{VL_PIS}|{VL_COFINS}|{COD_CTA}|";
        
        return ret;
    }
}