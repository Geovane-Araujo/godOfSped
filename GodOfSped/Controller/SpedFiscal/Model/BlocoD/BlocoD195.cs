namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD195
{
    public String REG { get; set; } = "D195";
    
    public String COD_OBS { get; set; }
    
    public String TXT_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_OBS}|{TXT_COMPL}|";
        
        return ret;
    }
}