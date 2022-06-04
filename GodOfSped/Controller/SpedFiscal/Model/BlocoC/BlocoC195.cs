namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC195
{
    public String REG { get; set; } = "C195";

    public String COD_OBS { get; set; }

    public String TXT_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_OBS}|{TXT_COMPL}|";
     
        return ret;
    }
}