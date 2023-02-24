using System;
namespace  Atividade
{
   class Program
   {
    static void Main (string[]args)
    {
        float val_pag;
        Console.WriteLine ("Infome o Nome.........:");
        String var_nome = Console.ReadLine();

        Console.WriteLine ("Informe a data de nascimento....");
        String var_data_nascimento = Console.ReadLine();

        Console.WriteLine("Pessoa fisica (f) ou Pessoa Juridica (j)");
        String var_tipo = Console.ReadLine();

        if (var_tipo == "f")
        {
            Pessoa_Fisica pf = new Pessoa_Fisica();
            pf.nome = var_nome;
            pf.data_nascimento = var_data_nascimento;

            Console.WriteLine ("Informe o CPF");
            pf.cpf = Console.ReadLine();

            Console.WriteLine ("Informa o valor do salario");
            val_pag = float.Parse (Console.ReadLine());
            pf.Pagar_Imposto(val_pag);    

            Console.WriteLine ("=======Pessoa Física=========");
            Console.WriteLine ("Nome...........:" + pf.nome);
            Console.WriteLine ("Data de Nascimento..." + pf.data_nascimento);
            Console.WriteLine("CPF................" + pf.cpf);
            Console.WriteLine("Valor Salário" + pf.valor.ToString("C"));
            Console.WriteLine("Imposto...........:" + pf.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Receber ...." + pf.total.ToString("C"));
            
        } else {
            if (var_tipo = "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica ();
                pj.nome = var_nome;
                pj.data_nascimento = var_data_nascimento;

                Console.WriteLine("Informe o número do CNPJ.....:");
                pj.cnpj = Console.ReadLine ();

                Console.WriteLine("Informe o valor do salário....:");

                val_pag = float.Parse (Console.ReadLine());
                pf.Pagar_Imposto(val_pag); 

                Console.WriteLine("========Pessoa Jurídica======");
               
            Console.WriteLine ("Nome...........:" + pj.nome);
            Console.WriteLine ("Data de Nascimento..." + pj.data_nascimento);
            Console.WriteLine("CPF................" + pj.cnpj);
            Console.WriteLine("Valor Salário" + pj.valor.ToString("C"));
            Console.WriteLine("Imposto...........:" + pj.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Receber ...." + pj.total.ToString("C"));
                

            }



            
        }
    }
   } 
}
