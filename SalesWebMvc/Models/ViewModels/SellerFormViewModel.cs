namespace SalesWebMvc.Models.ViewModels
{
    //ViewModel é um Model composto, as vezes uma tela precisa de mais dados do que somente os dados da entidade,
    //então em ViewModel define todos os dados que for necessário para trafegar na tela.
    //Tela de cadastro do vendedor
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
