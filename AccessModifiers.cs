namespace AccessModifiers
{
    class AAA
    {
        protected int a;
        void MethodAAA(AAA aaa,BBB bbb)
        {
            aaa.a = 100;
            bbb.a = 200;
        }
    }
     class BBB:AAA
     {
         void MethodBBB(AAA aaa, BBB bbb)
         {
           //  aaa.a = 100;
             bbb.a = 200;
         }
     }
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}