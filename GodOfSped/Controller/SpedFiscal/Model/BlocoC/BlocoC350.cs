namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC350
{
    public String REG { get; set; } = "C350";

    public String SER { get; set; }

    public String SUB_SER { get; set; }

    public String NUM_DOC { get; set; }

    public String DT_DOC { get; set; }

    public String CNPJ_CPF { get; set; }

    public String VL_MERC { get; set; }

    public String VL_DOC { get; set; }

    public String VL_DESC { get; set; }

    public String VL_PIS { get; set; }
    
    public String VL_COFINS { get; set; }

    public String COD_CTA { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{SER}|{SUB_SER}|{NUM_DOC}|{DT_DOC}|{CNPJ_CPF}|{VL_MERC}|{VL_DOC}|{VL_DESC}|{VL_PIS}|{VL_COFINS}|{COD_CTA}|";
        
        return ret;
    }
}