using System.ComponentModel.DataAnnotations;
using ItemService.Lib.Domain;

namespace ItemsWebApp.Models
{
    public class ItemModel
    {
        public ItemModel(Item entity)
        {
            Text = entity.Text.Value;
        }

        public ItemModel()
        {
        }

        [Display(Name = "Текст")] public string Text { get; set; }

        public Item ToEntity()
        {
            return new Item(Text);
        }
    }
}