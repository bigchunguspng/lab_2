namespace Lab_2
{
    public static class Extensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                result[i] = list[i];
            }

            return result;
        }
    }
}