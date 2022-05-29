namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC110
{
    public String REG { get; set; } = "C110";

    public String COD_INF { get; set; }

    public String TXT_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_INF}|{TXT_COMPL}|";
        
        return ret;
    }
}