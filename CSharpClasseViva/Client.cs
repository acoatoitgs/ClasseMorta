using CSharpClasseViva.Variables;
using CSharpClasseViva.ErrorCodes;


namespace CSharpClasseViva.Client
{
    internal class Client
    {   
        public Client() { }



        /// <summary>
        /// Logs into ClasseViva account. Returns ErrorCode.SUCCESS if the login went well.
        /// 
        /// </summary>
        /// <param name="userID"> The account's UID in string format.</param>
        /// <param name="userPWD"> The account's password in string format. </param>
        /// <returns></returns>
        public short Login(string userID, string userPWD)
        {


            return ErrorCode.SUCCESS;
        }


    }
}
