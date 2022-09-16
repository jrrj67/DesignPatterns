using Prototype.Concretes;
using Prototype.Interfaces;

var controller = new Controller("Dualsense", 15);

ICloneable<Playstation> play = new Playstation("FAT", 5, controller);

var shallowCopy = play.ShallowCopy();

Console.WriteLine($"Object {shallowCopy} shallow copied.");

var deepCopy = play.DeepCopy();

Console.WriteLine($"Object {deepCopy} deep copied.");