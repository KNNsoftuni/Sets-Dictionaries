namespace SoftuniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> list = new Dictionary<string, string>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "register")
                {
                    if (list.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                    else
                    {
                        list.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                    }
                }

                else if (input[0] == "unregister")
                {
                    if (!list.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                    else
                    {
                        list.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                }

            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}