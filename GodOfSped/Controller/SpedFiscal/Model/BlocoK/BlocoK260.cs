namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK260
{
     public String REG { get; set; } = "K260";

    public String COD_OP_OS { get; set; }

    public String COD_ITEM { get; set; }

    public String DT_SAIDA { get; set; }

    public String QTD_SAIDA { get; set; }

    public String DT_RET { get; set; }
    
    public String QTD_RET { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_SAIDA}|{QTD_SAIDA}|{COD_OP_OS}|{COD_ITEM}|{DT_RET}|{QTD_RET}|";
        
        return ret;
    }
    


    
}