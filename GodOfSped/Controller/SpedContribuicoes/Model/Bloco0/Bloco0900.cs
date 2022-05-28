
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0900
{
    public String REG { get; } = "0900";
    
    public String REC_TOTAL_BLOCO_A { get; set; }
    
    public String REC_NRB_BLOCO_A { get; set; }
    
    public String REC_TOTAL_BLOCO_C { get; set; }
    
    public String REC_NRB_BLOCO_C { get; set; }
    
    public String REC_TOTAL_BLOCO_D { get; set; }
    
    public String REC_NRB_BLOCO_D { get; set; }
    
    public String REC_TOTAL_BLOCO_F { get; set; }
    
    public String REC_NRB_BLOCO_F { get; set; }
    
    public String REC_TOTAL_BLOCO_I { get; set; }
    
    public String REC_NRB_BLOCO_I { get; set; }
    
    public String REC_TOTAL_BLOCO_1 { get; set; }
    
    public String REC_NRB_BLOCO_1 { get; set; }
    
    public String REC_TOTAL_PERIODO { get; set; }
    
    public String REC_TOTAL_NRB_PERÍODO { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{REC_TOTAL_BLOCO_A}|{REC_NRB_BLOCO_A}|{REC_TOTAL_BLOCO_C}|{REC_NRB_BLOCO_C}|{REC_TOTAL_BLOCO_D}|{REC_NRB_BLOCO_D}|{REC_TOTAL_BLOCO_F}|{REC_NRB_BLOCO_F}|" +
                     $"{REC_TOTAL_BLOCO_I}|{REC_NRB_BLOCO_I}|{REC_TOTAL_BLOCO_1}|{REC_NRB_BLOCO_1}|{REC_TOTAL_PERIODO}|{REC_TOTAL_PERIODO}|{REC_TOTAL_NRB_PERÍODO}";
        
        return ret;
    }
}