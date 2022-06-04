namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK230
{
     public String REG { get; set; } = "K230";

    public String DT_INI_OP { get; set; }

    public String DT_FIN_OP { get; set; }

    public String COD_DOC_OP { get; set; }

    public String COD_ITEM { get; set; }

    public String QTD_ENC { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_DOC_OP}|{COD_ITEM}|{DT_INI_OP}|{DT_FIN_OP}|{QTD_ENC}|";
        
        return ret;
    }
    


    
}