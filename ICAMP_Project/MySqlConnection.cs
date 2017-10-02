namespace ICAMP_Project
{
    internal class MySqlConnection
    {
        private string connetionString;

        public MySqlConnection(string connetionString)
        {
            this.connetionString = connetionString;
        }
    }
}