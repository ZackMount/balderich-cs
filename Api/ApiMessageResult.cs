namespace Balderich.Api
{
    public class ApiMessageResult
    {
		public ApiMessageResult(int code, dynamic? data)
		{
			Code = code;
			Data = data;
		}
		public int Code { get; set; }
        public dynamic? Data { get; set; }
    }
}
