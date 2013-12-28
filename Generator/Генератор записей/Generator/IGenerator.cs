namespace RecordsGenerator
{
    interface IGenerator<out T, in TL>
    {
        T Generate(TL parameters);
    }
}
