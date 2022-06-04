namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK290
{
     public String REG { get; set; } = "K290";

    public String DT_INI_OP { get; set; }

    public String DT_FIN_OP { get; set; }

    public String COD_DOC_OP { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_INI_OP}|{DT_FIN_OP}|{COD_DOC_OP}|";
        
        return ret;
    }
    


    
}