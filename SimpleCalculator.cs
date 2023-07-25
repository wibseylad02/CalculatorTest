
namespace CalculatorTest
{
    public class SimpleCalculator : ISimpleCalculator
    {
        // Note that overflows on the value of int simply roll round to the opposite end of the int value range 
        // without throwing an exception (e.g int.MaxValue + 1 takes you back to int.MinValue)
        public int Add(int start, int amount) => start + amount;

        public int Subtract(int start, int amount) => start - amount;
    }
}