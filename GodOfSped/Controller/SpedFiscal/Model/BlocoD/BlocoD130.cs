namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD130
{
    public String REG { get; set; } = "D130";

    public String COD_PART_CONSG { get; set; }
    
    public String COD_PART_RED { get; set; }
    
    public String IND_FRT_RED  { get; set; }
    
    public String COD_MUN_ORIG { get; set; }

    public String COD_MUN_DEST { get; set; }

    public String VEIC_ID { get; set; }
    
    public String VL_LIQ_FRT { get; set; }
    
    public String VL_SEC_CAT  { get; set; }
    
    public String VL_DESP { get; set; }

    public String VL_PEDG { get; set; }

    public String VL_OUT  { get; set; }
    
    public String VL_FRT { get; set; }

    public String UF_ID { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART_CONSG}|{COD_PART_RED}|{IND_FRT_RED}|{COD_MUN_ORIG}|{COD_MUN_DEST}|{VEIC_ID}|{VL_LIQ_FRT}|{VL_SEC_CAT}|{VL_DESP}|{VL_PEDG}|{VL_OUT}|{VL_FRT}|{UF_ID}|";
        
        return ret;
    }
}