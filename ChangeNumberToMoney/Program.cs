
using System.Linq;

Console.Write("Please enter your money: ");
string number = Convert.ToString(Console.ReadLine());

// slice int number to array

char[] chars = number.ToCharArray();
List<string> result = new List<string>();
//เปลี่ยนตัวเลขเป็นอักษรโดยการแทนที่
foreach (char c in chars)
{
    switch (c)
    {
        case '1':
            result.Add("one");
            break;
        case '2':
            result.Add("two"); 
            break;
        case '3':
            result.Add("three");;
            break;
        case '4':
            result.Add("four");
            break;
        case '5':
            result.Add("five");
            break;
        case '6':
            result.Add("six");            
            break;
        case '7':
            result.Add("seven");;
            break;
        case '8':
            result.Add("eight");
            break;
        case '9':
            result.Add("nine");            
            break;
        case '0':
            result.Add("ten");
            break;

    }
}

//แทรก สิบ ร้อย พัน หมื่น แสน ล้าน ระหว่าง array โดย array ที่ 2 คือหลักสิบ เป็นต้น
result.Reverse();
//เขียนเงื่อนไขต่าง ๆ ให้ครบเช่นหลักสิบและหลักพัน
if (result[3] == "one")
{
    result[3] = "One Thousand";
}


result.Reverse();
for (int i = 0; i < result.Count; i++)
{ Console.Write(Convert.ToString(result[i])); }


Console.ReadLine();