using Mini.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Mini.Wcf
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IServiceMini
    {

        public void Executar(string origem, string destino)
        {
            var caminho = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            MinimizadorC.Minimatizar(new string[] {
                "/o=" + Path.Combine(caminho, origem),
                "/d=" + Path.Combine(caminho, destino)
            });
        }
    }
}
