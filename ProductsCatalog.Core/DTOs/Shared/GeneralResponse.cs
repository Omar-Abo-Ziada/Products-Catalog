namespace ProductsCatalog.Domain.DTOs.Shared
{
    public class GeneralResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; } 

        public GeneralResponse()
        {
            Success = true;  
        }

        public GeneralResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public GeneralResponse(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}