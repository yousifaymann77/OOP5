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
        }
    }
}
