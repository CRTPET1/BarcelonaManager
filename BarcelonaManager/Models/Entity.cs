using System;

namespace BarcelonaManager.Models
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity()
        {
            Id = new Random().Next(1000, 9999);
        }

        public virtual string Info()
        {
            return $"ID: {Id}";
        }
    }
}
