namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0500
{
    public String REG { get; set; } = "0500";
    
    public String DT_ALT { get; set; }
    
    public String NAT_CC { get; set; }

    public String IND_CTA { get; set; }

    public String NÍVEL { get; set; }

    public String COD_CTA { get; set; }

    public String NOME_CTA { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_ALT}|{NAT_CC}|{IND_CTA}|{NÍVEL}|{COD_CTA}|{NOME_CTA}|";
        
        return ret;
    }
}