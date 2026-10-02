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


            #region answer 2

            // a) Which class is the parent class?
            //b) Which class is the child class?
            //c) What members are inherited by ExpressShipment?
            // d) Why is inheritance better than duplicating the same code in multiple classes?

            /*
           a * base class = shipment
           b * child class = ExpressShipment
           c * members inherited by ExpressShipment = tracingcode 
           d * inheritance is better than duplicating the same code in multiple classes because it promotes code reusability, reduces redundancy, and makes the code easier to maintain and update. By using inheritance, we can create a hierarchy of classes that share common functionality, which allows us to write cleaner and more efficient code.




            */


            #endregion
        }
    }
}
