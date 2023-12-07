namespace ProjectPatterns.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            // Chama a fabrica para criar um objeto de Produto
            var product = FactoryMethod();
            // Usando o objeto.
            var result = "Creator: O codigo do mesmo creator funcionou com:  "
                + product.Operation();

            return result;
        }
    }

    public interface IProduct
    {
        string Operation();
    }

    // Concrete Products provide various implementations of the Product
    // interface.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Resultado da classe  ConcreteProduct1}";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Resultado da classe ConcreteProduct2}";
        }
    }

    class ConcreteCreator1 : Creator
    {
       public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
