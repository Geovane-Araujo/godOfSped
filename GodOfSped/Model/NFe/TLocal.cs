using System.ComponentModel;

namespace GodOfSped.Model.NFe;

public class TLocal
{

    public String CNPJ { get; set; }
    
    public String CPF { get; set; }
    
    public String xNome { get; set; }
    
    [Description("Nome da Rua")]
    public String xLgr { get; set; }
    
    [Description("Numero")]
    public String nro { get; set; }
    
    [Description("Complemento")]
    public String xCpl { get; set; }
    
    [Description("Nome do Bairro")]
    public String xBairro { get; set; }
    
    [Description("Codigo do Municipio")]
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
    
    [Description("Telefone")]
    public String email { get; set; }
    
    [Description("Telefone")]
    public String IE { get; set; }
    
}