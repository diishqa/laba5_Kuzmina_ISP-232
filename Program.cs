namespace laba5_Kuzmina_ISP_232
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers;
            //int[] nums = new int[4]; 
            //int[] nums2 = new int[4] { 1, 2, 3, 5 };
            //int[] nums3 = new int[] { 1, 2, 3, 5 };
            //int[] nums4 = new[] { 1, 2, 3, 5 };
            //int[] nums5 = { 1, 2, 3, 5 };
            //int[] num6 = [1, 2, 3, 5];
            //int[] numbers = [1, 2, 3, 5];
            //Console.WriteLine(numbers[3]);
            //var n = numbers[1];
            //Console.WriteLine(n);
            //numbers[1] = 505;
            //Console.WriteLine(numbers[1]);
            //int[] numbers = [1, 2, 3, 5];
            //Console.WriteLine(numbers[6]);
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers[numbers.Length-1]);
            //Console.WriteLine(numbers[numbers.Length - 2]);
            //Console.WriteLine(numbers[numbers.Length - 3]);
            //Console.WriteLine(numbers[^1]);
            //Console.WriteLine(numbers[^2]);
            //Console.WriteLine(numbers[^3]);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i =0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = numbers[i] * 2;
            //    Console.WriteLine(numbers[i]);
            //}
            //int i = 0;
            //while (i < numbers.Length)
            //{
            //    Console.WriteLine(numbers[i]);
            //    i++;
            //}
            //int[] nums1 = [0, 1, 2, 3, 4, 5];
            //int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };    //двухмерный массив
            //object[] student = ["Иван", "Игорь", 4, 4.6, 'с'];
            //student[4] = 4;
            //dynamic[] student2= ["Иван", "Игорь", 4, 4.6, 'с'];
            //student2[4] = 4;
            //Console.WriteLine(student[4].GetType());
            //Console.WriteLine(student2[4].GetType());
            //int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
            //int result = 0;
            //foreach (int number in  numbers)
            //{
            //    if (number > 0)
            //    {
            //        result++;
            //    }
            //}
            //Console.WriteLine($"Число элементов больше нуля: {result}");
            //for (int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] > 0)
            //    {
            //        result++;
            //    }
            //}
            //Console.WriteLine($"Число элементов больше нуля: {result}");
            //int i = 0;
            //while (i < numbers.Length)
            //{
            //    if (numbers[i]>0)
            //    {
            //        result++;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"Число элементов больше нуля: {result}");
            //int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
            //int n = numbers.Length;
            //int k = n / 2;
            //int temp;
            //for (int i = 0; i < k; i++)
            //{
            //    temp = numbers[i];
            //    numbers[i] = numbers[n - i - 1];
            //    numbers[n - i - 1] = temp;
            //}
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine($"{i} \t");
            //}

            //СОРТИРОВКА

            //int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
            //int temp;
            //for (int i=0; i<nums.Length-1;  i++)
            //{
            //    for (int j=i+1; j<nums.Length; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //}
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}
            //List<string> people = new List<string>();
            //List<string> people = [];
            //List<string> student = new List<string>()
            //{
            //    "Иван","Игорь", "Александр"
            //};
            //List<string> student = ["Иван", "Игорь", "Александр"];
            //List<string> student = ["Иван", "Игорь", "Александр"];
            //var yourStudent = new List<string>(student);
            //List<string> student = new List<string>(10);
            //List<string> student = new(10);
            //List<string> student = ["Билли", "Игорь", "Степан"];
            //string firstStudent = student[0];
            //Console.WriteLine(firstStudent);
            //student[0] = "Богдан";
            //Console.WriteLine(student[0]);
            //List<string> student = ["Билли", "Игорь", "Степан"];
            //Console.WriteLine(student.Count);
            //List<string> student = ["Билли", "Игорь", "Степан"];
            //foreach ( var person in student)
            //{
            //    Console.WriteLine(person);
            //}
            List<string> student = ["Билли", "Игорь", "Степан"];
            student.Add("Van");
            student.AddRange(["Антон", "Денис"]);
            student.Insert(1, "Кирилл"); //вставляет элемент по индексу
            student.InsertRange(1, ["Mike", "Kate"]);
            sudent.Insert(7, "Михаил");
            foreach(var person in student)
            {
                Console.WriteLine(person);
            }
            var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Al" };
            people.RemoveAt(1); //удаляется элемент по индексу
            people.Remove("Tom");
            people.RemoveRange(1, 2);
            people.Clear();









            Console.ReadLine();

        }
    }
}