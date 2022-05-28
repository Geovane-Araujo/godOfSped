
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoP100
{
    public String REG { get; } = "P100";
    
    public String DT_INI { get; set; }
    
    public String DT_FIN { get; set; }
    
    public String VL_REC_TOT_EST { get; set; }
    
    public String COD_ATIV_ECON { get; set; }
    
    public String VL_REC_ATIV_ESTAB { get; set; }
    
    public String VL_EXC { get; set; }
    
    public String VL_BC_CONT { get; set; }
    
    public String ALIQ_CONT { get; set; }
    
    public String VL_CONT_APU { get; set; }
    
    public String INFO_COMPL { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{DT_INI}|{DT_FIN}|{VL_REC_TOT_EST}|{COD_ATIV_ECON}|{VL_REC_ATIV_ESTAB}|{VL_EXC}|{VL_BC_CONT}|{ALIQ_CONT}|" +
                     $"{VL_CONT_APU}|{INFO_COMPL}|";
        
        return ret;
    }
}