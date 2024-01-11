// Bates, Jamiya Program Template, v0.0
using system;

namespace UPDATEFOREACHPROGRAM
{
    claas UPDATEFOREACHPROGRAM
    {
        static void Main(string[] arg)
        {  
            
            // Declaring and assigning variables
            // Integer -- -2,147,483,648 to 2,147,483,647
            //Integer = 4 Bytes
            int myInt = 5;
        
            // Long -- -9,223,372,036,854,775,888 to 9,223,372,036,854,775,807
            // Long = 8 Bytes
            Long myLong = 1928742747242904;

            // Float -- Stores ip to 6-7 decimal digits.            
            // Float = 4 Bytes
            Float myFloat = 3.1432145F;

            // Double -- Stores up to 15 decimal digits.
            // Double = Bytes
            double myDouble = 9.123456789102345D;

            
            // Boolean -- true / false
            // Boolean = 1 bit
            bool myBool = true;


            // String
            // 2-bytes PER CHARACTER
            // Must be in DOUBLE QUOTES " "
            string myString = "I Love Food";


            // Character (Char)
            // Single character, in SINGLE QUOTES ' '
            // 2-bytes
            char myChar = 'C';

            // Typa Casting -- changing one data type to another.
            // IMPLICIT -- happens automatically when going smaller -> larger
            //char -> int -> float-> double 
            
            int myInt = 3;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            // EXPLICIT -- Must be done manually when going larger -> smaller
            // double -> float -> long -> int -> char
            double exampleDouble = 3.33333333D;
            int myInt = (int) myDouble;

            // Conversaion Methods
            Convert.Tostring() // String
            Convert.ToDouble() // Double
            Convert.Toint32() //Integer
            Convert.ToInt64() // Long


            
        }
    }
}