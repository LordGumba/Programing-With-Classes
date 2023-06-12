public class Account
{
    private int _number;

    public void TransferAccount(int from, int to)
    {
        //validate the members
        _number = to;
    }
    public int GetNumber()
    {
        return _number;
    }
}