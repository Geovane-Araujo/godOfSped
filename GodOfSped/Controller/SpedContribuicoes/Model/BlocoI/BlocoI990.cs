
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoI990
{
    public String REG { get; } = "I990";
    
    public String QTD_LIN_I { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_I}|";
        
        return ret;
    }
}