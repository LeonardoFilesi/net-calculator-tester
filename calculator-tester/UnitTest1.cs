using net_calculator_tester;

namespace calculator_tester
{
    [TestFixture]
    public class CalculatorTestser
    {
 

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSomma()
        {
            // INPUT
            float x = 2;
            float y = 3;
            // OUTPUT ATTESO
            float outputAtteso = 5;
            // RICHIAMO FUNZIONE
            float outputReale = CalcoliHelper.Calculate2NumSum(x, y);   
            Assert.IsTrue(outputReale == outputAtteso);
        }
        [Test]
        public void TestSottrazione()
        {
            // INPUT
            float x = 2;
            float y = 3;
            // OUTPUT ATTESO
            float outputAtteso = -1;
            // RICHIAMO FUNZIONE
            float outputReale = CalcoliHelper.Calculate2NumDif(x, y);
            Assert.IsTrue(outputReale == outputAtteso);
        }
        [Test]
        public void TestDivisione()
        {
            // INPUT
            float x = 8;
            float y = 4;
            // OUTPUT ATTESO
            float outputAtteso = 2;
            // RICHIAMO FUNZIONE
            float outputReale = CalcoliHelper.Calculate2NumDivis(x, y);
            Assert.IsTrue(outputReale == outputAtteso);
        }
        [Test]
        public void TestMoltiplicazione()
        {
            // INPUT
            float x = 3;
            float y = 4;
            // OUTPUT ATTESO
            float outputAtteso = 12;
            // RICHIAMO FUNZIONE
            float outputReale = CalcoliHelper.Calculate2NumDivis(x, y);
            Assert.IsTrue(outputReale == outputAtteso);
        }
    }
}