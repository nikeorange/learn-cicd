using Xunit;
using SimpleApp;

namespace SimpleApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Add(2, 3);
        
        // Assert
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Add_NegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Add(-5, 10);
        
        // Assert
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Multiply(3, 4);
        
        // Assert
        Assert.Equal(12, result);
    }
    
    [Fact]
    public void Multiply_ByZero_ReturnsZero()
    {
        // Arrange
        var calculator = new Calculator();
        
        // Act
        var result = calculator.Multiply(5, 0);
        
        // Assert
        Assert.Equal(0, result);
    }
    [Fact]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        // Arrange
        var calculator = new Calculator();
    
        // Act
        var result = calculator.Subtract(10, 4);
    
        // Assert
        Assert.Equal(6, result);
    }
}