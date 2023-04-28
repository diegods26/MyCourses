namespace MyCoursesApi.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }       

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "You made a bad request",
                401 => "Not authorized",
                404 => "It was not found",
                500 => "An inesperated error occured, please back later",
                _ => null
            };
        }
    }
}
