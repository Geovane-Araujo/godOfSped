using System.ComponentModel;

namespace GodOfSped.Model.NFe;

public class Address
{
    [Description("Nome da Rua")]
    public String xLgr { get; set; }
    
    [Description("Numero")]
    public String nro { get; set; }
    
    [Description("Nome do Bairro")]
    public String xBairro { get; set; }
    
    [Description("NCodigo do Municipio")]
    public String cMun { get; set; }
    
    [Description("Nome do Municipio")]
    public String xMun { get; set; }
    
    [Description("Uf Abreviada em duas letras")]
    public String UF { get; set; }
    
    [Description("Cep")]
    public String CEP { get; set; }
    
    [Description("Codigo do Pais")]
    public String cPais { get; set; } = "1058";
    
    [Description("Nome do Pais")]
    public String xPais { get; set; } = "BRASIL";
    
    [Description("Telefone")]
    public String fone { get; set; }
    
}