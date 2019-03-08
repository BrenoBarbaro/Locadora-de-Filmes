using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoradeFilmes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Filme f1 = new Filme();
            f1.setNome("Cães de Aluguel");
            f1.setLancamento("4 de junho de 1993");
            f1.setDirecao("Quentin Tarantino");
            f1.setOrcamento("1,2 milhão USD");
            f1.setNota("4,4");

            Filme f2 = new Filme();
            f2.setNome("A noviça rebelde");
            f2.setLancamento("3 de maio de 1965");
            f2.setDirecao("Robert Wise");
            f2.setOrcamento("8,2 milhões USD");
            f2.setNota("4,6");

            Filme f3 = new Filme();
            f3.setNome("A Forma da Água");
            f3.setLancamento("1 de fevereiro de 2018");
            f3.setDirecao("Guillermo del Toro");
            f3.setOrcamento("20 milhões USD");
            f3.setNota("4,1");

            Filme f4 = new Filme();
            f4.setNome("Vingadores: Guerra Infinita");
            f4.setLancamento("26 de abril de 2018");
            f4.setDirecao(" Anthony Russo, Joe Russo");
            f4.setOrcamento("300 milhões USD");
            f4.setNota("4,7");

            Filme f5 = new Filme();
            f5.setNome("Forrest Gump: O Contador de Histórias");
            f5.setLancamento("7 de dezembro de 1994");
            f5.setDirecao("Robert Zemeckis");
            f5.setOrcamento("55 milhões USD");
            f5.setNota("4,7");

            Filme f6 = new Filme();
            f6.setNome("Que horas ela volta?");
            f6.setLancamento("2015");
            f6.setDirecao("Anna Muylaert");
            f6.setOrcamento("4 milhões USD");
            f6.setNota("4,5");

            Filme f7 = new Filme();
            f7.setNome("Star Wars: O Despertar da Força");
            f7.setLancamento("7 de dezembro de 2015");
            f7.setDirecao("J. J. Abrams");
            f7.setOrcamento("200 milhões USD");
            f7.setNota("4,5");

            Filme f8 = new Filme();
            f8.setNome("O sexto sentido");
            f8.setLancamento("22 de outubro de 1999");
            f8.setDirecao("M. Night Shyamalan");
            f8.setOrcamento("55 milhões USD");
            f8.setNota("4,6");

            Filme f9 = new Filme();
            f9.setNome("Intocáveis");
            f9.setLancamento("31 de agosto de 2012");
            f9.setDirecao("Olivier Nakache, Éric Toledano");
            f9.setOrcamento("€ 9.5 milhões EUROs");
            f9.setNota("4,7");

            Filme f10 = new Filme();
            f10.setNome("Curtindo a vida adoidado");
            f10.setLancamento("19 de dezembro de 1986");
            f10.setDirecao("John Hughes");
            f10.setOrcamento("5,8 milhões USD");
            f10.setNota("4,6");

            Filme f11 = new Filme();
            f11.setNome("Procurando Nemo");
            f11.setLancamento("4 de julho de 2003");
            f11.setDirecao("Andrew Stanton");
            f11.setOrcamento("94 milhões USD");
            f11.setNota("4,6");

            Filme f12 = new Filme();
            f12.setNome("O silêncio dos inocentes");
            f12.setLancamento("17 de maio de 1991");
            f12.setDirecao("Jonathan Demme");
            f12.setOrcamento("19 milhões USD");
            f12.setNota("4,6");

            Console.WriteLine("---- Lista de Filmes ----\n");
            f1.status();
            f2.status();
            f3.status();
            f4.status();
            f5.status();
            f6.status();
            f7.status();
            f8.status();
            f9.status();
            f10.status();
            f11.status();
            f12.status();

            Console.ReadKey();
        }
    }
}
