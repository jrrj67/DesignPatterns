using Singleton.Concretes;

Console.WriteLine("Singleton not thread safe:");

var notThreadSafe = SingletonNotThreadSafe.GetInstance();

var notThreadSafeTest = SingletonNotThreadSafe.GetInstance();

if (notThreadSafe == notThreadSafeTest)
{
    Console.WriteLine("Singleton not thread safe works!");
}

Console.WriteLine("Singleton thread safe:");

Console.WriteLine(
    "{0}\n{1}\n\n{2}\n",
    "If you see the same value, then singleton was reused (yay!)",
    "If you see different values, then 2 singletons were created (booo!!)",
    "RESULT:"
);

Thread process1 = new Thread(() =>
{
    TestSingleton("FOO");
});

Thread process2 = new Thread(() =>
{
    TestSingleton("BAR");
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();

static void TestSingleton(string value)
{
    SingletonThreadSafe singleton = SingletonThreadSafe.GetInstance(value);

    Console.WriteLine(singleton.Value);
}
