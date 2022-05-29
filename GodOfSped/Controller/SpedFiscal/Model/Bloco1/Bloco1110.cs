namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1110
{
    public String REG { get; set; } = "1110";

    public String COD_PART { get; set; }

    public String COD_MOD { get; set; }

    public String SER { get; set; }

    public String NUM_DOC { get; set; }

    public String DT_DOC { get; set; }

    public String CHV_NFE { get; set; }

    public String NR_MEMO { get; set; }

    public String QTD { get; set; }
    
    public String UNID { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{SER}|{NUM_DOC}|{COD_PART}|{COD_MOD}|{DT_DOC}|{CHV_NFE}|{NR_MEMO}|{QTD}|{UNID}|";
        
        return ret;
    }

    
}