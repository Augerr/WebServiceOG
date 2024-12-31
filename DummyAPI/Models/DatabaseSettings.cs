namespace DummyAPI.Models
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string UsersCollectionName { get; set; } = null!;

        public string RolesCollectionName { get; set; } = null!;

        public string RightsCollectionName { get; set; } = null!;
    }
}
