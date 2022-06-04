namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC178
{
    public String REG { get; set; } = "C178";
    
    public String CL_ENQ { get; set; }

    public String VL_UNID { get; set; }
    
    public String QUANT_PAD { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{CL_ENQ}|{VL_UNID}|{QUANT_PAD}|";
        
        return ret;
    }
}