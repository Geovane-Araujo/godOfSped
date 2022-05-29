namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD310
{
    public String REG { get; set; } = "D310";

    public String COD_MUN_ORIG { get; set; }

    public String VL_SERV { get; set; }

    public String VL_BC_ICMS { get; set; }
    
    public String VL_ICMS { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MUN_ORIG}|{VL_SERV}|{VL_BC_ICMS}|{VL_ICMS}|";
     
        return ret;
    }
}