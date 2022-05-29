namespace GodOfSped.Model.SpedContribuicoes.Repository;

public class Sql
{
    public static String sqlBloco000 = "select " +
                                       "pj.RazaoSocial as NOME, " +
                                       "pj.CNPJ as CNPJ, " +
                                       "estados.Sigla as UF, " +
                                       "cid.CodigoIBGE as COD_MUN, " +
                                       "fiscal.PisCofinsTipoAtividadePreponderante as IND_ATIV, " +
                                       "fiscal.PisCofinsNaturezaJuridica as IND_NAT_PJ " +
                                       "from pessoas_juridicas as pj " +
                                       "inner join pessoas_enderecos as ender on ender.IDPessoa = pj.IDPessoa " +
                                       "inner join cidades as cid on  ender.IDCidade = cid.ID " +
                                       "inner join estados on cid.IDEstado = estados.ID " +
                                       "inner join pessoas_fiscal_configuracao as fiscal on fiscal.IDPessoa = pj.IDPessoa " +
                                       "where pj.idpessoa = {@@IDPessoa} and ender.Tipo = 0; ";
    
    public static String sqlBloco0100 = "select \n" +
                                        "\tpessoas.Nome as NOME,\n" +
                                        "\tpessoas_fisicas.CPF as CPF,\n" +
                                        "\tISNULL(pessoas_fornecedores.ContadorCRC,'') as CRC,\n" +
                                        "\tpessoas_juridicas.CNPJ as CNPJ,\n" +
                                        "\tpessoas_enderecos.CEP as CEP,\n" +
                                        "\tpessoas_enderecos.Endereco as \"END\",\n" +
                                        "\tpessoas_enderecos.Numero as NUM,\n" +
                                        "\tpessoas_enderecos.Complemento as COMPL,\n" +
                                        "\tpessoas_enderecos.BAIRRO as BAIRRO,\n" +
                                        "\tpessoas_telefones.Fone as FONE,\n" +
                                        "\tpessoas_telefones.Fone as FAX,\n" +
                                        "\tpessoas_emails.Email as EMAIL,\n" +
                                        "\tcidades.CodigoIBGE as COD_MUN\n" +
                                        "from pessoas_clinicas\n" +
                                        "\tinner join pessoas on pessoas.ID = pessoas_clinicas.IDPessoaContador\n" +
                                        "\tleft join pessoas_fisicas on pessoas.ID = pessoas_fisicas.IDPessoa\n" +
                                        "\tleft join pessoas_juridicas on pessoas.ID = pessoas_juridicas.IDPessoa\n" +
                                        "\tinner join pessoas_enderecos on pessoas_enderecos.IDPessoa = pessoas_juridicas.IDPessoa\n" +
                                        "\tinner join cidades on  pessoas_enderecos.IDCidade = cidades.ID\n" +
                                        "\tinner join estados on cidades.IDEstado = estados.ID\n" +
                                        "\tinner join pessoas_telefones on pessoas.ID = pessoas_telefones.IDPessoa\n" +
                                        "\tinner join pessoas_emails on pessoas_emails.IDPessoa = pessoas.ID\n" +
                                        "\tinner join pessoas_fornecedores on pessoas_clinicas.IDPessoa = pessoas_fornecedores.IDPessoa\n" +
                                        "where pessoas_clinicas.IDPessoa = {@@IDPessoa} \n" +
                                        "\tand pessoas_enderecos.Tipo = 0 \n" +
                                        "\tand pessoas_telefones.Tipo = 0\n" +
                                        "\tand pessoas_emails.Tipo = 0";
    
    public static String sqlBloco0110 = "select \n" +
                                        "\t\tIndicadorIncidenciaTributaria as COD_INC_TRIB,\n" +
                                        "\t\tISNULL(CAST(IndicadorApropriacaoCredito as nvarchar),'') as IND_APRO_CRED,\n" +
                                        "\t\tCodigoTipoContribuicao as COD_TIPO_CONT,\n" +
                                        "\t\tIndicadorRegimeCumulativo as IND_REG_CUM\n" +
                                        "\tfrom pessoas_fiscal_configuracao\n" +
                                        "\twhere idpessoa = {@@IDPessoa} ";
    
    public static String sqlBloco0140 = "select \n" +
                                        "\tpj.IDPessoa as COD_EST,\n" +
                                        "\tpj.RazaoSocial as NOME, \n" +
                                        "\tpj.CNPJ as CNPJ,\n" +
                                        "\testados.Sigla as UF, \n" +
                                        "\tcid.CodigoIBGE as COD_MUN,\n" +
                                        "\tpj.InscricaoMunicipal as IM,\n" +
                                        "\tISNULL(pessoas_fornecedores.InscricaoSUFRAMA,'') as SUFRAMA\n" +
                                        "from pessoas_juridicas as pj\n" +
                                        "\tinner join pessoas_enderecos as ender on ender.IDPessoa = pj.IDPessoa\n" +
                                        "\tinner join cidades as cid on  ender.IDCidade = cid.ID\n" +
                                        "\tinner join estados on cid.IDEstado = estados.ID\n" +
                                        "\tinner join pessoas_fiscal_configuracao as fiscal on fiscal.IDPessoa = pj.IDPessoa\n" +
                                        "\tinner join pessoas_fornecedores on pj.IDPessoa = pessoas_fornecedores.IDPessoa\n" +
                                        "where pj.idpessoa = {@@IDPessoa} and ender.Tipo = 0";
}