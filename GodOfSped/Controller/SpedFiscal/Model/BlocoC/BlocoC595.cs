namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC595
{
    public String REG { get; set; } = "C595";
    
    public String COD_OBS { get; set; }
    
    public String TXT_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_OBS}|{TXT_COMPL}|";
        
        return ret;
    }
}