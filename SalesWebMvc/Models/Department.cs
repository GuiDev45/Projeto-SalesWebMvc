namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }

        //Adicionar um vendedor/Sellers
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        //Método para calcular o total de vendas do departamento/Department em x período
        public double TotalSales(DateTime initial, DateTime final)
        {
            //Para cada vendedor/Seller na lista, some/Sum.
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
