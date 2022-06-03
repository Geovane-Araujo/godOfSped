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
                                       "where pj.idpessoa = {@@IDEmpresa} and ender.Tipo = 0; ";
    
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
                                        "where pessoas_clinicas.IDPessoa = {@@IDEmpresa} \n" +
                                        "\tand pessoas_enderecos.Tipo = 0 \n" +
                                        "\tand pessoas_telefones.Tipo = 0\n" +
                                        "\tand pessoas_emails.Tipo = 0";
    
    public static String sqlBloco0110 = "select \n" +
                                        "\t\tIndicadorIncidenciaTributaria as COD_INC_TRIB,\n" +
                                        "\t\tISNULL(CAST(IndicadorApropriacaoCredito as nvarchar),'') as IND_APRO_CRED,\n" +
                                        "\t\tCodigoTipoContribuicao as COD_TIPO_CONT,\n" +
                                        "\t\tIndicadorRegimeCumulativo as IND_REG_CUM\n" +
                                        "\tfrom pessoas_fiscal_configuracao\n" +
                                        "\twhere idpessoa = {@@IDEmpresa} ";
    
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
                                        "where pj.idpessoa = {@@IDEmpresa} and ender.Tipo = 0";
    
    public static String sqlBloco0150 =  "select distinct\n" +
                                         "\tIDPessoaDestinatario_Gestao as COD_PART, \n" +
                                         "\tE04_xNome as NOME, \n" +
                                         "\t[E14_cPais] as COD_PAIS,\n" +
                                         "\tE02_CNPJ as CNPJ,\n" +
                                         "\tE03_CPF as CPF,\n" +
                                         "\tE17_IE as IE,\n" +
                                         "\tE10_cMun as COD_MUN,\n" +
                                         "\tE06_xLgr as \"END\",\n" +
                                         "\tE07_nro as NUM,\n" +
                                         "\tE18_ISUF as SUFRAMA,\n" +
                                         "\tE08_xCpl as COMPL,\n" +
                                         "\tE09_xBairro as BAIRRO\n" +
                                         "from NFe_identificacao_destinatario\n" +
                                         "\tinner join nfe on nfe.ID = NFe_identificacao_destinatario.IDNota\n" +
                                         "where nfe.B09_dhEmi between '{@@dataini}' and '{@@datafim}' and IDMultiEmpresa = {@@IDEmpresa} and nfe.Emitida = 1\n" +
                                         "union\n" +
                                         "select distinct\n" +
                                         "\tIDPessoaEmitente_Gestao as COD_PART, \n" +
                                         "\t[C03_xNome] as NOME, \n" +
                                         "\t[C14_cPais] as COD_PAIS,\n" +
                                         "\t[C02_CNPJ] as CNPJ,\n" +
                                         "\t[C02a_CPF] as CPF,\n" +
                                         "\t[C17_IE] as IE,\n" +
                                         "\t[C10_cMun] as COD_MUN,\n" +
                                         "\t[C06_xLgr] as \"END\",\n" +
                                         "\t[C07_nro] as NUM,\n" +
                                         "\t'' as SUFRAMA,\n" +
                                         "\t[C08_xCpl] as COMPL,\n" +
                                         "\t[C09_xBairro] as BAIRRO\n" +
                                         "from NFe_identificacao_emitente\n" +
                                         "\tinner join nfe on nfe.ID = NFe_identificacao_emitente.IDNota\n" +
                                         "where nfe.B09_dhEmi between '{@@dataini}' and '{@@datafim}' and IDMultiEmpresa = {@@IDEmpresa} and nfe.Emitida = 1\n";
    
    public static String sqlBloco0190 = "select  distinct\n" +
                                        "\tI09_uCom\tas UNID,\n" +
                                        "\tI09_uCom\tas DESCR\n" +
                                        "from NFe_produtos_servicos\n" +
                                        "\tinner join nfe on nfe.ID = NFe_produtos_servicos.IDNota\n" +
                                        "where nfe.B09_dhEmi between '{@@dataini}' and '{@@datafim}' and nfe.IDMultiEmpresa = {@@IDEmpresa} and nfe.Emitida = 1";
    
    public static String sqlBloco0200 = "select  distinct\n" +
                                         "\tIDProdutoGrade as COD_ITEM,\n" +
                                         "\tI04_xProd as DESCR_ITEM,\n" +
                                         "\tI03_cEAN as COD_BARRA,\n" +
                                         "\tI09_uCom\tas UNID_INV,\n" +
                                         "\t'0'+ CAST(produtos.TipoItemFiscal as varchar) as TIPO_ITEM,\n" +
                                         "\tI05_NCM as COD_NCM\n" +
                                         " from NFe_produtos_servicos\n" +
                                         "\tinner join nfe on nfe.ID = NFe_produtos_servicos.IDNota\n" +
                                         "\tinner join produtos_grades_estoque on produtos_grades_estoque.ID = NFe_produtos_servicos.IDProdutoGrade\n" +
                                         "\tinner join produtos on produtos.ID = produtos_grades_estoque.IDProduto\n" +
                                         "where nfe.B09_dhEmi between '{@@dataini}' and '{@@datafim}' and nfe.IDMultiEmpresa = {@@IDEmpresa} and  nfe.Emitida = 1";
    
    public static String sqlBloco0500 = "select distinct\n" +
                                        "\t'0' + CAST(plano_contas.COD_NAT_CC as varchar) as COD_NAT_CC,\n" +
                                        "\tcase plano_contas.Tipo when 1 then 'S' else 'A' end as IND_CTA,\n" +
                                        "\tplano_contas.Nivel as NÍVEL,\n" +
                                        "\tplano_contas.ID as COD_CTA,\n" +
                                        "\tplano_contas.Descricao as NOME_CTA,\n" +
                                        "\tplano_contas.CodigoEspecifico as COD_CTA_REF,\n" +
                                        "\tISNULL(CAST(plano_contas.DataAlteracaoContabil as varchar),FORMAT(GETDATE(),'ddMMyyyy','pt-BR')) as DT_ALT,\n" +
                                        "\tpessoas_juridicas.CNPJ as CNPJ_EST\n" +
                                        "from nfe\n" +
                                        "\tinner join plano_contas on plano_contas.ID = nfe.IDPC_Gestao\n" +
                                        "\tleft join pessoas_juridicas on pessoas_juridicas.IDPessoa = nfe.IDMultiEmpresa\n" +
                                        "where nfe.B09_dhEmi between '{@@dataini}' and '{@@datafim}' and nfe.IDMultiEmpresa = {@@IDEmpresa} and B11_tpNF = 1";
    
    public static String sqlBlocoC100 = "select \n nfe.id as  IDNOTA, " +
                                        "\tnfe.B11_tpNF as IND_OPER,\n" +
                                        "\tnfe.B22_tpEmis as IND_EMIT,\n" +
                                        "\tcase nfe.B11_tpNF \n" +
                                        "\t\twhen 0 \n" +
                                        "\t\tthen NFe_identificacao_emitente.IDPessoaEmitente_Gestao\n" +
                                        "\t\telse NFe_identificacao_destinatario.IDPessoaDestinatario_Gestao\n" +
                                        "\tend as COD_PART,\n" +
                                        "\tnfe.B06_mod as COD_MOD,\n" +
                                        "\tnfe.B26_procEmi as COD_SIT,\n" +
                                        "\tnfe.B07_serie as SER,\n" +
                                        "\tnfe.B08_nNF as NUM_DOC,\n" +
                                        "\tnfe.A03_id as CHV_NFE,\n" +
                                        "\tCAST(FORMAT(nfe.B09_dhEmi,'ddMMyyyy','pt-BR') as varchar) as DT_DOC,\n" +
                                        "\tCAST(FORMAT(nfe.B10_dhSaiEnt,'ddMMyyyy','pt-BR') as varchar) as DT_E_S,\n" +
                                        "\tNFe_total.W16_vNF as VL_DOC,\n" +
                                        "\tnfe.IDPlanoPagamento as IND_PGTO,\n" +
                                        "\tNFe_total.W10_vDesc as VL_DESC,\n" +
                                        "\tNFe_total.W07_vProd as VL_MERC,\n" +
                                        "\tNFe_transporte.X02_modFrete as IND_FRT,\n" +
                                        "\tNFe_transporte.X12_vServ as VL_FRT,\n" +
                                        "\tNFe_total.W09_vSeg as VL_SEG,\n" +
                                        "\tNFe_total.W15_vOutro as VL_OUT_DA,\n" +
                                        "\tNFe_total.W03_vBC as VL_BC_ICMS,\n" +
                                        "\tNFe_total.W04_vICMS as VL_ICMS,\n" +
                                        "\tNFe_total.W05_vBCST as VL_BC_ICMS_ST,\n" +
                                        "\tNFe_total.W06_vST as VL_ICMS_ST,\n" +
                                        "\tNFe_total.W12_vIPI as VL_IPI,\n" +
                                        "\tNFe_total.W13_vPIS as VL_PIS,\n" +
                                        "\tNFe_total.W14_vCOFINS as VL_COFINS,\n" +
                                        "\tNFe_total.W21_vPIS as VL_PIS_ST,\n" +
                                        "\tNFe_total.W22_vCOFINS as VL_COFINS_ST\n" +
                                        "from nfe\n" +
                                        "\tinner join NFe_identificacao_destinatario on nfe.ID = NFe_identificacao_destinatario.IDNota \n" +
                                        "\tinner join NFe_identificacao_emitente on nfe.ID = NFe_identificacao_emitente.IDNota\n" +
                                        "\tinner join NFe_total on nfe.ID = NFe_total.IDNota\n" +
                                        "\tinner join NFe_transporte on NFe_transporte.IDNota = nfe.ID\n" +
                                        "where nfe.B09_dhEmi between '{@@dataini}' and '{@@datafim}' and nfe.IDMultiEmpresa = {@@IDEmpresa} and (nfe.Emitida = 1 or B11_tpNF = 0)";
    
    public static String sqlBlocoC170 = "select \n" +
                                        "\tnfe.ID as IDNOTA,\n" +
                                        "\tNFe_produtos_servicos.H02_nItem as NUM_ITEM,\n" +
                                        "\tNFe_produtos_servicos.IDProdutoGrade as COD_ITEM,\n" +
                                        "\tNFe_produtos_servicos.I04_xProd as DESCR_COMPL,\n" +
                                        "\tNFe_produtos_servicos.I10_qCom as QTD,\n" +
                                        "\tNFe_produtos_servicos.I09_uCom as UNID,\n" +
                                        "\tNFe_produtos_servicos.I11_vProd as VL_ITEM,\n" +
                                        "\tNFe_produtos_servicos.I17_vDesc as VL_DESC,\n" +
                                        "\t'0' as IND_MOV,\n" +
                                        "\tNFe_produtos_servicos_icms.N12_CST as CST_ICMS,\n" +
                                        "\tNFe_produtos_servicos.I08_CFOP as CFOP,\n" +
                                        "\tNFe_produtos_servicos_icms.N15_vBC as VL_BC_ICMS,\n" +
                                        "\tNFe_produtos_servicos_icms.N16_pICMS as ALIQ_ICMS,\n" +
                                        "\tNFe_produtos_servicos_icms.N17_vICMS as VL_ICMS,\n" +
                                        "\tNFe_produtos_servicos_icms.N21_vBCST as VL_BC_ICMS_ST,\n" +
                                        "\tNFe_produtos_servicos_icms.N22_pICMSST as ALIQ_ST,\n" +
                                        "\tNFe_produtos_servicos_icms.N23_vICMSST as VL_ICMS_ST,\n" +
                                        "\t'' as IND_APUR,\n" +
                                        "\tNFe_produtos_servicos_ipi.O09_CST as CST_IPI,\n" +
                                        "\tNFe_produtos_servicos_ipi.O02_clEnq as COD_ENQ,\n" +
                                        "\tNFe_produtos_servicos_ipi.O10_vBC as VL_BC_IPI,\n" +
                                        "\tNFe_produtos_servicos_ipi.O13_pIPI as ALIQ_IPI,\n" +
                                        "\tNFe_produtos_servicos_ipi.O14_vIPI as VL_IPI,\n" +
                                        "\tNFe_produtos_servicos_pis.Q06_CST as CST_PIS,\n" +
                                        "\tNFe_produtos_servicos_pis.Q07_vBC as VL_BC_PIS,\n" +
                                        "\tNFe_produtos_servicos_pis.Q08_pPIS as ALIQ_PIS,\n" +
                                        "\tNFe_produtos_servicos_pis.Q10_qBCProd as QUANT_BC_PIS,\n" +
                                        "\tNFe_produtos_servicos_pis.Q11_vAliqProd as ALIQ_PIS_QUANT,\n" +
                                        "\tNFe_produtos_servicos_pis.Q09_vPIS as VL_PIS,\n" +
                                        "\tNFe_produtos_servicos_cofins.S06_CST as CST_COFINS,\n" +
                                        "\tNFe_produtos_servicos_cofins.S07_vBC as VL_BC_COFINS,\n" +
                                        "\tNFe_produtos_servicos_cofins.S08_pCOFINS as ALIQ_COFINS,\n" +
                                        "\tNFe_produtos_servicos_cofins.S09_qBCProd as QUANT_BC_COFINS,\n" +
                                        "\tNFe_produtos_servicos_cofins.S10_vAliqProd as ALIQ_COFINS_QUANT,\n" +
                                        "\tNFe_produtos_servicos_cofins.S11_vCOFINS as VL_COFINS,\n" +
                                        "\tnfe.IDPC_Gestao as COD_CTA\n" +
                                        "from NFe_produtos_servicos\n" +
                                        "\tinner join nfe on nfe.ID = NFe_produtos_servicos.IDNota\n" +
                                        "\tinner join NFe_produtos_servicos_icms on NFe_produtos_servicos.ID = NFe_produtos_servicos_icms.IDNFeItem\n" +
                                        "\tinner join NFe_produtos_servicos_ipi on  NFe_produtos_servicos.id = NFe_produtos_servicos_ipi.IDNFeItem\n" +
                                        "\tinner join NFe_produtos_servicos_pis on NFe_produtos_servicos_pis.ID = NFe_produtos_servicos_ipi.IDNFeItem\n" +
                                        "\tinner join NFe_produtos_servicos_cofins on NFe_produtos_servicos_pis.ID = NFe_produtos_servicos_cofins.IDNFeItem\n" +
                                        "where nfe.B09_dhEmi between '{@@dataini}' and '{@@datafim}' and nfe.IDMultiEmpresa = {@@IDEmpresa} and (nfe.Emitida = 1 or nfe.B11_tpNF = 0);";
}