public class Kata
{
    public static int AdjacentElementsProduct(int[] array)
    {
        int maxProduct = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int product = array[i] * array[i + 1];
            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }

        return maxProduct;
    }
}