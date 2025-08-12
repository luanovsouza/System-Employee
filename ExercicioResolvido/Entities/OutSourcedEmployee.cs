namespace ExercicioResolvido.Entities;

public class OutSourcedEmployee : Employee
{
    public double AdditionalCharge { get; set; }


    public OutSourcedEmployee()
    {
    }

    public OutSourcedEmployee(string? name, int hours, double valuePerHour, double additionalcharge) 
        : base(name, hours, valuePerHour)
    {
        AdditionalCharge = additionalcharge;
    }

    public override double Payment()
    {
        double basepayment = base.Payment(); //Pegando o retorno do, calculo do pagamento do funcionário padrão 
        double aditional = AdditionalCharge * 1.1; // Fazendo o calculo de 110%
        
        return basepayment + aditional; //Retornando a conta do salário mais o bonus
    }
}