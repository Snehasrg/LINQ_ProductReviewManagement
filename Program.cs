namespace LINQDemo
{
    public class program
    {
        public static void Main(string[] args)
        {
            List<ProductReview> lstobj = new List<ProductReview>()
            {
                new ProductReview() { ProductId =1,UserId=1,Review=5,Rating="good",IsLike=true},
                new ProductReview() { ProductId =1,UserId=2,Review=4,Rating="bad",IsLike=false},                                new ProductReview() { ProductId =1,UserId=1,Review=4,Rating="good",IsLike=true},
                new ProductReview() { ProductId =2,UserId=3,Review=3,Rating="better",IsLike=true},
                new ProductReview() { ProductId =3,UserId=4,Review=2,Rating="best",IsLike=true},
                new ProductReview() { ProductId =3,UserId=5,Review=4,Rating="Excellent",IsLike=true}

            };

            Console.WriteLine("enter yout choice:\n 1.Select all record.\n 2.Top 3 record. \n" +
                "3.Get selected values");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:

                    foreach (var products in lstobj)
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(products.ProductId + " | " + products.UserId + " | " +
                                          products.Review + " | " + products.Rating + " | " + products.IsLike);
                    }
                    break;
                case 2:
                    ProductManagement.Top3Record(lstobj);

                    break;
                    case 3:
                    ProductManagement.GetSelectedValues(lstobj);
                    break;

            }
        
        }
    }
}