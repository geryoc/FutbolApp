namespace FutbolApp.Core.Shared.Exceptions
{
    public class ValidationException : Exception
    {
        public Dictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();

        public static ValidationException From(string code, string message)
        {
            return new ValidationException
            {
                Errors = new Dictionary<string, string[]>
                {
                    { code, new string[] { message } },
                }
            };
        }

        public static ValidationException From(string code, string[] messages)
        {
            return new ValidationException
            {
                Errors = new Dictionary<string, string[]>
                {
                    { code, messages }
                }
            };
        }
    }
}
