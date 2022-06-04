namespace GodOfSped.Controller.SpedFiscal.Model.BlocoG;

public class BlocoG001
{
    public String REG { get; set; } = "G001";
    
    public String IND_MOV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
    
}