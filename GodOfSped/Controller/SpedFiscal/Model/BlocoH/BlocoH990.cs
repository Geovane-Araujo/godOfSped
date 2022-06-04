namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoH990
{
     public String REG { get; set; } = "H990";
    
    public String QTD_LIN_H { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_H}|";
        
        return ret;
    }
    
    
}