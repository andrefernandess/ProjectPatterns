namespace ProjectPatterns.FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Carregando com ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Carregando com ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: Funciona mesmo sem conhecer a classe Creator.\n" + creator.SomeOperation());
            // ...
        }
    }
}
