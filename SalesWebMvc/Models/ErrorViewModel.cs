namespace SalesWebMvc.Models
{
    //Esse ErrorViewModel não é um model de verdade não é uma propriedade de negócio,
    //é só um modelo auxiliar para povoar a tela. 
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}