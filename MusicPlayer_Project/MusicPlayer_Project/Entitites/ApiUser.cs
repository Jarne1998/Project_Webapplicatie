namespace MusicPlayer_Project.Entitites
{
    public class ApiUser
    {
        public string UserName { get; set; }
        public string Username { get; internal set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
