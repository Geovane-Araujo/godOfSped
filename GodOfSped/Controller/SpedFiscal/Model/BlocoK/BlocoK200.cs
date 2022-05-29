namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK200
{
     public String REG { get; set; } = "K200";

    public String DT_EST { get; set; }

    public String COD_ITEM { get; set; }

    public String QTD { get; set; }

    public String IND_EST { get; set; }

    public String COD_PART { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{QTD}|{IND_EST}|{DT_EST}|{COD_ITEM}|{COD_PART}|";
        
        return ret;
    }
    


    
}