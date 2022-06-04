namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class BlocoB001
{
    public String REG { get; set; } = "B001";
    
    public String IND_DAD { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_DAD}|";
        
        return ret;
    }
}