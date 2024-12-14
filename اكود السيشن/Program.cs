using System;
using System.Text;

namespace اكود_السيشن
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region string vs stringBulider
            //String غير قابل لتغيير(Immutable)  ,, StringBuilder.قابل للتعديل داخل نفس الكائن.

            //value type بتعامل معامله ال refrence type string تعتبر
            //string name1;
            //string من نوع  refrence type كده انا عملت 
            //stack >> 4byte for string هط ف ال
            //defult value > null فاضي وال heap لحد دلوقتي ال
            //name1 = new string("Hamada");  // Xplicit Object Creation

            //string من نوع  object  كده عملت   
            //object بتاع ال byteال heab دلوقتي هحط ف ال
            // 1 charcetr = 2 byte >> hamada = 6 char = 12 byte at heab
            //object شايل قيمه ال stack هخلي بقا ال

            //suger stntax وده اسمو  assign value > =  ب اني هحط قيمته ب  srting ممكن اعمل
            //string name2 = ("Adel"); //suger stntax --String Literal Initializatio
            //name2 = name1;
            //name1 = ("omar");
            //Console.WriteLine($"name 1 is {name1}");// omar 
            //Console.WriteLine($"name 2 is {name2}");// hamada
            //هما مش المفرةض بيساوو بعض ؟؟ ازتاي دي طالعخ ب قيمه ودي ب قيمه !!هق,لك ليه
            //مش بيسمع ةلا بيعترف ب اي تغيير immutable يعتبر string  
            //اصلا name1  اللي هي قيمهomar جديد عشان يحط فيه قيمه object  هو كده يعتبر عمل

            //--------------------------------------------------
            //نشوف  مثال تاني نتاكد منو

            //string message = "hello";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            //؟ اه خلاص انا هزو عليها حاجه string >> array of character مش
            //message += " route";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            //المفروض بقا يطبعلي الاتنين مع بعض 
            //جديد ب هاش كود مختلف object لا هو عملي دي لوجدها ب هاش كود ود لوحدها ف
            // طب يم انا عايز اطع الاتنين فنفس الماسدج الكلام دا موش حل

            //------------------------------------------------------------------------------

            //// string Bulider

            //StringBuilder sb = new StringBuilder("hello");
            //Console.WriteLine(sb);//hello
            //sb.Append(" dear student");// append >> للاضافه
            //Console.WriteLine(sb); //hello dear student
            ////---------------------------------------------------
            //Console.WriteLine("--------------------------------------------------"); 
            //sb.AppendLine();// نص مع سطر جديد
            //sb.Append("I hope to be fine !");// هيحط الكلمه دي ف سطر جديد
            //Console.WriteLine(sb);//hello dear student
            //                      //I hope to be fine!
            ////---------------------------------------------------
            //Console.WriteLine("--------------------------------------------------");
            //sb.Insert(0, "ooh: ");// اللي هتضاف ف اول الكلام ooh (at start << 0) إدخال نص في موقع معين.  
            //Console.WriteLine(sb);
            ////---------------------------------------------------
            //Console.WriteLine("--------------------------------------------------");
            //sb.Remove(0, 5); // (0)حذف 5 أحرف بدءا من الموقع  
            //// المسافه تعتبر حرف
            //Console.WriteLine(sb);
            ////---------------------------------------------------
            //Console.WriteLine("--------------------------------------------------");
            //sb.Replace("قديم", "جديد");//استبدال جزء من النص.
            //sb.Replace("hello", "welcome");
            //Console.WriteLine(sb);
            ////---------------------------------------------------
            //Console.WriteLine("--------------------------------------------------");
            ////Length: للحصول على طول النص الحالي أو تغييره.
            ////sb.Length = 0; // مسح النص بالكامل
            ////sb.Length = 5; // مسح النص بالكامل معادا او 5 حروف
            //Console.WriteLine(sb.Length);// هيجيب طول الكلام
            ////---------------------------------------------------
            //Console.WriteLine("--------------------------------------------------");





            #endregion

            #region Array 
            // (Data Structure)هي مصفوفة  هيكل بيانات
            //( ستخدم لتخزين مجموعة من العناصر المتشابهة(مثل الأعداد الصحيحة أو النصوص
            // fixed length >> يتم تحديد حجمها ولا يمكن تغييره 
            //Data Type جميع العناصر في المصفوفة تنتمي إلى نفس ال  
            // العد بيبدا عندي من صفر
            //array في ال  x+1كدا دا ترتيبه xلما اقول عايز العنصر اللي رقمه  
            //age[5] ->array كدا دا ترتيبه السادس ف 
            //array بتاعو رقم4 في ال  index لما اقول  العنصر الخامس كده دا ال 
            //هو عدد العناصر-1array اخر عنصر في ال 
            //int مثلا من نوع   declear array انشاء
            //int[] <-array القوس دا معناها ان دي  int[] num <-بتعتيarray لازم بعد القوس ادي اسم لل
            //int[] num = { };  <- بعدها احط = واعمل قوس مجموعه واحط فيه العناصر بتعتي


            #region One dimention array
            //int[] num;
            //array of int من نوع  refrence type كده انا عملت 
            //stack >> 4byte for int هيحط ف الclr 
            //defult value > null فاضي وال heap لحد دلوقتي ال
            //num = new int[3];//بتاعي هو 3 length  كده بقوله ال
            //Console.WriteLine(num[0]);//عشان اصلا معندي عناصر (defult 0) بقوله اطبعلي العنصر الاولاني مديني قيمه 
            //num[0] = 1;
            //num[1] = 3;
            //num[2] = 5;
            //Console.WriteLine(num[1]);// اطبع العنصر رقم 2
            //هو انا كل مره لازم اعمل كده ؟ لا طبعا بص معايا
            //int[] num2 = new int[3] {7,8,9};
            //Console.WriteLine(num2[2]);// اطبع العنصر رقم 3
            //// م دي صعبه برضو يعم
            ////اديلها قيم علي طول وهو هيفم length خلاص بص مش لازم تديها 
            //int[] num3 = new int[] { 7, 10, 15 };
            //Console.WriteLine(num3[2]);// اطبع العنصر رقم 3
            //// والله ؟ بترج صج سهلت عليا انت اي بقا 
            //-------------------------------------------

            // بص هقولك حاجه حلوه خالص مفيش احسن منها
            //int[] number = { 1, 5, 9, 7, 8, 2, 10};
            //// ,,  مفيش اسهل من كده اهو 
            ////length لو عايو اعرف ال
            //Console.WriteLine("lenth of array is " + number.Length);
            //Console.WriteLine("first num in array is " + number[0]); //بقوله اطبعلي العنصر الاولاني
            ////دا العدد اللي ف النص
            //int middle = number.Length / 2;
            //Console.WriteLine("middle num in array is " + (number[middle]));
            ////lenth-1 ->1-طب عايز اجيب اخر عنصر ف المصفوفه بيكون العدد 
            //int last = number.Length - 1;
            //Console.WriteLine("last num in array is " + (number[last]));
            ////one or twoهو array بتاع ال dimention  طب عشان اعرف نوع ال 
            //Console.WriteLine("type of dimention array is " + (number.Rank));//1
            ////arrayطب عايز بقا اعرض ال 
            //Console.Write("item in array is : ");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.Write($"{number[i]} ");
            //}
            //او
            //foreach (int i in number) Console.WriteLine(i);
            //-------------------------------------------------------

            // دي مش مرتبه ازاي ارتبها بقا  array طب ال
            //Array.Sort(number);//<-بتعتي arrayبديله اسم ال  
            //Console.Write("\nitem in array after sort is : ");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.Write($"{number[i]} ");
            //}
            //------------------------------------------------

            ////تانيهarray ل  array طب عشان انسخ العاصر من
            //int[] sub = { 5, 1, 9, 25, 2 };
            //int[] sub2 = new int[sub.Length]; //الجديده بقول اني هديها نفس طول القديمهarray هنا بحدد طول الv   
            //Array.Copy(sub, sub2, sub.Length);//بحدد هنسخ منين وبعدين لفين وبعدين الطول اللي عايز انسخو هنا حددت طول الاراي الاوليؤ كلها
            //Console.WriteLine(sub2[2]);
            //sub2[1] = 50; //غيرت قيمه تاني عنصر
            //Console.WriteLine(sub2[1]);
            #endregion

            #region two dimention array [ , ]
            //Columnsواعمده rows تستخدم لتمثيل البيانات في شكل صفوف  
            //colomn للاعمد rows  واحده للصفوف  loop 2 بعمل فيها 
            //[3 , 4]; // مصفوفة تحتوي على 3 صفوف و4 أعمدة [عدد الاعمده , عدد الصفوف]و
            //int مثلا من نوع   declear 2 darray انشاء
            //int[ , ] <- 2 d array [ ,  ] دا معناها ان دي  int [ , ] num <-بتعتيarray لازم بعد القوس ادي اسم لل
            //int[ . ] num = { (1,5) };  <- بعدها احط = واعمل قوس مجموعه واحط فيه العناصر بتعتي

            //int[,] numbers; // 2d array  بدون تحديد الحجم
            //int[,] numbers = new int[3 , 4]; // مصفوفة بـ 3 صفوف و4 أعمدة مدتهمش قيم تعال اطبع كده
            //Console.WriteLine(numbers[2 , 3]);// طبيعي هتطلع صفر
            //------------------------------------------------------------
            //string[,] names = new string[2, 3]
            //{
            //    // 0       1        2
            //    { "Ali", "Ahmed", "Sara" },    // الصف الأول في الترتيب هو 0
            //    { "Nada", "Hassan", "Mona" }  // الصف الثاني في الترتيب هو 1 
            //};
            //Console.WriteLine(names[0, 2]);//10
            //Console.WriteLine(names[2, 3]); // error لانها خارج النطاق
            //----------------------------------------------------------------------
            //int[,] num =
            //{
            //  // 0   1   2    3 
            //    {1 , 5 , 7 , 10 },// الصف الأول في الترتيب هو 0
            //    {2 , 3 , 4 ,15 },// الصف الثاني في الترتيب هو 1 
            //    {10 , 14 , 15 ,30 }//الصف الثالث في الترتيب هو 2
            //};// 3 row , 4 colomn
            //Console.WriteLine(num[0,3]);//10
            //Console.WriteLine(num[2,3]);//30
            ////size of array عشان اعرف ال
            //Console.WriteLine($"size of array is : {num.Length}");//12 .3row*4clomn = 12
            ////dimention عشان اعرف ال
            // Console.WriteLine($"dimention of array is : {num.Rank}");//2
            ////بتاع الصفوف length  عشان اعرف ال
            //Console.WriteLine($"size rows in array is : {num.GetLength(0)}");//3
            ////بتاع الاعمده length  عشان اعرف ال
            //Console.WriteLine($"size colomn in array is : {num.GetLength(1)}");//4

            // عشان اطبه العناصر اللي جوا الاراي هحتاج
            //colomn والتانيه الللي جواها للاعمده  rows اول واحده للصفوف  loop 2 بعمل فيها 

            //Console.WriteLine("item in array is");
            //for (int i = 0; i < num.GetLength(0); i++)// rows
            //{
            //    for (int j = 0; j < num.GetLength(1); j++) // colomn
            //    {
            //        Console.Write($"{num[i, j]} \t"); 
            //        // خد بالك انا طبعت جمله ال برنت ف الفور لوب التانبه
            //    } 
            //    Console.WriteLine();// دي عشان ينول سطر مش اكتر
            //}

            //---------------------------------------------------
            //// حلو الكلام طب لو عايزاخد م اليوزر بقا
            //int[,] marks = new int [2,4];
            ////بتاع الصفوف length  عشان اعرف ال
            //Console.WriteLine($"size rows in array is : {marks.GetLength(0)}");//2
            ////بتاع الاعمده length  عشان اعرف ال
            //Console.WriteLine($"size colomn in array is : {marks.GetLength(1)}");//4
            //for (int i = 0; i < marks.GetLength(0); i++)// هيلف ع عدد الصفوف
            //{
            //    Console.WriteLine($"Enter Student Number{i+1}"); //هيخليه يدخب رقم الطالب
            //    //بعد م تاخد رقم الطالب ال انت عايزو اابدا بقا خد الدرجه
            //    //تخلص colomnتاني غير لما بتاع ال  rowsبتاع for مش هخرج وارجع لل
            //     for (int j = 0; j < marks.GetLength(1); j++)//هيلف ع عدد الاعمده
            //    {
            //        //هبدا بق هنا اخد الدرجه بتاع الطالب
            //        Console.WriteLine($"Enter subject num{j+1}"); //هيخليه يدخب رقم الطالب
            //        marks[i,j]= int.Parse(Console.ReadLine());
            //    }
            //}
            ////input كل اللي فوق دا عشان اخد ال   
            ////هعمل جمله البرنت بقا برا الاتنين لوب دول خالص هعمل برضو 2لوب
            //for (int i = 0;i < marks.GetLength(0);i++)
            //{
            //    Console.WriteLine($"grade of student num is {i+1} ");

            //    for (int j = 0;j < marks.GetLength(1);j++)
            //        Console.WriteLine($"subject num  {j+1} is {marks[i, j]} ");
            //}





            #endregion

            #region judged array
            //لوحده array كل صف فيها يمكن أن يكون له عدد مختلف من الأعمدة وكل عنص بيتعامل كانو 
            //تانيه arrayكبيره جوها array كاني عامل
            //one dinention array with array has different size


            //int[][] num = new int[3][];// بقوله عندي 3صفوف بس لسا مش عارف حجمهم ايه
            //num[0] = new int[] { 1, 2, 3 };
            //num[1] = new int[] { 4, 5 };
            //num[2] = new int[] { 6 };
            //for (int i = 0; i < num.Length; i++)
            //{
            //    for (int j = 0; j < num[i].Length; j++)
            //        Console.Write($"{num[i][j]} ");  
            //        Console.WriteLine();
            //}



            #endregion

            #region MyRegion[Training]

            /* Ask the user to enter the number of items in an integer array

            Ask the user to enter the items of this array

            Find the smallest number in the array

            Find the greatest number in the array

            Calculate the average of the array*/

            //int ArraySize;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter the number of items in an integer array ");
            //    flag = int.TryParse(Console.ReadLine(), out ArraySize);
            //    //Console.WriteLine("Enter the number of items in an integer array ");

            //} while (!flag);
            //int[] number = new int [ArraySize];
            //for (int i = 0; i < ArraySize; i++)
            //{
            //    Console.Write($"Please enter the item {i + 1} for this array:");
            //    while (!int.TryParse(Console.ReadLine(), out number[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    }
            //}
            //Console.Write("Array is : ");
            //for (int i = 0;i < number.Length;i++)
            // Console.Write($"{number[i] } ");
            ////avarage عشان يحسب اكبر رقم واصغر رقم وال 
            //int sum = 0;
            ///*int smallest =0  ;*/
            //int smallest = int.MaxValue;// مشروحه تحت ليه عملتها كده
            //int greatest =0 ;
            //// هحتاج اعمل لوب عشان الف ع القين احسب المجموع والاصغر والاكبر 
            //foreach (int i in number)
            //{
            //    sum+= i;
            //    if (i < smallest)
            //          smallest = i;

            //    if (i > greatest)
            //        greatest = i;
            //}
            //double ava = sum /ArraySize;
            //Console.WriteLine($"\nsmallest number is : {smallest}");
            //Console.WriteLine($"greatest number is : {greatest}");
            //Console.WriteLine($"Avarage numbers is : {ava}");
            //// هو ليه مطلع اصغر قمه ب صفر رغم اني مدخلتش صفر ؟ لاني معررفه فوق ب صفر وهو مش لاقي رقم اصغر منو 
            ////smallest=int.maxvalue هنحلها ازاي هنخلي 
            ////اكبر قيمه ممكنه بحيث ان اي رقم هيدخل هيكون اصغر منها smallest اي دي يعم انا بقولخ خلي قيمه ال
            #endregion

            #endregion

            #region function(method)
            //دي بتساعدني اني اقسم الكود بتاعي لمجموعه وظايف صغيره كل وظيفه بتعمل حاجه
            //سهةله الصيانه ان لو عندي مشكله ف حته معينه اقدر اعرف فين المشكله منغير ما اعدي ع الكود كلو maintainability
            //بتنظملي الكود و بتخليني امنع التكرار
            //بستخدمها لما  بكون عارف اني محتاج استخدم  الكود دا ف حته تانيه مش مش هعد اعمل كوبي بيست كل شويه
            //اعاده الاسخدام reusability انا بكتبها مره واحده ةاندهلها بقا 

            //------------------------------------------------------------------------
            //مكونه من حاجتين functionال 
            //1-prototype مكون من
            //-----
            // 1.1 segneture 
            //ولا اي int , string , char  يعني الفنكشن هترجع اي << return type 
            //لازم يدل الاسم بتاعها هي بتعمل اي << name 
            // parametar
            //ومش شرط الفنكشن ترجع حاجه هي ممكن بتطبع بس  void >> مش هترجع حاجه
            //-----
            //1.2 body 
            // اي اللي جوا الفنكشن دي
            //-------

            //2-calling هنادي عليها فين 
            //مينفعش اكتب فنكش جوا فنكشن main بس مينفعش اكتبها جوا ال main اي فنكشن لازم انادي عليها جوا ال

            //--------------------------------------

            //عندي اراي عايز اطبع المتوسط بتاعها
            //double[] num = { 10, 4, 2, 4 };
            //double sum = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //}
            //double ava = sum / num.Length;
            //Console.WriteLine("avarage = " + ava);

            //طب لو عندي اراي تانيه وعايز اطبع المتوسط برضو 

            //double[] num2 = { 10, 20, 30, 40, 50 };
            //double summ = 0;
            //for (int i = 0; i < num2.Length; i++)
            //{
            //    summ += num2[i];
            //}
            //double ava2 = summ / num2.Length;
            //Console.WriteLine("avarage = "+ava2);

            //وانادي عليهاfunction  طب ما كده انا بكرر الكود ودا غلط
            //الحل هنا اني اعمل 

            //static void CalculateAverage(int[] num) // void معناها مش هيرجع حاجه
            //بعدين اديها الباراميتار اللي هي الحاجه اللي عيزاها عشان تشتغل وهنا هتكون اراي function دي وبدين ادي اسم  static voidبكتب 
            //بفتح بقا قوس مجموعه واحط الحاجه بتعتي 
            //static void CalculateAverage(int[] num)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //        sum += num[i];
            //    }
            //    int ava = sum / num.Length;
            //    Console.WriteLine("avarage = " + ava);
            //}
            ////اللي هدخلها array  هنا بحسب الحاجه اللي عايزها بناءا عال  a

            //int[] num = { 10, 20, 30 };
            //CalculateAverage(num);
            //------------------------------------------------------
            //// عايز اطبع حاجه عدد عين
            //static void print()
            //{
            //    for (int i = 0; i < 10; i++)

            //        Console.WriteLine("*");
            //}
            //// كده الفنكشن خلصت انادي بقا عليها
            //print(); // هيطبع * 10 مرات
            //-----------------------------------------------
            // هو لازم كل مره اطبع * مبنفع اغيرها ؟ ااه ينفع اني هبعت معاها براميتار
            //ولما اجي انادي اديها الحاجه اللي عايزها تطبع
            //static void printpattern ( string pattern)
            //{
            //    for (int i = 0; i < 10; i++)

            //        Console.WriteLine(pattern);
            //}
            //// كده الفنكشن خلصت انادي بقا عليها
            //printpattern("/"); // هيطبع / 10 مرات
            //---------------------------------------------------------
            //طب لاوم التزم بالعد كل مره ولا ينفع انا ادخله برضو ؟ لاينفع هديها براميتار للعد وابق  انادي عليه
            //static void printpattern(string pattern , int count)
            //{
            //    for (int i = 0; i < count; i++)// هتلف ع اد ما هدخلك

            //        Console.WriteLine(pattern);
            //}
            //// كده الفنكشن خلصت انادي بقا عليها
            //printpattern("/", 5); // هيطبع / 5 مرات
            // لازم التزم بترتيب البارميتار ونا بنادي
            //----------------------------------------------------------
            //بحيث ان لو اليوزر مدخلش حاجه ادخله انا defult value  طب انا عايز احط 
            //static void printpattern(string pattern, int count)
            //{
            //    for (int i = 0; i < count; i++)// هتلف ع اد ما هدخلك

            //        Console.WriteLine(pattern);
            //}
            // كده الفنكشن خلصت
            //defult value هعمل واحده لل 
            //static void printpatterndefult(string pattern = "*", int count = 10)
            // ده defult لو اليوزر دخل حاج غير دول خد بتوع اليوزر لو مدخلش حاجه منهم خد ال
            //body هحط نفس ال 
            //{
            //    for (int i = 0; i < count; i++)// هتلف ع اد ما هدخلك

            //        Console.WriteLine(pattern);
            //}
            // انادي بقا عليها
            //printpatterndefult("/", 5); // هيطبع / 5 مرات// passing by order
            //لازم التزم بترتيب البارميتار ونا بنادي

            //-------------------------------------------------

            //Console.WriteLine();
            //printpatterndefult(); //defult هيطبع * 10 مرات

            //-------------------------------------------------

            //Console.WriteLine();
            //printpatterndefult("-"); //defult هيطبع - 10 مرات

            //-------------------------------------------------

            //Console.WriteLine();
            //printpatterndefult(11); //كده ايرور لاني ملتومتش ب الترتيب invalid

            //-------------------------------------------------

            // طب يعم انا عايز انادي بترتيب مختلف ! خلاص يبقا ساعتها هتنادي ب حاجه تانيه
            //printpatterndefult(count : 5 , pattern : "/"); // هيطبع / 5 مرات// passing by name

            #endregion

            #region مثال النجوم اللي علي شكل مثلث
            //Console.WriteLine("Enter the height of the triangle:");
            //int height = int.Parse(Console.ReadLine()); // عايز يكون المثلث كام صف

            //// مثلث معدول
            //Console.WriteLine("Right-side up triangle :");
            //for (int i = 1; i <= height; i++) // يتحكم بعدد الصفوف
            //{
            //    for (int j = 1; j <= i; j++) // يتحكم بعدد النجوم في كل صف
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); // ينقل إلى السطر التالي
            //}

            //----------------------
            //طب لوالمثلث معووج
            //Console.WriteLine("Enter the height of the triangle:");
            //int height = int.Parse(Console.ReadLine()); // عايز يكون المثلث كام صف

            // مثلث معدول
            //Console.WriteLine("Upside down triangle :");
            //for (int i = height; i >= 1; i--) // يبدأ من الصف العلوي ويقل
            //{
            //    for (int j = 1; j <= i; j++) // يتحكم بعدد النجوم في كل صف
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); // ينقل إلى السطر التالي
            //}

            #endregion

            


        }
    }
}
