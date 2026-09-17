namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //event handlers stay private
        private void Form1_Load(object sender, EventArgs e)
        {
            var list = new List<Product>
            {
                // m means that this number is a decimal
                new Book("B1", "The Alchemist", 34.99m, "Paulo Coelho"),
                new Software("S1", "Visual Studio", 110.99m, "Microsoft")
            };

            foreach(var product in list)
            {
                lstProducts.Items.Add(product.GetDisplayText("; "));
            }
        }
    }
}
