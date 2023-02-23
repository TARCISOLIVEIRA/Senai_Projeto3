namespace Atividade
{
    class Clientes
    {
      public string nome { get ; set;}
    public string data_nascimento { get; set;}
    public float valor { get; protected set;}
    public float valor_imposto {get; protected set;}
    public float total { get; protected set;}

    public virtual void Pagar_Imposto(float v)
    {
        this.valor = v;
        this.valor_imposto = this.valor * 8/100;
        this.total = this.valor - valor_imposto; 

   }   
    }
}