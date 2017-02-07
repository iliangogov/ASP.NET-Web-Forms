namespace Countries.Data.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public Category()
        {
            this.Todos = new HashSet<Todo>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Todo> Todos { get; set; }
    }
}