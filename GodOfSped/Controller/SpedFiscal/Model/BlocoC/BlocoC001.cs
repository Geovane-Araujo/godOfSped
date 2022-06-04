namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC001
{
    public String REG { get; set; } = "C001";
    
    public String IND_DAD { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_DAD}|";
        
        return ret;
    }
}