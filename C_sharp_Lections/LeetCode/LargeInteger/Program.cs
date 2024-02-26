
// неправильное решение.
int[] PlusOne(int[] digits) {
    double number = 0;    
    int power = digits.Length-1; 
    for (int i = 0; i < digits.Length; i++)
    {
        number += digits[i]*Math.Pow(10,power - i);        
    }
    Console.WriteLine(number);
    number +=1;
    double temp = number;
    Console.WriteLine(number);
    int digitCount = 0;
    while (number>=1)
    {
        number/=10;
        digitCount++;
    }
    number=temp;
    Console.WriteLine(digitCount);    
    if (digitCount == digits.Length)
    {
        for (int i = digits.Length-1; i >=0; i--)
        {
            digits[i] = Convert.ToInt32(number%10);            
            number/=10;
        }
        return digits;
    }
    else
    {
        digits = new int [digitCount];
        for (int i = digitCount-1; i >=0; i--)
        {
            digits[i] = Convert.ToInt32(number%10);
            number/=10;            
        }        
        return digits;
    }

    // return digits;    
}
int []array = new int []{9,2,3,4,5};
int[] array10 = new int []{9,8,7,6,5,4,3,2,1,0};
int []array2 = new int []{9};
int [] result = PlusOne(array);
Console.WriteLine(String.Join(" ", result));