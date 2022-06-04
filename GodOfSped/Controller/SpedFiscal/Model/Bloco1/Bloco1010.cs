namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1010
{
    public String REG { get; set; } = "1010";

    public String IND_EXP { get; set; }

    public String IND_CCRF { get; set; }

    public String IND_COMB { get; set; }

    public String IND_USINA { get; set; }

    public String IND_VA { get; set; }

    public String IND_EE { get; set; }

    public String IND_CART { get; set; }

    public String IND_FORM { get; set; }

    public String IND_AER { get; set; }

    public String ND_GIAF1 { get; set; }

    public String ND_GIAF3 { get; set; }

    public String ND_GIAF4 { get; set; }

    public String IND_REST_RESSARC_COMPL_ICMS { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{IND_COMB}|{IND_USINA}|{IND_EXP}|{IND_CCRF}|{IND_VA}|{IND_EE}|{IND_CART}|{IND_FORM}|{IND_AER}|{ND_GIAF1}|{ND_GIAF3}|{ND_GIAF4}|{IND_REST_RESSARC_COMPL_ICMS}|";
        
        return ret;
    }

    
}