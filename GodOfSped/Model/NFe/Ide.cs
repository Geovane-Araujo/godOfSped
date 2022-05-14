using System.ComponentModel;

namespace GodOfSped.Model.NFe;

public class Ide
{
    [Description("Codigo da UF do emitente")]
    public String cUF { get; set; }
    
    [Description("")]
    public String cNF { get; set; }
    
    [Description("Natureza da Operaçção, descrição")]
    public String natOp { get; set; }
    
    [Description("Modelo da NFE, aceitos 55 e 65")]
    public String mod { get; set; }
    
    [Description("Serie NF")]
    public String serie { get; set; }
    
    [Description("Numero NF")]
    public String nNF { get; set; }
    
    [Description("Data da emissão em formato yyyy-MM-dd'T'HH:mm:ss")]
    public DateTime dhEmi { get; set; }
    
    [Description("Data da saida em formato yyyy-MM-dd'T'HH:mm:ss")]
    public DateTime dhSaiEnt { get; set; }
    
    [Description("tipo da NF")]
    public int tpNF { get; set; }
    
    [Description("")]
    public int idDest { get; set; }
    
    [Description("")]
    public String cMunFG { get; set; }
    
    [Description("")]
    public int tpImp { get; set; }
    
    [Description("")]
    public int tpEmis { get; set; }
    
    [Description("")]
    public int cDV { get; set; }
    
    [Description("")]
    public int tpAmb { get; set; }
    
    [Description("Finalidade da NFe(Campo novo)")]
    public String finNFe { get; set; }
    
    [Description("")]
    public int indFinal { get; set; }
    
    [Description("")]
    public int indIntermed { get; set; }
    
    [Description("")]
    public int procEmi { get; set; }
    
    [Description("")]
    public String verProc { get; set; }
    
}