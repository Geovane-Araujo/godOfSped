namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1601
{
    public String REG { get; set; } = "1601";

    public String COD_PART_IP { get; set; }

    public String COD_PART_IT { get; set; }

    public String TOT_VS { get; set; }

    public String TOT_ISS { get; set; }

    public String TOT_OUTROS { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{TOT_VS}|{TOT_ISS}|{COD_PART_IP}|{COD_PART_IT}|{TOT_OUTROS}|";
        
        return ret;
    }

    
}