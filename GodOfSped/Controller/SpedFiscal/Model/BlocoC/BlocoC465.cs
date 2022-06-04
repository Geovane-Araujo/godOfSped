namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC465
{
    public String REG { get; set; } = "C465";
    
    public String CHV_CFE { get; set; }
    
    public String NUM_CCF { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{CHV_CFE}|{NUM_CCF}|";
        
        return ret;
    }
}