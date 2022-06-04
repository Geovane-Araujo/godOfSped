namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC172
{
    public String REG { get; set; } = "C172";
    
    public String VL_BC_ISSQN { get; set; }

    public String ALIQ_ISSQN { get; set; }
    
    public String VL_ISSQN { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_BC_ISSQN}|{ALIQ_ISSQN}|{VL_ISSQN}|";
        
        return ret;
    }
}