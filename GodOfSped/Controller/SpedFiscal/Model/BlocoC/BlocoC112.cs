namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC112
{
    public String REG { get; set; } = "C112";

    public String COD_DA { get; set; }

    public String UF { get; set; }

    public String NUM_DA { get; set; }

    public String COD_AUT { get; set; }

    public String VL_DA { get; set; }

    public String DT_VCTO { get; set; }

    public String DT_PGTO { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_DA}|{UF}|{NUM_DA}|{COD_AUT}|{VL_DA}|{DT_VCTO}|{DT_PGTO}|";
        
        return ret;
    }
}