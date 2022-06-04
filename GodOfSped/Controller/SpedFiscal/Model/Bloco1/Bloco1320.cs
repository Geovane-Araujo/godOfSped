namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1320
{
    public String REG { get; set; } = "1320";

    public String NUM_BICO { get; set; }

    public String NR_INTERV { get; set; }

    public String MOT_INTERV { get; set; }

    public String NOM_INTERV { get; set; }

    public String CNPJ_INTERV { get; set; }

    public String CPF_INTERV { get; set; }

    public String VAL_FECHA { get; set; }

    public String VAL_ABERT { get; set; }

    public String VOL_AFERI { get; set; }

    public String VOL_VENDAS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{MOT_INTERV}|{NOM_INTERV}|{NUM_BICO}|{NR_INTERV}|{CNPJ_INTERV}|{CPF_INTERV}|{VAL_FECHA}|{VAL_ABERT}|{VOL_AFERI}|{VOL_VENDAS}|";
        
        return ret;
    }

    
}