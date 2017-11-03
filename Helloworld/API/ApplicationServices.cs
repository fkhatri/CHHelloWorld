using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    /// <summary>
    /// Middle API Service, all the front end application would call this API service to aceess the storage mechanism
    /// </summary>
    public interface IApplicationService
    {
        string DisplayHelloWorld();
        void WriteHelloWorld(string message);
    }

    /// <summary>
    /// Implementation version of Application Service
    /// </summary>
    public class ApplicationService : IApplicationService
    {
        private readonly IRepository _repository;               

        public ApplicationService(IRepository repository)
        {
            _repository = repository;
        }
        public string DisplayHelloWorld()
        {
            return _repository.Display();
        }

        public void WriteHelloWorld(string message)
        {
            _repository.Write(message);
        }
    }
}
