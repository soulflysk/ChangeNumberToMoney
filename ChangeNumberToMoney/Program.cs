
Console.Write("Please enter your money: ");
string number = Convert.ToString(Console.ReadLine());

public enum Number
{
    หนึ่ง,
    สอง,
    สาม,
    สี่,
    ห้า,
    หก,
    เจ็ด,
    แปด,
    เก้า,
    สิบ
}
// slice int number to array

char[] chars = number.ToCharArray();
//เปลี่ยนตัวเลขเป็นอักษรโดยการแทนที่
foreach (char c in chars)
{
    switch (c)
    {
        case '1':
            c = "หนึ่ง";
            break;
        case '2':
            c = "สอง";
            break;
            ...

    }

}


//แทรก สิบ ร้อย พัน หมื่น แสน ล้าน ระหว่าง array โดย array ที่ 2 คือหลักสิบ เป็ฯต้น
chars[1].pop();
chars[1] = "สิบ";
chars[3].pop();
chars[3] = "พัน"ว
    ...
// 
if(chars[0] = "หนึ่ง") {
    chars[0] = "เอ็ด";
}
if(chars[1] = "สอง")
{
    chars[2] = "ยี่สิบ"
}