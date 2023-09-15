using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helllo World !!!");
            //variable are declared once and can be changed later on
            //Naming of variables or constants
            //Start with letter
            //followed by number or underscore
            int myInt = 1;
            int my_Int = 2;
            int myInt1 = 3;
            //constant are decalred once and cannot be change later on
            const int A_CONST_INT = 100;
            // Primitive type 

            //integer
            //ints by defaults are 32bits
            //can hold numbers from -2,147,483,648 to 2,147,483,647
            //by default signed
            int anInt = 1;
            const int THE_CONST_INT = 2;



            //------------------------------------------------------
            //8 bit version of an INT
            //byte
            //unsigned by default
            //range is 0 to 255
            byte myByte = 120;
            const byte MY_CONST_BYTE = 210;


            // 16 bit version of an INT
            //Is call a SHORT
            //range is -32,768 to 32,767
            //by default signed
            short myShort = 32000;
            const short MY_CONST_SHORT = -32000;

            //64 bit version of an int
            //long
            //Range -9.2x10^18 to 9.2x10^18
            long myLong = 3234538798782098088;
            const long MY_CONST_LONG = 982578790089129792;
            //---------------------------------------------------

            //unsigned version 
            // we have uint, ulong, ushort
            uint myUint = 11232;
            ushort myUshort = 1223;
            ulong myUlong = 1232332;

            //---------------------------------------------------
            //signed version of byte
            // This is called sbyte
            //range -128 to 127
            sbyte mySbyte = -120;


            //float
            //floats are by default 32 bits
            //they can hold approximately -3.4x10^38 to 3.4x10^38
            //ends with f otherwise it will assume its a double
            //accurate to 7 decimal units
            float aFloat = 2.5634523f;
            const float myFloat = 2.1425f;


            //double
            //64 bits decimals
            //accurate to 15-16 decimal units
            double aDouble = 2.234234;
            const double MY_CONST_DOUBLE = 2.345879;


            //char
            //they hold a value at a time 
            //letter to a symbol 
            char myChar = 'a';
            const char MY_CHAR_CONST = '-';




            //boolean
            //bool holds the value of true or false
            bool myBool = true;
            const bool MY_CONST_BOOL = false;


            //overflowing is when you try to assign a type a value too large for the container

            //For example sbyte my_sbyte = 129 is too lager to be holded by my_Sbyte


        }   



    }
}
