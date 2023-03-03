namespace ClassLibrary1
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(numbers == "") 
                return 0;
            if(numbers.Length > 1)
            {
                int sum = 0;
                string[] splitNumbers = numbers.Split(',', '\n');
                foreach (var splitNumber in splitNumbers)
                {
                    sum += int.Parse(splitNumber);
                }
                return sum;
            }
                
            return int.Parse(numbers);
        }
    }
}