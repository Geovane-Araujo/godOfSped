namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1370
{
    public String REG { get; set; } = "1370";

    public String NUM_BICO { get; set; }

    public String COD_ITEM { get; set; }

    public String NUM_TANQUE { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_TANQUE}|{NUM_BICO}|{COD_ITEM}|";
        
        return ret;
    }

    
}