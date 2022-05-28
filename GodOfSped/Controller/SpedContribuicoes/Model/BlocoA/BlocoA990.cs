
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoA990
{
    public String REG { get; } = "A990";
    
    public String QTD_LIN_A { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_A}|";
        return ret;
    }
}