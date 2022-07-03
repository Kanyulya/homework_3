// напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом
bool isPalindrome(int x){
    int div = 1;
    while(x/div >= 10){
        div*=10;
    }
    // Console.WriteLine(div);
    while(x!=0){
        int l = x/div;
        int r = x%10;
        if(l!=r){
            Console.WriteLine("не палиндром");
            return false;
        }
        x = (x%div)/10;
        div/=100;
    }
    Console.WriteLine("палиндром");
    return true;
}
// isPalindrome(1231);
// isPalindrome(11211);
// isPalindrome(1221);
Console.WriteLine("введите число");
isPalindrome(Convert.ToInt32(Console.ReadLine()));