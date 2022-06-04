namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE510
{
    public String REG { get; set; } = "E510";

    public String CFOP { get; set; }

    public String CST_IPI { get; set; }

    public String VL_CONT_IPI { get; set; }

    public String VL_BC_IPI { get; set; }

    public String VL_IPI { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{CFOP}|{CST_IPI}|{VL_CONT_IPI}|{VL_BC_IPI}|{VL_IPI}|";
        
        return ret;
    }
    
}