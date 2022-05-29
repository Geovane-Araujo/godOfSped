
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF010
{
    public String REG { get; } = "F010";
    
    public String CNPJ { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ}|";
        
        return ret;
    }
}