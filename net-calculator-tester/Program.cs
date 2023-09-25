namespace net_calculator_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel nostro sistema di gestione del catalogo videogiochi");
            while (true)
            {
                Console.WriteLine("Scrivi 2 numeri interi e 2 numeri decimali. Eseguirò le seguenti operazioni:");
                Console.WriteLine("Scrivimi il primo numero intero:");
                int intNum1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Scrivimi il secondo numero intero:");
                int intNum2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Scrivimi il primo numero decimale:");
                double decNum1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Scrivimi il secondo numero decimale:");
                double decNum2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Seleziona l'opzione desiderata:");
                Console.WriteLine(@"
- 1: Somma di numeri interi
- 2: Sottrazione tra due numeri interi
- 3: Divisione tra due numeri interi
- 4: Moltiplicazione di due numeri interi
");

                int selectedOption = int.Parse(Console.ReadLine());

                switch (selectedOption)
                {

                    case 1:
                        {
                        //----------------------------SOMMA----------------------------------
                            Console.WriteLine("Somma di numeri interi:");
                            int result1 = CalcoliHelper.Calculate2NumSum(intNum1, intNum2);
                            Console.WriteLine($"La somma è: {result1}");
                            break;
                        }

                    case 2:
                        {
                        //----------------------------DIFFERENZA----------------------------------
                            Console.WriteLine("Sottrazione tra due numeri interi");
                            int result2 = CalcoliHelper.Calculate2NumDif(intNum1, intNum2);
                            Console.WriteLine($"La differenza è :{result2}");
                            break;
                        }

                    case 3:
                        {
                            //---------------------------DIVISIONE---------------------------------
                            Console.WriteLine("Divisione di numeri interi");
                            int result3 = CalcoliHelper.Calculate2NumDif(intNum1, intNum2);
                            Console.WriteLine($"La divisione è :{result3}");
                            break;
                        }
                    case 4:
                        {
                        //----------------------------MOLTIPLICAZIONE----------------------------------
                            Console.WriteLine("Moltiplicazione di numeri interi");
                            int result4 = CalcoliHelper.Calculate2NumMoltipl(intNum1, intNum2);
                            Console.WriteLine($"La moltiplicazione è :{result4}");
                            break;
                        }
                        
                }      
            }
        }
    }
}