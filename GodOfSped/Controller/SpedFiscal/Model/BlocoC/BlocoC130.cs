namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC130
{
    public String REG { get; set; } = "C130";

    public String VL_SERV_NT { get; set; }

    public String VL_BS_ISSQN { get; set; }

    public String VL_ISSQN { get; set; }

    public String VL_BS_IRRF { get; set; }

    public String VL_IRRF { get; set; }

    public String VL_BS_PREV { get; set; }

    public String VL_PREV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_SERV_NT}|{VL_BS_ISSQN}||{VL_ISSQN}|{VL_BS_IRRF}|{VL_IRRF}||{VL_BS_PREV}|{VL_PREV}|";
        
        return ret;
    }
}