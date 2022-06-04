namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC191
{
    public String REG { get; set; } = "C191";

    public String VL_FCP_OP { get; set; }

    public String VL_FCP_ST { get; set; }

    public String VL_FCP_RET { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_FCP_OP}|{VL_FCP_ST}|{VL_FCP_RET}|";
     
        return ret;
    }
}