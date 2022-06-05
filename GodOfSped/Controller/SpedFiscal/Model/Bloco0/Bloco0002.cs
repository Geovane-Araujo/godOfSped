namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0002
{
    public String REG { get; set; } = "0002";
    
    public String CLAS_ESTA_B_IND { get; set; }
    
   

    public String ToString()
    {
        String ret = $"|{REG}|{CLAS_ESTA_B_IND}|";
        
        return ret;
    }
}