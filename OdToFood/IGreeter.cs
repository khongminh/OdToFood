namespace OdToFood
{
	public interface IGreeter
	{
		string GetMessageOfTheDay();
	}

	public class Greeter : IGreeter
	{
		public string GetMessageOfTheDay()
		{
			return "Greeting Class";
		}
	}
}