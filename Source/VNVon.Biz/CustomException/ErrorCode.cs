namespace VNVon.Service.CustomException
{
    public enum ErrorCode
    {
        Success = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        Conflict = 409,
        BranchNotExist = 410,
        ProductNotExist = 420,
        AccountNotExist = 430,
        CardNotExist = 440,
        CardStatusInvalid = 441,
        CardBasicInvalid = 442,
        CardSupplementProductInvalid = 443,
        CardSupplementLimitInvalid = 444,
        CardPINInvalid = 445,
        CustomerExist = 450,
        CustomerNotExist = 451,
        Error = 500,
        NotImplemented = 501,
        ServiceUnavailable = 503,
        Timeout = 504
    }
}
