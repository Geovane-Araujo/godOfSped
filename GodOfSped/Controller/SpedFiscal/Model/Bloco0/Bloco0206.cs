namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0206
{
    public String REG { get; set; } = "0206";
    
    public String COD_COMB { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_COMB}|";
        
        return ret;
    }
}