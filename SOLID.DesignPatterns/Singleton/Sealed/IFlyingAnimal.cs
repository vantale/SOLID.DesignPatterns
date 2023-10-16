namespace SOLID.DesignPatterns.Singleton.Sealed
{
    public interface IFlyingAnimal { }
    public class Animal { }
    public sealed class Husky: Animal { }
    public class Bear : Animal { }

    internal class CheckInterface
    {
        public void Execute()
        {
            var husky = new Husky();
            var bear = new Bear();


            var bearAsFlyingAnimal = bear as IFlyingAnimal;
            var huskyAsFlyingAnimal = husky as IFlyingAnimal;
        }
    }
}
