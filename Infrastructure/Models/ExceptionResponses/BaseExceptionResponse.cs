namespace Infrastructure.Models.ExceptionResponses;
public class BaseExceptionResponse
{
    public string Message { get; set; }

    public BaseExceptionResponse(Exception ex)
    {
        Message = ex.Message;
    }
}
