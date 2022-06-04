namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC141
{
    public String REG { get; set; } = "C141";

    public String NUM_PARC { get; set; }

    public String DT_VCTO { get; set; }

    public String VL_PARC { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_PARC}|{DT_VCTO}||{VL_PARC}|";
        
        return ret;
    }
}