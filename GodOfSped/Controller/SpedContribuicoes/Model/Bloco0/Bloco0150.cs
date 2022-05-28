
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0150
{
    public String REG { get; } = "0150";
    
    public String COD_PART { get; set; }
    
    public String NOME { get; set; }
    
    public String CNPJ { get; set; }
    
    public String CPF { get; set; }
    
    public String IE { get; set; }
    
    public String COD_MUN { get; set; }
    
    public String SUFRAMA { get; set; }
    
    public String END { get; set; }
    
    public String NUM { get; set; }
    
    public String COMPL { get; set; }
    
    public String BAIRRO { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART}|{NOME}|{CNPJ}|{CPF}|{IE}|{COD_MUN}|{COD_MUN}|{SUFRAMA}|{END}|{NUM}|{COMPL}|{BAIRRO}|";
        
        return ret;
    }
}