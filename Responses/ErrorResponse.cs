namespace InfoTrackGlobalTeamTechTest.Responses
{
    /// <summary>
    /// ErrorResponse
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ErrorResponse<T>
    {
        /// <summary>
        /// ErrorMessage
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static ErrorResponse<T> Create(string errorMessage)
        {
            return new ErrorResponse<T> { ErrorMessage = errorMessage };
        }
    }
}
