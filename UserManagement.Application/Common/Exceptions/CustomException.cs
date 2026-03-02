namespace Core.Application.Common.Exceptions
{
    public class CustomException : Exception
    {
        public string? Code { get; set; }
        public string? CustomMessage { get; set; }

        public CustomException(string? code = null)
            : base()
        {
            Code = code ?? "303";
        }

        public CustomException(string message, string? code = null)
            : base(message)
        {
            Code = code ?? "303";
            CustomMessage = message;
        }

        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
            CustomMessage = message;
        }

        public CustomException(string name, object key)
            : base($"Entity \"{name}\" ({key}) resulted into an error.")
        {
        }
    }
}