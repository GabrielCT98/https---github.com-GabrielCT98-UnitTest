using Xunit;
using 	KeanLibrary;
namespace KeanConsole;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
		int a =2, b=3;
		int expected = 6;
		int actual = Class1.Multiply(a,b);

		Assert.Equal(expected,actual);
    }
 	[Fact]
	public void Test2()
    {
		int a =2, b=3, c=4;
		int expected = 24;
		int actual = Class1.Multiply(a,b,c);

		Assert.Equal(expected,actual);
    }
}