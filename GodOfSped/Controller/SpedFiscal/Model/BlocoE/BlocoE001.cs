namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE001
{
    public String REG { get; set; } = "E001";
    
    public String IND_MOV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
    
}