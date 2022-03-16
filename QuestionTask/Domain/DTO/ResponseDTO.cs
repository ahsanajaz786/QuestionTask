namespace QuestionTask.Domain.DTO
{
    public class Response<T>
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public bool IsSuccess { get; set; }
        public int ErrorCode { get; set; }
        public T Payload { get; set; }
        public int PageNumber { get; set; }
        public int RowNumber { get; set; }
        public int Total { get; set; }
        public int NextPage { get; set; }
        public static Response<T> Success(T payload, string message)
        {
            return new Response<T>
            {
                ErrorCode = 0,
                Status = "Success",
                Message = message,
                Payload = payload,
                IsSuccess = true
            };
        }
        public static Response<T> Success(string message)
        {
            return new Response<T>
            {
                ErrorCode = 0,
                Status = "Success",
                Message = message,
                IsSuccess = true
            };
        }
      
        public static Response<T> Failure(string message, ApiStatusCode apiStatusCode)
        {
            return new Response<T>
            {
                ErrorCode = (int)apiStatusCode,
                Status = "Fail",
                Message = message,
                IsSuccess = false
            };
        }
        public static Response<T> Failure(T payload, string message, ApiStatusCode apiStatusCode)
        {
            return new Response<T>
            {
                ErrorCode = (int)apiStatusCode,
                Status = "Fail",
                Message = message,
                Payload = payload,
                IsSuccess = false
            };
        }


    }
    public enum ApiStatusCode
    {
        UserNotFound = 1,
        EmailNotVerified = 2,
        InvalidEmailPassword = 3,
        UserAlreadyExist = 4,
        DbError = 5,
        ExpiredToken = 6,
        InternalServer = 7,
        GeneralError = 8,
        IdentityNotCreatingUser = 9,
        ContentNotFound = 10,
        UserNoteActive = 11,
        ConfirmationTokenNotValid = 12,
        EmailAndMobileNotVerified = 13,
        MobileNotVerified = 14,
        UserDisabled = 15,
        UpdateFailed = 16,
        NotAllowed = 17
    }
}
