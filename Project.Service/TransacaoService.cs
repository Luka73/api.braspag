using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entities;
using Project.Entities.Enum;

namespace Project.Service
{
    public class TransacaoService
    {
        public TotalLiquido CalculaTotalLiquido(Transacao transacao)
        {
            decimal percentual = ObterPercentualDesconto(transacao);
            TotalLiquido totalLiquido = new TotalLiquido();
            string temp = (transacao.Valor - (transacao.Valor * (percentual / 100))).ToString("N2");
            totalLiquido.ValorLiquido = Convert.ToDecimal(temp);
            return totalLiquido;
        }

        private decimal ObterPercentualDesconto(Transacao transacao)
        {
            var lista = MockMDR.ListaMDR();
            decimal valor = 0;

            foreach(var item in lista)
            {
                if(item.Adquirente == transacao.Adquirente.ToString())
                {
                    foreach(var item2 in item.Taxas)
                    {
                        if(item2.Bandeira == transacao.Bandeira.ToString())
                        {
                            valor = (transacao.Tipo == TipoTransacao.Credito) ? item2.Credito : item2.Debito;
                        }
                    }
                }
            }
            return valor;
        }
    }
}
