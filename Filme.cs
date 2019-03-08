using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoradeFilmes
{
    public class Filme
    {
        public String nome;
        public String dtLancamento;
        public String direcao;
        public String orcamento;
        public String nota;


        //----------------------------------------------- Getters -----------------------------------------------//

        public String getNome()
        {
            return this.nome;
        }

        public String getLacamento()
        {
            return this.dtLancamento;
        }

        public String getDirecao()
        {
            return this.direcao;
        }

        public String getOrcamento()
        {
            return this.orcamento;
        }

        public String getNota()
        {
            return this.nota;
        }


        //----------------------------------------------- Setters -----------------------------------------------//

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setLancamento(String dtLancamento)
        {
            this.dtLancamento = dtLancamento;
        }

        public void setDirecao(String direcao)
        {
            this.direcao = direcao;
        }

        public void setOrcamento(String orcamento)
        {
            this.orcamento = orcamento;
        }

        public void setNota(String nota)
        {
            this.nota = nota;
        }


        //----------------------------------------------- Status -----------------------------------------------//

        public void status()
        {
            Console.WriteLine("Nome: " + getNome());
            Console.WriteLine("Data de Lançamento: " + getLacamento());
            Console.WriteLine("Direção: " + getDirecao());
            Console.WriteLine("Orçamento: " + getOrcamento());
            Console.WriteLine("Nota: " + getNota() + "\n");
        }
    }
}
