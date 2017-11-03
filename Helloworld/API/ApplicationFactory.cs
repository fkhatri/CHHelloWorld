using System;

namespace API
{
    public class ApplicationFactory
    {
        public IRepository Create(string applicationType)
        {
            IRepository repository = null;
            if (applicationType == "Console")
            {
                repository= new ConsoleRepository();
            }
            if (applicationType == "Web")
            {
                repository = new WebRepository();
            }
            if (applicationType == "Mobile")
            {
                repository=new MobileRepository();
            }
            return repository;
        }
    }

    /// <summary>
    /// This would be used for Web applicaiton
    /// </summary>
    public class WebRepository : IRepository
    {
        /// <summary>
        ///  String used to store and retrieve data
        /// </summary>
        private string _message="Hello World";

        /// <summary>
        /// This will get data from the database or other sources    
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            return "Web Application: " + _message;
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

    /// <summary>
    /// This would be used for Web applicaiton
    /// </summary>
    public class MobileRepository : IRepository
    {
        /// <summary>
        ///  String used to store and retrieve data
        /// </summary>
        private string _message = "Hello World";

        /// <summary>
        /// This will get data from the database or other sources    
        /// </summary>
        /// <returns></returns>
        public string Display()
        {
            return "Mobile Application: " + _message;
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