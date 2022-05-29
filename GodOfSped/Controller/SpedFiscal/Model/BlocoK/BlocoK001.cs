namespace GodOfSped.Controller.SpedFiscal.Model.BlocoK;

public class BlocoK001
{
     public String REG { get; set; } = "K001";
    
    public String IND_MOV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }


    
}