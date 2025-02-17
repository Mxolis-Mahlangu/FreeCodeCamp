
// Call different kinds of methods in the .NET Class Library


// Stateful versus stateless methods

// STATELESS METHODS
// stateless methods are implemented so that they can work without referencing or changing any values already stored in memory.
// Stateless methods are also known as static methods.

// STATEFUL METHODS
// Other methods, however, must have access to the state of the application to work properly. In other words, 
// stateful methods are built in such a way that they rely on values stored in memory by previous lines of code that have already been executed.
// stateful they modify the state of the application by updating values or storing new values in memory.
// They're also known as instance methods.
// Stateful (instance) methods keep track of their state in fields, which are variables defined on the class.
// when you need to call stateful methods, you must first create an instance of the class so that the method can access state.

// Creating an instance of a class
// An instance of a class is called an object;

// Your code uses the dice object like a variable that stores the state of the Random class. When you call the Next() method on the dice object,
// the method uses the state stored in the dice object to generate a random number.
// Random dice = new Random();

// The latest version of the .NET Runtime enables you to instantiate an object without having to repeat the type name 
Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// How can you determine whether you need to create an instance of a class before calling its methods?
// One approach for determining whether a method is stateful or stateless is to consult the documentation.
// documentation includes examples that show whether the method must be called from the object instance or directly from the class.

int result = Random.Next();