namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK270
{
     public String REG { get; set; } = "K270";

    public String DT_INI_AP { get; set; }

    public String DT_FIN_AP { get; set; }

    public String COD_OP_OS { get; set; }

    public String COD_ITEM { get; set; }

    public String QTD_COR_POS { get; set; }
    
    public String QTD_COR_NEG { get; set; }

    public String ORIGEM { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_INI_AP}|{DT_FIN_AP}|{COD_OP_OS}|{COD_ITEM}|{QTD_COR_POS}|{QTD_COR_NEG}|{ORIGEM}|";
        
        return ret;
    }
    


    
}