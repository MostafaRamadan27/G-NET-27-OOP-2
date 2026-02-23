namespace Assignment1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Q1 
            //A)
            //Field Must be Private 
            // in method must put validation before withdraw 
            // B)
            // 1- make field private   2- put validation before withdraw in method
            // c) 
            // because user can put invalid data 
            #endregion

            #region Q2
            // field  => 1- direct data storage / 2- no validations / 3- break encapsulation
            // property => 1- controlled access / 2- can validate / 3- enforce encapsulation

            // property can cotain logic 

            // private int _number1;
            // private int _number2;

            // public int calculatedNumber {
            //   get {
            //     return _number1 + _number2;
            //   }
            //   
            // }
            #endregion


            #region Q3 
            //a) indexer => allow object to be indexed like array 
            // b) error out of range => TO Make it safe use validation in indexer to check if index is in range before accessing the element
            // c) yes class can have multiple indexers with different parameter types 
            // if i need to search with two different way like like in library Example when ineed to search by index ot ISBN 
            #endregion


            #region Q4
            // a) Static mean the member belong to type itself // it shared for all object and can be accessed without creating an instance of the class 
            // b) cant access item directly because its not static only access with instance of class
            #endregion
            #endregion






        }
    }
}
