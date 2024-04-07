// See https://aka.ms/new-console-template for more information

using HWAnimals.Animals;

var dog = new Dog();

Console.WriteLine("Введите имя собаки:");

var name =Console.ReadLine();
dog.SetName(name);

Console.WriteLine($"Вашу собаку зовут: {dog.GetName()}");
dog.Eat();