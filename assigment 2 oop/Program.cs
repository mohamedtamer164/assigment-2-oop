namespace assigment_2_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region anwer 1
            // answer to question 1
            // a) What is the difference between a class and a struct?
            /*
            ----------------------- struct-----------------------
         1- struct is a value type , and not suuport encapsulation, inheritance and polymorphism.
         2 - struct is stored in stack memory.
         3 - struct is used for small data structures that contain primarily data that is not intended to be modified after the struct is created.
         
        ------------------------ class-----------------------
        1- class is a reference type, and support encapsulation, inheritance and polymorphism.
        2 - class is stored in heap memory.
        3 - class is used for larger data structures that may contain methods and properties, and are intended to be modified after the class is created.
           **/

            //b) Why are classes more suitable than structs for large applications?

            /*
            besuase classes ecause classes are reference types stored on the heap, which allows the program to handle larger amounts of data compared to structs, and I can control the lifetime of the stored objects via Garbage Collector.

            **/


            #endregion
        }
    }
}
