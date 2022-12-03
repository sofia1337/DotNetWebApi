using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DotNetWebApi.Models
{

    [Table("User")]
    public class User: IJSerialize
    {
        public string Status { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public string Subscribes { get; set; }
        public int Id { get; set; }

        public User(String json) 
        {
            try
            {
                dynamic o = JsonConvert.DeserializeObject(json);
                this.Status = o.Status;
                this.Name = o.Name;
                this.LastName = o.LastName;
                this.Password = o.Password;
                this.Avatar = o.Avatar;
                this.Subscribes = o.Subscribes;
                this.Id = o.Id;
            } catch {
                Console.WriteLine("Incorrect json scheme");
            }
        }

        public User(string status, string name, string lastName, string avatar, string subscribes, string password) : this(status)
        {
            Status = status;
            Name = name;
            LastName = lastName;
            Avatar = avatar;
            Subscribes = subscribes;
            Password = password;
        }

        public User() { }

        public String Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
