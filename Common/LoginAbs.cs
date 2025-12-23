namespace Common
{
    public abstract class LoginAbs
    {
        public abstract void Login(string username,string password);   
        public abstract void Logout(string username,string password);

        public bool LoginProcess()
        {
            return true;
        }
        public bool LogoutProcess()
        {
            return true;
        }
        public static void Main()
        {

        }
    }
}
