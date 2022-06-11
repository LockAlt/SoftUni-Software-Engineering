using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //Console.WriteLine(a/ 2);// 2
            //Console.WriteLine(a*1.0 /2 ); //2.5    // В Console.Write могат да се правят изчисления
            //Console.WriteLine(a/2.0);// 2.5  


            //int a = 5;
            //a = a + 1; //Добавя 1 единица към а 
            //a += 1; //Добавя 1 единица към а 
            //a++; //Добавя 1 единица към а ; // а++++; не става само 1 единица може
            // ++а  //Добавя 1 единица

            //Console.WriteLine(++a);// Получаваме 6
            //Console.WriteLine(a++); // Получаваме 5 ако ++ са отзад при такава проверка като cw

            //int a = 5;
            // a-=1 // Изважда 1 единица от а
            //a--; // Изваждаме 1 единица
            //--a; // Изваждаме 1 единица обаче има разлика м/у двете като горе с плюсовете

            //int a = 5;
            //Console.WriteLine(a++ + ++a);// 5 + 7 = 12




            // Give me 5 waffles


            //for (int counter = 0; counter <= 5; counter++) // shte izprinti 6 puti // Tozi counter e promenliva kato 'i' po-dolu koeto se izpolzva poprincip v for cikal
            //{
            //    Console.WriteLine("Waffle");
            //}

            // for (int counter = 0; counter < 5; counter++) // shte izprinti 5 puti zashtoto primerno stiga do 4 valfi proverqva dali 4<5 i e vqrno sledovatelno dobavq 4+1 = 5 i togava proverqva dali 5<5 koeto e flase i spira programata
            // {
            //    Console.WriteLine("Waffle");
            // }


            //  for (int counter = 0; counter < 10; counter++) 
            //    {
            //    Console.WriteLine("Waffle"); // Otpechatvat se 10 vafli // Purvo imash 0 <10 True --> izpisva waffle -->counter++ --> 0+1 = 1 <10 true --> izpisva --> 1+1 = 2<10 --> 2+1 = 3<10 ...... 9<10 --> 9 + 1 = 10  i togava se proverqva oshte e din cikul 10<10 sledovatelno ne e i ne se otpechatva 11
            //    }


            //for(int a = 4; a <5; a++)
            //{
            //    Console.WriteLine("Waffle"); // Shte se izpirnti 1 put 
            //}

            //int numOfWaffles = int.Parse(Console.ReadLine()); // 3 vafli
            //for(int i = 0; i < numOfWaffles; i++) // !!  // Tova i e promenliva 
            //{
            //    Console.WriteLine("Waffles"); // 3 vafli
            //}


            //int numOfWaffles = int.Parse(Console.ReadLine()); // 3 vafli
            //for (int i = 1; i <= numOfWaffles; i++) // !!! vij otgore tozi red !!
            //{
            //    Console.WriteLine("Waffles"); // 3 vafli
            //}

            //int numOfWaffles = int.Parse(Console.ReadLine()); // 3 vafli
            //for (int i = 1; i < numOfWaffles; i++) // !!! vij otgore tozi red !!
            //{
            //    Console.WriteLine("Waffles"); // 2 vafli zashtoto pochva ot 1 i pri edno zavurtane ti otpechetva 1 vafla sledovatelno imame 2 zavurtaniq
            //}




            // Искаме да принтираме числата от 1 до 5
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i); // Printira 0,1,2,3,4 vsichko na nov red 
            //}


            //for (int i = 1; i <= 5; i++) // Purvo proverqva dali 1 <=5 sledovatelno e True i printira 1 posle dobavq 1 i stava 2 <=5 true --> printira 2 i tn
            //{
            //    Console.WriteLine(i); // Printira 1,2,3,4,5
            //}


            //int i = 1;
            //for (; i <=5;)
            //{
            //    Console.WriteLine(i);  // I taka stava
            //    i++;// I taka stava 
            //}


            //string text = "SoftUni"; // Imame 7 simvola
            //Console.WriteLine(text.Length);  // Tova ni dava duljinata na teksta a imenno 7


            //string text = "SoftUni is the best";
            //Console.WriteLine(text.Length); // Intervala sushto e simvol izlizat 19 simvola 

            //string text = "SoftUni"; // Imame 7 simvola // S- 0 poziciq , o - 1 poziciq i tn. // POZICIITE GI NARICHAME Index // zero-based index zashtoto zapochvat ot 0 // Simvolite = duljinata na stringa - 1 --> simvolite = 7-1 --> simvolite = 6

            //Console.WriteLine(text.Length);  // Tova ni dava duljinata na teksta a imenno 7

            //Console.WriteLine(text[6]); // Dai mi ot tozi text 6 simvol (i)

            //Console.WriteLine(text[0]);// Dai mi purviqt simvol (S)

            //Console.WriteLine(text[text.Length -1 ]);// Ako ne znaem kolko e dulga dumata i iskame posledniqt simvol (i) ( vij gornoto obqsnenie zashto e taka)


            //string text = Console.ReadLine(); // Hello there!  
            //Console.WriteLine(text[text.Length-1]); // Posledniqt simvol e ! (simvolite sa 11 )
            //Console.WriteLine(text.Length); // Duljinata e 12 

            //for (; ; ) // Infinity loop това е същото като for (; true ; )
            //{
            //    Console.Write("SoftUni");
            //}

            //for (int i = 1; i <= 3;)
            //{
            //    Console.Write(i); // Infinity loop
            //}

            //for (int i = 0; i < 2; i += 0.5) // Compile time error -> int i += 0.5 e double ne int 
            //{
            //    Console.Write(i + ", ");
            //}


            //for (double i = 0; i < 2; i += 0.5) // Това е вярно 
            //{
            //    Console.Write(i + ", ");
            //}

        }
    }
}