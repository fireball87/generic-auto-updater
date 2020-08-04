namespace StandardUpdaterLib.UI
{
    public interface IDisplayError
    {
        //shows the error, should also lead the application to terminate
        void ShowError(string text, string caption);
    }
}