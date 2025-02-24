namespace HelloCSharp;

public record class DogRec(
	Guid Id,
	string Name,
	DateTime? DateOfBirth = null,
	Dictionary<string, object> Metadata = null
);

