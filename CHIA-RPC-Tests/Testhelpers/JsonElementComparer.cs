using System.Text.Json;
using Xunit;

public class JsonElementComparer
{
    // AssertEqual method checks if the two JsonElement objects are equal, and throws an exception with a detailed error message if not.
    public static void AssertEqual(JsonElement obj1, JsonElement obj2)
    {
        var result = Compare(obj1, obj2, "$");
        Assert.True(result.AreEqual, $"The two JsonElement objects are not equal. {result.ErrorMessage}");
    }
    private static bool CompareNumericValues(JsonElement obj1, JsonElement obj2)
    {
        if (obj1.ValueKind == JsonValueKind.Number && obj2.ValueKind == JsonValueKind.Number)
        {
            if (obj1.TryGetDecimal(out decimal decimal1) && obj2.TryGetDecimal(out decimal decimal2))
            {
                return decimal1 == decimal2;
            }
        }
        return false;
    }
    private static bool CompareStringValues(JsonElement obj1, JsonElement obj2)
    {
        if (obj1.ValueKind == JsonValueKind.String && obj2.ValueKind == JsonValueKind.String)
        {
            string? string1 = obj1.GetString();
            string? string2 = obj2.GetString();
            if (string.IsNullOrEmpty(string1) && string.IsNullOrEmpty(string2)) return true;
            else if (string.IsNullOrEmpty(string1) || string.IsNullOrEmpty(string2)) return false;
            return string1.Equals(string2);
        }
        return false;
    }
    private static bool CompareBooleanValues(JsonElement obj1, JsonElement obj2)
    {
        if (obj1.ValueKind == JsonValueKind.False || obj1.ValueKind == JsonValueKind.True)
        {
            return obj1.GetBoolean() == obj2.GetBoolean();
        }
        return false;
    }


    // Compare method recursively compares the structure and values of the JsonElement objects and returns a tuple with the comparison result and path where the difference is found.
    private static (bool AreEqual, string ErrorMessage) Compare(JsonElement obj1, JsonElement obj2, string path)
    {
        // Check if the value kinds are different
        if (obj1.ValueKind != obj2.ValueKind)
        {
            return (false, $"Path: {path} | ValueKind mismatch: {obj1.ValueKind} vs {obj2.ValueKind}");
        }

        // Compare based on the value kind
        switch (obj1.ValueKind)
        {
            case JsonValueKind.Object:
                // Iterate through properties of the first object
                foreach (var property in obj1.EnumerateObject())
                {
                    var propertyName = property.Name;
                    var newPath = $"{path}.{propertyName}";

                    // Check if the second object has the same property
                    if (!obj2.TryGetProperty(propertyName, out JsonElement otherProperty))
                    {
                        return (false, $"Path: {newPath} | Property '{propertyName}' not found in second object");
                    }

                    // Recursively compare the property values
                    var result = Compare(property.Value, otherProperty, newPath);
                    if (!result.AreEqual)
                    {
                        return result;
                    }
                }
                break;

            case JsonValueKind.Array:
                // Iterate through the elements of the first and second arrays
                var array1 = obj1.EnumerateArray();
                var array2 = obj2.EnumerateArray();

                int index = 0;
                while (array1.MoveNext() && array2.MoveNext())
                {
                    var newPath = $"{path}[{index}]";

                    // Recursively compare the array elements
                    var result = Compare(array1.Current, array2.Current, newPath);
                    if (!result.AreEqual)
                    {
                        return result;
                    }
                    index++;
                }

                // Check if either array has extra elements
                if (array1.MoveNext() || array2.MoveNext())
                {
                    return (false, $"Path: {path}[{index}] | Array length mismatch: {obj1.GetArrayLength()} vs {obj2.GetArrayLength()}");
                }
                break;

            default:
                if (obj1.ValueKind == JsonValueKind.Null && obj2.ValueKind == JsonValueKind.Null)
                {
                    // Both values are null, consider them equal
                }
                else if (obj1.ValueKind == JsonValueKind.Number && obj2.ValueKind == JsonValueKind.Number)
                {
                    // compare numeric types
                    if (!CompareNumericValues(obj1, obj2))
                    {
                        return (false, $"Path: {path} | Value mismatch: '{obj1.GetRawText()}' vs '{obj2.GetRawText()}'");
                    }
                }
                else if (obj1.ValueKind == JsonValueKind.String && obj2.ValueKind == JsonValueKind.String)
                {
                    // compare string types
                    if (!CompareStringValues(obj1, obj2))
                    {
                        return (false, $"Path: {path} | Value mismatch: '{obj1.GetRawText()}' vs '{obj2.GetRawText()}'");
                    }
                }
                else if ((obj1.ValueKind == JsonValueKind.False || obj1.ValueKind == JsonValueKind.True) && (obj2.ValueKind == JsonValueKind.False || obj2.ValueKind == JsonValueKind.True))
                {
                    // compare boolean types
                    if (!CompareBooleanValues(obj1, obj2))
                    {
                        return (false, $"Path: {path} | Value mismatch: '{obj1.GetRawText()}' vs '{obj2.GetRawText()}'");
                    }
                }
                else if (!obj1.Equals(obj2))
                {
                    // attempt generic comparison
                    return (false, $"Path: {path} | Value mismatch: '{obj1.GetRawText()}' vs '{obj2.GetRawText()}'");
                }
                break;

        }

        // If the code reaches here, the objects are equal
        return (true, "");
    }
}
