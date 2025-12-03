using System;

namespace WinFormsEquipmentTracker.Model
{
    public class Equipment
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime? LastService { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }

        public Equipment()
        {   
            Id = "EQ-" + Guid.NewGuid().ToString("N").Substring(0, 8);
        }

        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}
