namespace Atividade
{
    class Pesoa_Juridica : Clientes
    {
        public string cnpj {get; set;}

        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 12/100;
            this.total = this.valor - this.valor_imposto; 
        }
    }
}