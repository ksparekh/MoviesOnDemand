using MoviesOnDemand.Utils;

namespace MoviesOnDemand.Models
{
    public class User
    {

        // public User(int id, string name, string userID, string password)
        // {
        //     if (string.IsNullOrEmpty(name))
        //     {
        //         throw new System.ArgumentException("Name can't be empty.", nameof(name));
        //     }

        //     if (string.IsNullOrEmpty(userID))
        //     {
        //         throw new System.ArgumentException("UserID can't be empty.", nameof(userID));
        //     }

        //     if (string.IsNullOrEmpty(password))
        //     {
        //         throw new System.ArgumentException("Password can't be empty.", nameof(password));
        //     }

        //     this.ID = id;
        //     this.Name = name;
        //     this.UserID = userID;
        //     this.Password = password;
        // }

        //public User(int id, string name, string userID, string password, UserType type = UserType.Viewer) : this(id, name, userID, password)
        // {
        //     Type = type;
        // }

        public int ID { get; set; }

        public string Name { get; set; }

        public string UserID { get; set; }

        //private string password;

        public string Password { get; set; }

        //public string Password { get => password; set => password = EncryptionManager.GetHashedPassword(value); }

        public bool IsAdmin { get; set; }
    }
}