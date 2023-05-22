namespace DotnetCoreMssql.Exceptions
{
	public class NotFoundException : MyException
	{
		public NotFoundException()
		{
			Console.WriteLine("Empty NotFoundException");
		}

		public NotFoundException(string description) : base(description + " not found")
		{
			Console.WriteLine("String NotFoundException");
			HttpStatusCode = 404;
		}
	}
}