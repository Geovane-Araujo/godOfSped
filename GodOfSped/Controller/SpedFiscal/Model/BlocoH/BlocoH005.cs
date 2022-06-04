namespace GodOfSped.Controller.SpedFiscal.Model.BlocoH;

public class BlocoH005
{
    public String REG { get; set; } = "H005";

    public String DT_INV { get; set; }

    public String VL_INV { get; set; }

    public String MOT_INV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{DT_INV}|{VL_INV}|{MOT_INV}|";
        
        return ret;
    }
    
    
    
}