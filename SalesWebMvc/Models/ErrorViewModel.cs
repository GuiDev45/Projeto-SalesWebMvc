namespace SalesWebMvc.Models
{
    //Esse ErrorViewModel n�o � um model de verdade n�o � uma propriedade de neg�cio,
    //� s� um modelo auxiliar para povoar a tela. 
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}