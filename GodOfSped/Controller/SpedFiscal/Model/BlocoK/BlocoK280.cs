namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK280
{
     public String REG { get; set; } = "K280";

    public String DT_EST { get; set; }

    public String COD_ITEM { get; set; }

    public String QTD_COR_POS { get; set; }

    public String QTD_COR_NEG { get; set; }

    public String IND_EST { get; set; }
    
    public String COD_PART { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_EST}|{COD_ITEM}|{QTD_COR_POS}|{QTD_COR_NEG}|{IND_EST}|{COD_PART}|";
        
        return ret;
    }
    


    
}