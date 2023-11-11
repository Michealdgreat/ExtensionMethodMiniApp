using System;

namespace ExtensionMethodMiniApp
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";
            while (string.IsNullOrWhiteSpace(output))
            {
               
                Console.WriteLine(message);
                output = Console.ReadLine();

            }

            return output;
        }
    
        public static int RequestInt(this string message, int MinValue, int MaxValue){

            return message.RequestInt(true, MinValue, MaxValue);
        }
        public static int RequestInt(this string message)
        {

            return message.RequestInt(false);

        }

        private static int RequestInt(string message, bool useMinMax, int MinValue=0, int MaxValue =0 )
        {

            int output = 0;

            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)
            {
                Console.WriteLine(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                   isInValidRange = (output >= MinValue && output <= MaxValue);
                    //if (output >= MinValue && output<=MaxValue)
                    //{
                    //    isInValidRange = true;
                    //}else
                    //{
                    //    isInValidRange = false;
                    //}
                }
            }

            return output;
        }
    
    }
}
