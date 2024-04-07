namespace HWAnimals.Animals;

public class Dog : Animal {
    public override void Eat() {
        Console.WriteLine($"{GetName()} ест");
    }
}