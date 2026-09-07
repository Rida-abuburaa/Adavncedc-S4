namespace Adavncedc_S4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //1.	Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            List<int> numbers =  [ 85,92,78,95,88,70,100,65];
            //2.	Print the collection, Count, first and last grade
            foreach (int num in numbers)
            {
                Console.WriteLine(num);

            }
          
            Console.WriteLine($"the count number is {numbers.Count}");
            
            Console.WriteLine($"the first number is {numbers.First()}");
            Console.WriteLine($"the last number is {numbers.Last()}");
            //3.	Sort the grades ascending, then print
            numbers.Sort();
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
    
            }
            //4.	Get the first grade above 90
            Console.WriteLine($"the first grade Above 90  is {numbers.Find(num => num >90)}");
            //5.	Get all grades below 75 (failing grades)
            Console.WriteLine($"The first grade below 75 is {numbers.Find(num => num < 75)}");
            //6.	Remove all failing grades (below 75)
            numbers.RemoveAll(g => g < 75);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);

            }
            //7.	Check if any grade equals 100
            Console.WriteLine(numbers.Any(num => num == 100));

            //8.	Create a List<string> where each grade becomes "Grade: X"
            List<string> gradeNames = numbers.Select(num => $"Grade: {num}").ToList();

            Console.WriteLine(string.Join(", ", gradeNames));
            #endregion 

        }
    }
}
