namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC171
{
    public String REG { get; set; } = "C171";

    public String NUM_TANQUE { get; set; }

    public String QTDE { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_TANQUE}|{QTDE}|";
        
        return ret;
    }
}