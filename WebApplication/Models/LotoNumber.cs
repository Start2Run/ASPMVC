using System;

namespace WebApplication.Models
{
    public class LotoNumber
    {
        private bool _isSelected;
        public int Index { get; set; }
        public bool Enabled { get; set; } = true;
        public bool IsSelected
        {
            get => _isSelected; set
            {
                if (_isSelected == value) return;
                _isSelected = value;
                Color = _isSelected ? "red" : "blue";
            }
        }
        public string StringValue => Index.ToString();
        public Func<LotoNumber, Microsoft.AspNetCore.Mvc.ActionResult> ActionOnClick { get; set; }
        public string Color { get; set; } = "blue";
    }
}
