using webAPIapi.Interfaces;

namespace webAPIapi.Services
{
    public class HelloWorldService : HelloWorldInterface
    {
        public string GetHelloWorld()
        {
            return "Hello World!";
        }
    }

}