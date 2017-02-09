
namespace NLogTest
{
    public class Application : IApplication
    {
        private readonly MainProcessor _processor;

        public Application(MainProcessor processor)
        {
            _processor = processor;
        }

        public void Run()
        {
            _processor.Process();
        }
    }
}
