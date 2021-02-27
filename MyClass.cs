namespace Lab_2
{
    public class MyClass
    {
        public static T FactoryMethod<T>() where T : new()
        {
            return new T();
        }
    }
}