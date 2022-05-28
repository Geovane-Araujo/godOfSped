
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0500
{
    public String REG { get; } = "0500";
    
    public String DT_ALT { get; set; }
    
    public String COD_NAT_CC { get; set; }
    
    public String IND_CTA { get; set; }
    
    public String NÍVEL { get; set; }
    
    public String COD_CTA { get; set; }
    
    public String NOME_CTA { get; set; }
    
    public String COD_CTA_REF { get; set; }
    
    public String CNPJ_EST { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{DT_ALT}|{COD_NAT_CC}|{IND_CTA}|{NÍVEL}|{COD_CTA}|{NOME_CTA}|{COD_CTA_REF}|{CNPJ_EST}|";
        
        return ret;
    }
}