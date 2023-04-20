namespace JwtAuth.Models
{
    public class ResponseModel<T>
    {
        public int Result { get; set; }
        public string Message { get; set; }
        public T? Body { get; set; }

        private ResponseModel(int result = 200, string msg = "Success", T? body = default)
        {
            this.Result = result;
            this.Message = msg;
            this.Body = body;
        }
        public static ResponseModel<T> Success(T body)
        {
            return new ResponseModel<T>(body: body);
        }
        public static ResponseModel<T> Fail(int r, string m)
        {
            return new ResponseModel<T>(result: r, msg: m);
        }
    }
}
