namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC410
{
    public String REG { get; set; } = "C410";
    
    public String VL_PIS { get; set; }
    
    public String VL_COFINS { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{VL_PIS}|{VL_COFINS}|";
        
        return ret;
    }
}