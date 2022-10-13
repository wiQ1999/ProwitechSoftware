namespace Infrastructure.Models.ExceptionResponses;
public class DetailExceptionResponse : BaseExceptionResponse
{
    public string Type { get; set; }
    public string StackTrace { get; set; }

    public DetailExceptionResponse(Exception ex) : base(ex)
    {
        Type = ex.GetType().Name;
        StackTrace = ex.ToString();
    }
}
