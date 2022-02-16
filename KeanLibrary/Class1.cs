namespace KeanLibrary
{
    public class Class1
    {
        /// <summary>
        ///This method calculate the Multi
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiply(int a, int b) {
            
            int X= a*b;
            Console.WriteLine("The multiplication of " + a + " and " + b + " is " +  X + ".");
            return X;
        }

         public static int Multiply(int a, int b, int c) {
            
            int X= a*b*c;
            Console.WriteLine("The multiplication of " + a + " and " + b + " and " + c + " is " +  X + ".");
            return X;
        }

    }
}