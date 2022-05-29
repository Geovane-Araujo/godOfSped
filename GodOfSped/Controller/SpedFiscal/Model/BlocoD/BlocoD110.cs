namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD110
{
    public String REG { get; set; } = "D110";

    public String NUM_ITEM { get; set; }
    
    public String COD_ITEM { get; set; }
    
    public String VL_SERV  { get; set; }
    
    public String VL_OUT { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_ITEM}|{COD_ITEM}|{VL_SERV}|{VL_OUT}|";
        
        return ret;
    }
}