namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class Bloco9001
{   
    public String REG { get; set; } = "9001";
    
    public String IND_MOV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
    
}