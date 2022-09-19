public class ModuloFirst
{
    public static int[] modulo(int[] xs)
    {
        int numOne = xs[0];
        int[] result = new int[xs.Length];
        for(int i = 0; i< xs.Length;i++)
        {
            result[i] = xs[i] % numOne;        
        }
        return result;
    }
}