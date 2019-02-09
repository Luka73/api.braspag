using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entities;
using Project.Entities.Enum;

namespace Project.Service
{
    public class MockMDR
    {
        public List<MDR> ListaMDR()
        {
            List<MDR> lista = new List<MDR>();

            #region AdquirenteA
            var mdrA = new MDR();
            mdrA.Adquirente = Adquirente.A;

            mdrA.Taxas = new List<Taxas>();

            Taxas taxa1A = new Taxas();
            taxa1A.Bandeira = Bandeira.Visa;
            taxa1A.Credito = 2.25m;
            taxa1A.Debito = 2.00m;
            mdrA.Taxas.Add(taxa1A);


            Taxas taxa2A = new Taxas();
            taxa2A.Bandeira = Bandeira.Master;
            taxa2A.Credito = 2.35m;
            taxa2A.Debito = 1.98m;
            mdrA.Taxas.Add(taxa2A);

            lista.Add(mdrA);
            #endregion

            #region AdquirenteB
            var mdrB = new MDR();
            mdrB.Adquirente = Adquirente.B;

            mdrB.Taxas = new List<Taxas>();

            Taxas taxa1B = new Taxas();
            taxa1B.Bandeira = Bandeira.Visa;
            taxa1B.Credito = 2.50m;
            taxa1B.Debito = 2.08m;
            mdrB.Taxas.Add(taxa1B);


            Taxas taxa2B = new Taxas();
            taxa2B.Bandeira = Bandeira.Master;
            taxa2B.Credito = 2.65m;
            taxa2B.Debito = 1.75m;
            mdrB.Taxas.Add(taxa2B);

            lista.Add(mdrB);
            #endregion

            #region AdquirenteC
            var mdrC = new MDR();
            mdrC.Adquirente = Adquirente.C;

            mdrC.Taxas = new List<Taxas>();

            Taxas taxa1C = new Taxas();
            taxa1C.Bandeira = Bandeira.Visa;
            taxa1C.Credito = 2.75m;
            taxa1C.Debito = 2.16m;
            mdrC.Taxas.Add(taxa1C);


            Taxas taxa2C = new Taxas();
            taxa2C.Bandeira = Bandeira.Master;
            taxa2C.Credito = 3.10m;
            taxa2C.Debito = 1.58m;
            mdrC.Taxas.Add(taxa2C);

            lista.Add(mdrC);
            #endregion

            return lista;
        }
    }
}
