namespace AbstractFactory.DoFactoryAbstractRealWorld
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
