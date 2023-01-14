public static class Sorting
{
    public static int[] ShakerSort(this int[] listS)
    {
        int left = 0,
            right = listS.Length - 1,
            count = 0;

        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                count++;
                if (listS[i] > listS[i + 1])
                {
                    int t = listS[i];
                    listS[i] = listS[i + 1];
                    listS[i + 1] = t;
                }
            }
            right--;

            for (int i = right; i > left; i--)
            {
                count++;
                if (listS[i - 1] > listS[i])
                {
                    int t = listS[i-1];
                    listS[i-1] = listS[i];
                    listS[i] = t;
                }
            }
            left++;
        }
        return listS;
    }
}