using FactoryMethod.Utils;
using FactoryMethod.Concretes.FinalFantasyI;

Console.WriteLine("Choose a final fantasy game number to know who is the protagonist!");

int.TryParse(Console.ReadLine(), out int number);

if (!Enum.IsDefined(typeof(FinalFantasyNumber), number))
{
	Console.WriteLine("Invalid input.");

	return;
}

(string Title, string Protagonist) titleAndProtagonist;

switch (number)
{
	case (int)FinalFantasyNumber.I:
		var concreteCreator = new FinalFantasyICreator();
        titleAndProtagonist = concreteCreator.GetTitleAndProtagonist();
		break;
	default:
		throw new NotImplementedException();
}

Console.WriteLine($"Title: {titleAndProtagonist.Title}.");

Console.WriteLine($"Protagonist: {titleAndProtagonist.Protagonist}.");