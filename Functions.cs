using System;
using System.Linq;
using System.Collections.Generic;

namespace lab_basics
{
    public class Functions
    {
        public static List<object> GetIntegersFromList(IEnumerable<object> list)
        {
            var ints = list.Where(x => x is int).ToList();
            return ints;
        }
        
        public static string first_non_repeating_letter(string input)
        {
            string lowCase = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if ((lowCase.Replace(lowCase[i].ToString(), "  ").Length - lowCase.Length) == 1)
                    return input[i].ToString();
                lowCase = input.ToLower();
            }

            return "";
        }

        public static int DigitalRoot(int number)
        {
            while (true)
            {
                int sum = 0;
                while (number % 10 > 0)
                {
                    sum = (number % 10) + sum;
                    number = number / 10;
                }

                if (sum / 10 > 0)
                {
                    number = sum;
                    continue;
                }

                return sum;
            }
        }

        public static int CountPairs(int[] arr, int target)
        {
            int pairs = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (i != j && arr[i] + arr[j] == target)
                        pairs++;
                }
            }

            return pairs;
        }

        public static string SortFriends(string friends)
        {
            List<string> friendList = new List<string>();
            foreach (string person in friends.ToUpper().Split(';'))
            {
                var temp = person.Split(':').Reverse();
                friendList.Add(string.Join(", ", temp));
            }

            friendList.Sort();
            return '(' + string.Join(")(", friendList) + ')';
        }

        public static int NextBiggerNumber(int number)
        {
            int nextBigger = -1;
            var numbers = number.ToString().ToList();
            for (int i = numbers.Count - 2; i >= 0; --i)
            {
                if (numbers[i] >= numbers[i + 1]) continue;
                var rightPart = numbers.GetRange(i + 1, numbers.Count - i - 1);
                numbers.RemoveRange(i + 1, numbers.Count - i - 1);
                rightPart.Sort();
                for (var j = 0; j < rightPart.Count; ++j)
                {
                    if (rightPart[j] <= numbers[i]) continue;
                    var temp = numbers[i];
                    numbers[i] = rightPart[j];
                    rightPart[j] = temp;
                    string joined = numbers.Concat(rightPart).Aggregate("", (current, num) => current + num);
                    int.TryParse(joined, out nextBigger);
                    i = 0;
                    break;
                }
            }
            return nextBigger;
        }
        
        public static string NumToIpv4(uint number)
        {
            string binary = Convert.ToString(number, 2);
            if(binary.Length < 32) 
                binary = binary.PadLeft(32, '0');
            int[] arr = new int[4];
            for (int i = 0; i < 4; i++)
                arr[i] = Convert.ToInt32(binary.Substring(i * 8, 8), 2);
            return arr.Aggregate("", (full, part) => $"{full}.{part}").Trim('.');
        }
    }
}