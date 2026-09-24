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
                // this is Polymorphism using Inheritance
                // m means that this number is a decimal
                new Book("B1", "The Alchemist", 34.99m, "Paulo Coelho"),
                new Software("S1", "Visual Studio", 110.99m, "Microsoft")
            };

            foreach(var product in list)
            {
                lstProducts.Items.Add(product.GetDisplayText("; "));
            }

            //Polymorphism using Interfaces
            var otherList = new List<IDisplayable>
            {
                // these classes will work here because they both implement IDisplayable
                new Book("B2", "The Godfather", 49.99m, "Mario Putzo"),
                new Software("S1", "Windows 11", 440.99m, "Microsoft")
            };

            // this is a lambda expression
            otherList.ForEach(x => lstProducts.Items.Add(x.GetDisplayString(", ")));
        }
    }
}
