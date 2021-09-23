using System;

class Assignment4
{
    public static void Main(string[] arg)
    {
        int total = 0, count = 0, even = 0, zero = 0;
        var range=GetRange(arg[0], arg[1]);
      //  Console.WriteLine(range);
        if (range.min != range.max)
        {
            Int64 counter = 0;
            decimal midpoint = (range.max + range.min) / 2.0m;
            decimal avg = 0;
            bool loop = true;
            while (loop)
            {
                var random = Get5Random(range.min, range.max, out even, out zero, ref total, ref count);
                string randomStr = Convert.ToString(random);
                avg = Math.Round(Decimal.Divide(total, count)*1.00000m, 5);
                counter += 1;
                if (midpoint <= avg)
                    loop = false;
                Console.WriteLine(randomStr.Substring(1, randomStr.Length - 2) + "   ev: " + even + "   od: " + (5 - zero - even) +
                    "   ze: " + zero + "   accu_sum: " + total + "   accu_count: " + count + "   avg = " + avg + "  "+(loop? "<":">=")+"  " + "midpoint  " + midpoint + " (" + counter + ")");
            }
        }
    }

    static (int min, int max) GetRange(in string num1, in string num2)
    {
        int x=0, y=0;
        if (int.TryParse(num1, out x) && int.TryParse(num2, out y) && (x != y))
        {
            if (x > y)
                return (y, x);
            else
                return (x, y);
        }
        else
            return (-1, -1);
    }

    static (int r1, int r2, int r3, int r4, int r5) Get5Random(in int begin, in int end, out int even, out int zero, ref int sum, ref int count)
    {
        int[] nums = new int[5];
        even = 0;
        zero = 0;
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            nums[i] = random.Next(begin, end);
            EvenOrZero(nums[i], ref even, ref zero);
            sum += nums[i];
        }
        count += 5;
        return (nums[0], nums[1], nums[2], nums[3], nums[4]);
    }
    static void EvenOrZero(int number, ref int e, ref int z)
    {
        if (number == 0)
            z += 1;
        else if (number % 2 == 0)
            e += 1;
    }
}