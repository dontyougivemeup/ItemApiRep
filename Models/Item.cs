using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemApi.Models
{
    public class Item
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }

        [Required]
        public float Price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created_at { get; set; }
    }
}
