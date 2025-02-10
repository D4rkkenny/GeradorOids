using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SnmpSharpNet;

namespace GeradorOids
{
    internal class OidBusca
    {
        public string ip { get; set; }
        string community = "public";
        int port = 161;
        public string caminhoArquivo { get; set; }

        public OidBusca(string ip, string caminhoArquivo)
        {
            this.ip = ip;
            this.caminhoArquivo = caminhoArquivo + "//Oids.txt";
        }

        public void Busca()
        {
            UdpTarget target = new UdpTarget(new System.Net.IPAddress(System.Net.IPAddress.Parse(ip).GetAddressBytes()), port, 2000, 1);
            OctetString communityString = new OctetString(community);

            // Configuração da PDU para a consulta
            Pdu pdu = new Pdu(PduType.GetBulk);
            pdu.VbList.Add(new Oid("1.3.6.1")); // OID raiz
            pdu.MaxRepetitions = 10; // Número de OIDs por solicitação

            // Configuração da versão SNMP
            AgentParameters param = new AgentParameters(communityString)
            {
                Version = SnmpVersion.Ver2
            };

            Console.WriteLine("Iniciando SNMP Walk...");
            try
            {
                Oid lastOid = null; // Para evitar loops infinitos

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    while (true)
                    {
                        // Envia a solicitação SNMP
                        SnmpV2Packet response = (SnmpV2Packet)target.Request(pdu, param);

                        // Verifica se a resposta é válida
                        if (response == null || response.Pdu.ErrorStatus != 0)
                        {
                            Console.WriteLine("Fim do SNMP Walk ou erro na consulta.");
                            break;
                        }

                        // Itera sobre os resultados
                        foreach (Vb vb in response.Pdu.VbList)
                        {
                            // Escreve o OID e valor no arquivo texto
                            string line = $"OID: {vb.Oid}, Valor: {vb.Value}";
                            writer.WriteLine(line);
                            Console.WriteLine(line);

                            // Verifica se chegamos ao fim da árvore OID
                            if (vb.Value == null || vb.Value.ToString() == "NoSuchObject" || vb.Value.ToString() == "End of MIB View")
                            {
                                Console.WriteLine("Fim da árvore OID.");
                                return;
                            }
                        }

                        // Obtem o último OID retornado
                        Oid currentOid = response.Pdu.VbList[response.Pdu.VbList.Count - 1].Oid;

                        // Verifica se o último OID retornado é o mesmo que o anterior
                        if (lastOid != null && lastOid.Equals(currentOid))
                        {
                            Console.WriteLine("OID repetido detectado. Finalizando.");
                            break;
                        }

                        // Ajusta o próximo OID para a consulta
                        pdu.VbList.Clear();
                        pdu.VbList.Add(new Vb(currentOid));
                        lastOid = currentOid; // Atualiza o último OID
                    }
                }

                Console.WriteLine($"SNMP Walk concluído. OIDs salvos em '{caminhoArquivo}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                target.Close();
            }
        }
    }
}
