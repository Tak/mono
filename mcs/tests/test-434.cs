using foo = Foo;

namespace Foo {
	class A { }
}

class X {
	static Foo.A a = new foo::A ();
	static void Main ()
	{
		System.Console.WriteLine (a.GetType ());
	}
}
