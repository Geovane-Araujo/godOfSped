namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK210
{
     public String REG { get; set; } = "K210";

    public String DT_INI_OS { get; set; }

    public String DT_FIN_OS { get; set; }

    public String COD_DOC_OS { get; set; }

    public String COD_ITEM_ORI { get; set; }

    public String QTD_ORI { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_DOC_OS}|{COD_ITEM_ORI}|{DT_INI_OS}|{DT_FIN_OS}|{QTD_ORI}|";
        
        return ret;
    }
    


    
}