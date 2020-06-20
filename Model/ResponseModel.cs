namespace ShoppingCartCore.Model
{
    public class ResponseModel
    {
        public string statusCode { get; set; }
        public string statusDesc { get; set; }
        public Summary summaryResponse { get; set; } = new Summary();

    }
}
