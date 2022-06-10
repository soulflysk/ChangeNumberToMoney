
Console.Write("Please enter your money: ");
string number = Convert.ToString(Console.ReadLine());

// slice int number to array

char[] chars = number.ToCharArray();
string result = "";
//เปลี่ยนตัวเลขเป็นอักษรโดยการแทนที่
foreach (char c in chars)
{
    switch (c)
    {
        case '1':
            result += "one";
            break;
        case '2':
            result += "two";
            break;
        case '3':
            result += "three";
            break;
        case '4':
            result += "four";
            break;
        case '5':
            result += "five";
            break;
        case '6':
            result += "six";
            break;
        case '7':
            result += "seven";
            break;
        case '8':
            result += "eight";
            break;
        case '9':
            result += "nine";
            break;
        case '0':
            result += "ten";
            break;

    }
}
//มีปัญหาในการอ้างอิงคำในตัวแปร result
//แทรก สิบ ร้อย พัน หมื่น แสน ล้าน ระหว่าง array โดย array ที่ 2 คือหลักสิบ เป็นต้น
chars[1].pop();
chars[1] = "สิบ";
chars[3].pop();
chars[3] = "พัน";
    ...
// 
if (chars[0] = "หนึ่ง")
{
    chars[0] = "เอ็ด";
}
if (chars[1] = "สอง")
{
    chars[2] = "ยี่สิบ"
}

Console.ReadLine();