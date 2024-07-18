using System.ComponentModel.DataAnnotations;

namespace BPKBapi.Models
{
    public class StorageLocation
    {
        [Key]
        public string? location_id { get; set; }
        public string? location_name { get; set; }
    }
}
