using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DotNetWebApi.Models
{

    [Table("Project")]
    public class Project: IJSerialize
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        public string Date { get; set; }
        public string Place { get; set; }
        public int Id { get; set; }

        public Project(String json)
        {
            try
            {
                dynamic o = JsonConvert.DeserializeObject(json);
                this.Category = o.Category;
                this.Title = o.Title;
                this.Content = o.Content;
                this.Image = o.Image;
                this.Date = o.Date;
                this.Place = o.Place;
                this.Id = o.Id;
            }
            catch
            {
                Console.WriteLine("Incorrect json scheme");
            }
        }

        public Project() { }

        public String Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
