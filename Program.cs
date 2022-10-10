// See https://aka.ms/new-console-template for more information



//მასივიდან დაბეჭდავს უარყოფითი რიცხვების რაოდენობას.



//Console.WriteLine("Enter numbers");

//int[] numbers = new int[] { 1, 2, 3, -4, -2, -100 };
//int negNum = 0;

//foreach (int number in numbers)

//{
//	Console.WriteLine(number);
//	if (number < 0)
//	{
//		negNum++;

//	}
//}


//Console.WriteLine("neg number is : " + negNum);








//Console.WriteLine("Enter numbers");

//int[] numbers = new int[] { 1, 2, 3, -4, -2, -100 };
//int negNum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < 0)
//    {
//        negNum++;

//    }
//}

//Console.WriteLine(negNum);




//დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივში უნიკალურ ელემენტებს( მაგ 1 1 1 2 2 3  4—> 1 2 3 4) მასივის შევსება როგორც გინდა მოახდინეთ.

//int[] numbers = new int[] { 1,3,5,3,6,5,-2,-2};


//for(int i = 0; i < numbers.Length; i++)
//{

//    bool isDuplicate = false;
//    for (int j = 0; j < i; j++)
//    {
//        if (numbers[i] == numbers[j])
//        {
//            isDuplicate = true;
//            break;
//        }
//    }

//    if (!isDuplicate)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}


//დაწერეთ პროგრამა რომელიც დაბეჭდავს მასივში მხოლოდ იმ ელემენტებს რომლებიც გვხვდება 1 ხელ.


//int[] numbers = new int[] { 1,3,4,5,3,4,5,9,9,9,9 };


//for (int i = 1; i <numbers.Length; i++)
//{
//    int a = 0;


//    for (int j = 1; j < i; j++)
//	{
//		if (numbers[i] == numbers[j])
//		{
//			a++;
//		}


//	}

//	if(a==1)
//	{
//		Console.WriteLine(numbers[i]);
//	}

//}



//დაწერეთ პროგრამა რომელიც კლავიატურიდან შეიყვანს ტექსტ და დაითვლის ტექსტში სიტყვების რაოდენობას. (პუნქტუაციური ნიშნების რაოდენობას, და მაღალი და დაბალი რეგისტრის სიმბოლოებს)

/*

int lowerCount = 0;
int upperCount = 0;
int punctCount = 0;
int spaceCount = 1;
string myStr=Console.ReadLine();

for (int i = 0; i < myStr.Length; i++)
{
    bool result = true;
    result = Char.IsPunctuation(myStr[i]);

    bool result2 = true;
    result2 = Char.IsLower(myStr[i]);

    bool result3 = true;
    result3 = Char.IsUpper(myStr[i]);


    if (result)
    {
        punctCount++;
    }

    if (result2)
    {
        lowerCount++;
    }

    if (result3)
    {
       upperCount++;
    }

    if (myStr[i]==' ')
    {
        spaceCount++;
    }

}

Console.Write($"Number of words in text: {spaceCount}");
Console.WriteLine();
Console.Write($"Number of punctuation mark: {punctCount}");
Console.WriteLine();
Console.Write($"Number of lowercase characters: {lowerCount}");
Console.WriteLine();
Console.Write($"Number of uppercase characters: {upperCount}");






*/




//დაწერეთ პროგრამა რომელიც ტექსტში დაითვლის ხმოვნებს/თანხმოვნებს.


/*
string str = Console.ReadLine().ToLower();
int vowel = 0;
int consonant = 0;
for(int i = 0; i < str.Length; i++)
{
    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
    {
        vowel++;
    }
    else
    {
        consonant++;
    }
}

Console.WriteLine("Number of vowel: "+vowel);
Console.WriteLine("Number of consonant: "+consonant);

*/



//დაწერეთ პროგრამა რომელიც იპოვნის ტექსტი შეიცავს თუ არა   substring-ს (მაგ: some text    შეიცავს ext-ს ? შეიცავს!)


string sub = "some text";

bool contains = true;
if (sub.Contains("ext")){
        Console.WriteLine(contains);
    }

else
{
    contains = false;  
}

