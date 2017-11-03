namespace API
{
    /// <summary>
    ///  Centralized Repository to store and retirve the data
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// This will get data from the database or other sources    
        /// </summary>
        /// <returns></returns>
        string Display();

        /// <summary>
        /// This will write to the databse or any other sources
        /// </summary>
        /// <param name="content"></param>
        void Write(string content);
    }

}