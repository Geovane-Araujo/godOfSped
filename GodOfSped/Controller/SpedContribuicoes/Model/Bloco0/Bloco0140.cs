
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0140
{
    public String REG { get; } = "0120";
    
    public String COD_EST { get; set; }
    
    public String NOME { get; set; }
    
    public String CNPJ { get; set; }
    
    public String UF { get; set; }
    
    public String IE { get; set; }
    
    public String COD_MUN { get; set; }
    
    public String IM { get; set; }
    
    public String SUFRAMA { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_EST}|{NOME}|{CNPJ}|{UF}|{IE}|{COD_MUN}|{IM}|{SUFRAMA}|";
        
        return ret;
    }
}