using System;
using Homework.Lesson1;
using Xunit;

namespace Test;

public class Lesson1Tests
{
    [Theory]
    [InlineData("123", "342", 465)]
    [InlineData("0", "-123", -123)]
    [InlineData("123.43", "-542", -418.57)]
    public void Test1(string a, string b, double result)
    {
        var resultFromTask = new Task1().Process(a, b);
        Assert.Equal(Math.Round(resultFromTask, 2, MidpointRounding.ToZero), result);
    }
    
    [Theory]
    [InlineData("8", "3", 512)]
    [InlineData("3.41", "5", 461.07)]
    [InlineData("-4", "3", -64)]
    public void Test2(string a, string b, double result)
    {
        var resultFromTask = new Task2().Process(a, b);
        Assert.Equal(Math.Round(resultFromTask, 2, MidpointRounding.ToZero), result);
    }
    
    [Theory]
    [InlineData("Дима", "Привет Дима!")]
    [InlineData("123 321 123", "Привет 123 321 123!")]
    public void Test3(string a, string result)
    {
        var resultFromTask = new Task3().Process(a);
        Assert.Equal(resultFromTask, result);
    }
    
    [Theory]
    [InlineData("Test string", 3, "Test string\nTest string\nTest string\n")]
    public void Test4(string str, int count, string result)
    {
        var resultFromTask = new Task4().Process(str, count.ToString());
        Assert.Equal(resultFromTask, result);
    }
    
    [Theory]
    [InlineData("12", true)]
    [InlineData("0", true)]
    [InlineData("-1", false)]
    public void Test5(string n, bool result)
    {
        var resultFromTask = new Task5().Process(n);
        Assert.Equal(resultFromTask, result);
    }
    
    [Theory]
    [InlineData("A B B C D A E f c p B s k l", 'B', 3)]
    public void Test6(string str, char c, int result)
    {
        var resultFromTask = new Task6().Process(str, c);
        Assert.Equal(resultFromTask, result);
    }
    
        
    [Theory]
    [InlineData(new[]{"1", "2", "3", "0", "-1"}, new[]{1,2,3,0,-1})]
    public void Test7(string[] strArray, int[] result)
    {
        var resultFromTask = new Task7().Process(strArray);

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] != resultFromTask[i])
            {
                Assert.True(false);
            }
        }
        
        Assert.True(true);
    }
}