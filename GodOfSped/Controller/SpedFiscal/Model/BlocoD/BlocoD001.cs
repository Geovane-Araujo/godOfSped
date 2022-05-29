namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD001
{
    public String REG { get; set; } = "D001";
    
    public String IND_MOV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
}