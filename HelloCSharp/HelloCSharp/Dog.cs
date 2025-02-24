namespace HelloCSharp;

public record DogRecExt
{
	public string Name { get; init; }
	public Guid Id { get; } = Guid.Empty;
	public DateTime? DateOfBirth { get; set; }
	public Dictionary<string, object> Metadata { get; } = new();

	private int? AgeInDays => (-DateOfBirth?.Subtract(DateTime.Now))?.Days;
	public int? Age => AgeInDays / 365;
	public int? AgeInDogYears => AgeInDays * 7 / 365;

	public object this[string key]
	{
		get { return Metadata[key]; }
		set { Metadata[key] = value; }
	}
}
public class Dog
{
	public required string Name { get; init; }
	public Guid Id { get; } = Guid.Empty;
	public DateTime? DateOfBirth { get; set; }
	private int? AgeInDays => (-DateOfBirth?.Subtract(DateTime.Now))?.Days;
	public int? Age => AgeInDays / 365;
	public int? AgeInDogYears => AgeInDays * 7 / 365;
	public override string ToString() =>
		$"{Name} ({Age} | {AgeInDogYears}) [ID: {Id}]";

	private Dictionary<string, object> _metadata = [];
	public object this[string key]
	{
		get => _metadata.ContainsKey(key) ? _metadata[key] : null;
		set { _metadata[key] = value; }
	}
	
}

