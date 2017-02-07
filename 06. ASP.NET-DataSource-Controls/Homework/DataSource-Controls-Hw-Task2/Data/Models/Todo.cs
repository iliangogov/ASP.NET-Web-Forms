namespace Countries.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Todo
    {
        public Todo()
        {
            this.LastChanged = DateTime.Now;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        public DateTime LastChanged { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}