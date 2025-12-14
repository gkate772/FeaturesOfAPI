#### Serialization & Deserialization in C#
Serialization = converting an object into a format that can be stored or sent
Deserialization = converting stored/sent data back into an object

Serialization is the process of converting an object into a storable or transferable format, and
Deserialization is converting that format back into an object.

--->Convert Object to JSON string.
using JsonSerializer.Serialize(<object>);

--->Format JSON While Serializing Object
var options = new JsonSerializerOptions { WriteIndented = true };

👉 Makes JSON readable (pretty format)
WriteIndented = true;
👉 Default is false (compact format)

PropertyNamingPolicy
👉 Controls JSON property naming style
options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
👉 Converts C# PascalCase to JSON camelCase
options.PropertyNamingPolicy = JsonNamingPolicy.pascalCase;
👉 Default is null (no change)

PropertyNameCaseInsensitive
👉 Ignore case while deserializing JSON
options.PropertyNameCaseInsensitive = true;
👉 Default is false (case-sensitive)

DefaultIgnoreCondition
Purpose: Ignore null values in JSON
options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
👉 Default is JsonIgnoreCondition.Never (include nulls)

Converters
Purpose: Custom conversion (most common → Enum as string)
options.Converters.Add(new JsonStringEnumConverter());
👉 Default is Enum as integer

NumberHandling
Purpose: Read numbers from string values
options.NumberHandling = JsonNumberHandling.AllowReadingFromString;

JsonSerializerOptions controls JSON formatting, naming policy, null handling, case sensitivity, and custom conversions in C#.

----------------------------------------------------------------------------

JsonPropertyName
👉 Customize JSON property name
[JsonPropertyName("custom_name")]
public string MyProperty { get; set; }
👉 Overrides default property naming

✔ Serialization (Object → JSON)
✔ Deserialization (JSON → Object)

[JsonPropertyName] has higher priority than PropertyNamingPolicy ---> ➡ Attribute name will still be used.

[JsonPropertyName] is used to customize JSON property names without changing the C# property name.

----------------------------------------------------------------------------

[JsonIgnore]
NOT to include a property in JSON.
Ignore When Value Is Null
[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
👉 Ignore property if value is null during serialization

Ignore All Nulls (Global – Alternative)
options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;

[JsonIgnore] is used to exclude a property from JSON serialization or deserialization in C#.

----------------------------------------------------------------------------

[JsonInclude]
👉 Include this field or non-public property in JSON
[JsonInclude] allows fields and non-public or read-only members to be included in JSON serialization

______________________________________________________________________________

[JsonPropertyOrder]
It controls the order of properties in JSON output

[JsonPropertyOrder] controls the sequence of properties in JSON output during serialization.

______________________________________________________________________________


Serialize a List (Array) of objects to JSON
List, Array, IEnumerable → all serialize as JSON array
No special code needed
Order of list is preserved

A list of objects is serialized into a JSON array using JsonSerializer.Serialize() in C#.

______________________________________________________________________________









