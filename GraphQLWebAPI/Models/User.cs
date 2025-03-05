using Microsoft.Extensions.Hosting;

namespace GraphQLWebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Post> Posts { get; set; } = new();
    }
}
