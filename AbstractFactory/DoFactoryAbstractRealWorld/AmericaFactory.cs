namespace AbstractFactory.DoFactoryAbstractRealWorld
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
