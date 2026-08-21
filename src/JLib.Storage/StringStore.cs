namespace JLib.Storage;

/// <summary>
/// Provides storage and basic operations for a collection of strings.
/// </summary>
public class StringStore
{
    private readonly List<string> _values = new();

    /// <summary>
    /// Adds a string to the store.
    /// </summary>
    /// <param name="value">The string to add.</param>
    public void Add(string value)
    {
        _values.Add(value);
    }

    /// <summary>
    /// Gets the string at the specified position.
    /// </summary>
    /// <param name="index">The zero-based position of the string.</param>
    /// <returns>The string stored at the specified position.</returns>
    public string Get(int index)
    {
        return _values[index];
    }

    /// <summary>
    /// Gets the number of strings currently stored.
    /// </summary>
    /// <returns>The number of strings in the store.</returns>
    public int Count()
    {
        return _values.Count;
    }
}