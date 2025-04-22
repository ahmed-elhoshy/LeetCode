 public static int HIndex(int[] citations)
{
    int n = citations.Length;

    for (int i = 0; i < citations.Length; i++)
    {

        if (citations[i] >= n - i) return n - i;

    }
    return 0;
}
