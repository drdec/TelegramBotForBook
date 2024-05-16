using ObsLib.Controlles;

namespace TestConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var phone = "+375257037315";
            var obs = new ApiOBS();

            var response = await obs.Autorizations(phone);

            Console.WriteLine(response);

            Console.WriteLine("Код");
            var code = Console.ReadLine();

            await obs.EnterCode(code);
        }
    }
}