//Action
using CC_ActionFucPredicate_Event_Lesson24;

internal class Car : IMyInterface<int, int>
{
    public int Doors { get => 3; set => Console.WriteLine(value); }


    public Car()
    {
        //Calculator.MyDel = (n1, n2) => n1 * n2 * n1;
        //Calculator.MyDel.Invoke(10, 20);
        Calculator.MyDel += (n1, n2) => n1 * n2 * n1;
    }
    public void GetT(int param)
    {
        throw new NotImplementedException();
    }

    public int ReturnT()
    {
        throw new NotImplementedException();
    }
}

internal interface IMyInterface<in TIn, out TOut>
{
    public int Doors { get; set; }
    void GetT(TIn param);
    TOut ReturnT();
}