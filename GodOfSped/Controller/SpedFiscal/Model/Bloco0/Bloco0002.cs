namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0002
{
    public String REG { get; set; } = "0002";
    
    public String CLAS_ESTA B_IND { get; set; }
    
   

    public String ToString()
    {
        String ret = $"|{REG}|{CLAS_ESTA B_IND}|";
        
        return ret;
    }
}