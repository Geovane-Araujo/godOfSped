namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD100
{
    public String REG { get; set; } = "D100";

    public String IND_OPER { get; set; }
    
    public String IND_EMIT { get; set; }
    
    public String COD_PART  { get; set; }
    
    public String COD_MOD { get; set; }

    public String COD_SIT { get; set; }

    public String SER { get; set; }
    
    public String SUB { get; set; }
    
    public String NUM_DOC  { get; set; }
    
    public String CHV_CTE { get; set; }

    public String DT_DOC { get; set; }

    public String DT_A_P  { get; set; }
    
    public String TP_CT_e { get; set; }

    public String CHV_CTE_REF { get; set; }

     public String VL_DOC { get; set; } ;

    public String VL_DESC { get; set; }
    
    public String IND_FRT { get; set; }
    
    public String VL_SERV  { get; set; }
    
    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }
    
    public String VL_NT { get; set; }
        
    public String COD_INF { get; set; }

    public String COD_CTA { get; set; }

    public String COD_MUN_ORIG  { get; set; }
    
    public String COD_MUN_DEST { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{IND_EMIT}|{COD_PART}|{COD_MOD}|{COD_SIT}|{SER}|{SUB}|{NUM_DOC}|{CHV_CTE}|{DT_DOC}|{DT_A_P}|{TP_CT_e}|{CHV_CTE_REF}|{VL_DOC}|{VL_DESC}|{IND_FRT}|{VL_SERV}|{VL_BC_ICMS}|{VL_ICMS}|{VL_NT}|{NUM_DOC}|{COD_INF}|{COD_CTA}|{COD_MUN_ORIG}|{COD_MUN_DEST}|";
        
        return ret;
    }
}