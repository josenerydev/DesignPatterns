namespace ChainOfResponsibility
{
    public class Client
    {
        /// <summary>
        /// The client code is usually suited to work with a single handler. In
        /// most case, it is not even aware that the handler is part of a chain.
        /// </summary>
        /// <param name="handler"></param>
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"    {result}");
                }
                else
                {
                    Console.Write($"    {food} was left untouched.\n");
                }
            }
        }
    }
}
