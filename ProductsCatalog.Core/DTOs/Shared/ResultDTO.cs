namespace ProductsCatalog.Domain.DTOs.Shared
{
    public class ResultDTO
    {
        public bool IsSuccess { get; private set; }
        public string Message { get; private set; }

        private ResultDTO(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public static ResultDTO Success(string message = Constants.SuccessMessage)
        {
            return new ResultDTO(true, message);
        }

        public static ResultDTO Failure(string message = Constants.FailureMessage)
        {
            return new ResultDTO(false, message);
        }
    }
}