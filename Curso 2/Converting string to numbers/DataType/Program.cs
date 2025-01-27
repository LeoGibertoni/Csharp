namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textIdade = "-23";
            int idade = Convert.ToInt32(textIdade);
            Console.WriteLine(idade);   


            string textNumeroGrande = "100000000000";
            long numeroGrande = Convert.ToInt64(textNumeroGrande);
            Console.WriteLine(numeroGrande);

            string textNegative = "-55,2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecisao = "5,000001";
            float precisao = Convert.ToSingle(textPrecisao);
            Console.WriteLine(precisao);

            string textMoney = "14,99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
