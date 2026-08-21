using JLib.Tools;

namespace JLib.Storage;

/// <summary>
/// Provides storage and basic operations for a collection of integers.
/// </summary>
public class IntStore
{
    private readonly List<int> _values = new();

    /// <summary>
    /// Adds an integer to the store.
    /// </summary>
    /// <param name="value">The integer to add.</param>
    public void Add(int value)
    {
        _values.Add(value);
    }

    /// <summary>
    /// Gets the integer at the specified position.
    /// </summary>
    /// <param name="index">The zero-based position of the value.</param>
    /// <returns>The integer stored at the specified position.</returns>
    public int Get(int index)
    {
        return _values[index];
    }

    /// <summary>
    /// Calculates the total of all integers currently stored.
    /// </summary>
    /// <returns>The sum of all integers in the store.</returns>
    public int Sum()
    {
        var calculator = new Calculator();
        return calculator.Total(_values);
    }
}