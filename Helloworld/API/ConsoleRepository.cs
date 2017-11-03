using System;

namespace API
{
    /// <summary>
    /// This would display for the console application
    /// </summary>
    public class ConsoleRepository : IRepository
    {
        /// <summary>
        ///  String used to store and retrieve data
        /// </summary>
        private string _message= "Hello World";

        /// <summary>
        /// This will get data from the database or other sources    
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            return "Console Application: "+_message;
        }

        /// <summary>
        /// This will write to the databse or any other sources
        /// </summary>
        /// <param name="content"></param>
        public void Write(string content)
        {
            _message = content;
        }
    }
}