namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoG130
{
    public String REG { get; set; } = "G130";

    public String IND_EMIT { get; set; }

    public String COD_PART { get; set; }
    
    public String COD_MOD { get; set; }

    public String SERIE { get; set; }

    public String NUM_DOC { get; set; }

    public String CHV_NFE_CTE { get; set; }

    public String DT_DOC { get; set; }

    public String NUM_DA { get; set; }

    public String  { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{IND_EMIT}|{COD_PART}|{COD_MOD}|{SERIE}|{NUM_DOC}|{CHV_NFE_CTE}|{DT_DOC}|{NUM_DA}|";
        
        return ret;
    }
    
    
    
}