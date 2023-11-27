namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string errorMessage = null)
        {
            StatusCode = statusCode;
            ErrorMessage = errorMessage ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request",
                401 => "Not Authorized",
                404 => "Resource not found",
                500 => "Server Error",
                _ => null,
            };
        }
    }
}
