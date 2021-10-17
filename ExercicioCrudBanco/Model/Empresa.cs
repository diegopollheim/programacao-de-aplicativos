using ExercicioCrudBanco.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCrudBanco.Model
{
    public class Empresa
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string EndLogr { get; set; }
        public string EndNum { get; set; }
        public string EndCid { get; set; }
        public string EndUF { get; set; }
        public string Telefone { get; set; }

        public Empresa(int id, string razaoSocial, string nomeFantasia, string cnpj, string endLogr, string endNum, string endCid, string endUf, string telefone)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            CNPJ = cnpj;
            EndLogr = endLogr;
            EndNum = endNum;
            EndCid = endCid;
            EndUF = endUf;
            Telefone = telefone;
        }

        public Empresa()
        {
        }

        public bool Gravar()
        {
            EmpresaController empresaController = new EmpresaController();
            return empresaController.Gravar(this);
        }

       
    }
}
