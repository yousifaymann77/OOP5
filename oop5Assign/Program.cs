using System.Runtime.CompilerServices;

namespace oop5Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Q1 Object Copying 

            #region a) What happens when you assign one object variable to another object variable?
            // The variable receives a copy of the refrence to the same object of the first variable  
            #endregion

            #region b) Does assigning one object to another create a new object? Explain.
            // No Because The assigning Takes a copy of the refrence of the object so it does not create a new one
            #endregion

            #region c)What is the difference between copying an object and copying its reference?
            // Copying a refrence means there is only one object and a two variables with the same refrence to that object 
            // Copying an object means that there are two different objects with independent memories 
            #endregion

            #endregion


            #region part01 Q2 Shallow copy vs Deep copy 

            #region a)What is a Shallow Copy?
            // creating a new object and copying the value type fields but for refrence type it copy only the refrences 
            #endregion

            #region b)What is a Deep Copy?
            // craeting a new object and recursively copies all nested objects , The original and the copy objects are completely independent
            #endregion

            #region c)What happens to reference-type members when a Shallow Copy is created?
            // The refrences only is copied and the objects in the heap remain the same so the two objects refers to the same objects 
            #endregion

            #region d)What happens to reference-type members when a Deep Copy is created?
            // a new copy of the refrenced objects is created so changing in one does not affect the other one 
            #endregion

            #region e)Give one situation where Deep Copy would be safer than Shallow Copy.
            // you have a bank account object that contains a reference to a customer object ,With a Shallow Copy, account1 and account2 would share the same customer object
            //So if you change anything in account2 the customer in account1 would also change
            #endregion

            #endregion


            #region Part01 Q3 Static Members

            #region a)What is a static field, and how is it different from an instance field?
            // it is a field that owned by the class itself not to any instance and it has only one copy that is shared by all the members
            #endregion

            #region b) What is a static method? Can a static method directly access instance members?
            // it is a method belongs to the class and can be only called by the class name , no because it does not has an object associated with it 
            #endregion

            #region c) What is a static constructor, and when is it executed?
            // A special constructor which initializes the configuration of a class and is called one time before the first use of the class
            #endregion

            #region d) What is a static class? Can you create an object from a static class?
            // a class that only contains a static members , No you can not . 
            #endregion

            #endregion


            #region part01 Q4 Extension Methods 

            #region a)  What is an Extension Method?
            // Method let you add a new method to an existing type without modifying the original one or creating a new derived type
            #endregion

            #region b) What keyword must be used in the first parameter of an extension method?
            // this keyword
            #endregion

            #region c) Where must an extension method be declared? 
            // inside a static class 
            #endregion

            #region d) Can an extension method access private members of the class it extends?
            // No it cannot 
            #endregion

            #endregion


            #region Part01 Q5 Partial Classes and Partial Methods

            #region a) What is a Partial Class?
            // allows you to split the implementation of a class into multiple files  
            #endregion

            #region b) Why would a developer split one class into multiple files?
            // To organize large classes across multiple files , separate Auto-generated code from custom code , improve maintainability and readability
            #endregion

            #region c)What is a Partial Method?
            // it is a method Declaration without implementation in the class 
            #endregion

            #region d) What happens if a declared partial method has no implementation?
            // It is Ignored By the CLR 
            #endregion

            #endregion
        }
    }
}
