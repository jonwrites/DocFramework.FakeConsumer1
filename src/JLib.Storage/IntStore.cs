using JLib.Tools;

namespace JLib.Storage;

/// <summary>
/// Provides storage and basic operations for a collection of integers.
/// </summary>
public class IntStore
{
    private readonly List<int> _values = new();
    private readonly ICalculator _calculator;

    /// <summary>
    /// Constructs a new instance of a IntStore.
    /// </summary>
    /// <param name="calculator">An ICalculator used to perform arithmatic on the stored numbers.</param>
    /// <returns>New instance of an IntStore.</returns>
    public IntStore(ICalculator calculator)
    {
        _calculator = calculator;
    }

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
        return _calculator.Total(_values);
    }
}