namespace UsersLoginLib
{
    public class UserLogin
    {
        public string Login(string userName, string userPwd)
        {
            string result = "";
            if (userName == "Vicky" && userPwd == "Vicky@68")
            {
                result = "Login success";
            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}
