namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC105
{
    public String REG { get; set; } = "C105";

    public String OPER { get; set; }

    public String UF { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{OPE}|{UF}|";
        
        return ret;
    }
}