namespace Shop.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoreName { set; get; }

        public string desk { set; get; }
        public List<Car> cars { set; get; }
    }
}
