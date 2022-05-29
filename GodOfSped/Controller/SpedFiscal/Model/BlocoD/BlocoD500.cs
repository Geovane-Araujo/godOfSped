namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD500
{
    public String REG { get; set; } = "D500";

    public String IND_OPER { get; set; }
    
    public String IND_EMIT { get; set; }
    
    public String COD_PART  { get; set; }
    
    public String COD_MOD { get; set; }

    public String COD_SIT { get; set; }

    public String SER { get; set; }
    
    public String SUB { get; set; }
    
    public String NUM_DOC  { get; set; }
    
    public String DT_DOC { get; set; }

    public String DT_A_P { get; set; }

    public String VL_DOC  { get; set; }
    
    public String VL_DESC { get; set; }

    public String VL_SERV { get; set; }

    public String VL_SERV_NT { get; set; }

    public String VL_TERC { get; set; }

    public String VL_DA { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }
    
    public String COD_INF { get; set; }

    public String VL_PIS { get; set; }

    public String VL_COFINS { get; set; }

    public String COD_CTA { get; set; }
    
    public String TP_ASSINANTE { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{IND_EMIT}|{VL_DA}|{COD_MOD}||{COD_SIT}|{SER}|{SUB}|{NUM_DOC}|{DT_DOC}|{DT_A_P}|{VL_DOC}|{VL_ICMS}|{VL_SERV}|{VL_SERV_NT}|{VL_TERC}|{COD_PART}|{VL_BC_ICMS}|{VL_ICMS}|{COD_INF}|{VL_PIS}|{VL_COFINS}|{COD_CTA}|{TP_ASSINANTE}|";
        
        return ret;
    }
}