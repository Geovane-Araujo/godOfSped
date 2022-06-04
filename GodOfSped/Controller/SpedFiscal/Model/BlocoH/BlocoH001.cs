namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoH001
{
     public String REG { get; set; } = "H001";
    
    public String IND_MOV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
    
    
}