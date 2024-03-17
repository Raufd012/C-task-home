
// task 1



//int a = 10;

//if (a > 15)
//{
//    Console.WriteLine("hava istidir");

//}
//else
//{
//    Console.WriteLine("hava soyuqdur");
//}



// task 2




//string month = "Fevral";

//if (month == "Yanvar" || month == "mart" || month == "dekabr")
//{
//    Console.WriteLine(31);
//}
//else if (month == "Fevral")
//{
//    Console.WriteLine(29);
//}
//else if (month == "Aprel" || month == "Iyun")
//{
//    Console.WriteLine(30);
//}



// task 3



//int num = 5;
//int a = 1;

//if (num % 2 == 0)
//{
//    for (int i = 0; 0 < num; num--)
//    {
//        a *= num;
//    }
//    Console.WriteLine(a);
//}
//else
//{
//    Console.WriteLine("Tam eded deyil");
//}




// task 4




//int num;

//num = 19;


//if (num == 0 || num == 1)
//{
//}

//else
//{
//    for (int a = 2; a <= num / 2; a++)
//    {
//        if (num % a == 0)
//        {
//            Console.WriteLine("Eded Murekkebdir");
//            return;
//        }

//    }
//    Console.WriteLine("Eded Sadedir");

//}




// task 5




//int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int sum = 0;

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 != 0)
//    {
//        sum += num[i];
//    }

//}
//Console.WriteLine(sum);




// task 6




//int[] num = { 9, 88, 69, 72, 99, 102, 306, 893, 1098 };

//int min = num[0];

//int max = num[0];

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] < min)
//    {
//        min = num[i];
//    }
//    if (num[i] > max)
//    {
//        max = num[i];
//    }
//}
//Console.WriteLine(max);




// task 9



//int num = 312;

//int a = 0;

//while (num % 10 != 0)
//{
//    a = (num % 10) + a;
//    num /= 10;
//}
//Console.WriteLine(a);




// task 10




//int[] num = { 1, 3, 5, 7, 9, 12 };

//int min = num[0];

//int max = num[0];

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] < min)
//    {
//        min = num[i];
//    }
//    if (num[i] > max)
//    {
//        max = num[i];
//    }
//}

//Console.WriteLine(min);




// task 11


//int[] num = { 3, 9, 11, 29, 89, 92, 102, 333, 420 };

//int count = 0;

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 10 == num[i])
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);



// task 12



//int num = 98;

//if (num % 10 > num / 10)
//{
//    Console.WriteLine("Teklikler boyukdur");
//}
//else if (num % 10 == num / 10)
//{
//    Console.WriteLine("Beraberdir.");
//}
//else if (num % 10 < num / 10)
//{
//    Console.WriteLine("Onluqlar boyukdur");
//}



// task 14





//int num = 1234;
//int count = 0;

//while (num % 10 != 0)
//{
//    count++;
//    num /= 10;
//}

//Console.WriteLine(count);



// task 15



//int num = 1234;

//int a = 7 * 100000 + num * 10 + 8;

//Console.WriteLine(a);


// task 16


//int num = 123;

//int a = num + num * 1000;

//Console.WriteLine(a);



// task 17





//int num = 123;

//int a = (num * 10 + 7) * 7 / 100;

//Console.WriteLine(a);



//task 18





//int num = 8;

//if (num % 2 == 0)
//{
//    Console.WriteLine("Cut ededdir");
//}

//if (num % 2 == 1)
//{
//    Console.WriteLine("Tek ededdir");
//}



//task 19




//int num = 42;

//if (num % 21 == 0)
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}




//task 20





//int a = 30;

//int b = 60;

//if (a > b)
//{
//    Console.WriteLine(a);
//}
//else
//{
//    Console.WriteLine(b);
//}



// task 21 




//string[] num = { "AB106", "AB107", "AB109", "AZ986" };

//for (int i = 0; i < num.Length; i++)
//{
//    if (arr[i] == "AB106")
//    {
//        Console.WriteLine("Var");
//    }
//    else if (num[i] != "AB106")



//    {
//        Console.WriteLine("Yoxdur");
//    }
//}





// home task 1






//int[] num1 = { 3, 5, 7, 8, 11, 34, 54, 67 };

//int[] num2 = { 7, 5, 56, 45, 76, 3, 57, 34 };

//int num = 0;

//for (int i = 0; i < num2.Length; i++)
//{
//    for (int j = 0; j < num1.Length; j++)
//    {
//        if (num2[i] == num1[j])
//        {
//            num = num2[i];
//            Console.WriteLine(num);

//        }
//    }
//}





//home task 2

int[] num = new int[] { 9, 7, 11, 8, 2, 34, 3 };
Console.WriteLine("Siralanmis array");
Array.Sort(num);
foreach (int i in num)
{
    Console.Write(i + " ");
}




