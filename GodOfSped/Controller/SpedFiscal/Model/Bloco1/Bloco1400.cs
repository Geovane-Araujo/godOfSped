namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1400
{
    public String REG { get; set; } = "1400";

    public String COD_ITEM_IPM { get; set; }

    public String MUN { get; set; }

    public String VALOR { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VALOR}|{COD_ITEM_IPM}|{MUN}|";
        
        return ret;
    }

    
}