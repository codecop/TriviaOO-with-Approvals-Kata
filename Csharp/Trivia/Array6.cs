namespace UglyTrivia
{
    public class Array6<T>
    {
        private object[] array = new object[6];

        public Array6(T init)
        {
            for (int i = 0; i < 6; i++)
            {
                this.Set(i, init);
            }
        }

        public virtual void Set(int i, T value)
        {
            this.array[i] = value;
        }

        public virtual T Get(int i)
        {
            return (T)this.array[i];
        }
    }
}
