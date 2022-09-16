namespace Prototype.Interfaces
{
    public interface ICloneable<T> where T : class
    {
        public T ShallowCopy();

        public T DeepCopy();
    }
}
