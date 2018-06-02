using PersonalInventory.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventory.UI.Wrapper
{
    public class ItemWrapper : ModelWrapper<Item>
    {
        public ItemWrapper(Item model):base(model)
        {
           
        }

        public int Id { get { return Model.Id; } }

        public string ItemName
        {
            get { return GetValue<string>(); }
            set
            {
                SetValue<string>(value);
                ValidateProperty(nameof(ItemName));
            }
        }

        protected override IEnumerable<string> ValidateProperty(string propertyName)
        { 
            switch (propertyName)
            {
                case nameof(ItemName):
                    if (string.Equals(ItemName, "Robot", StringComparison.OrdinalIgnoreCase))
                    {
                        yield return "Name Can't be a Robot";
                    }
                    break;
            }
        }

        public string ItemModel
        {
            get { return GetValue<string>(); }
            set
            {
                SetValue<string>(value);
            }
        }

        public double Cost
        {
            get { return GetValue<double>(); }
            set
            {
                SetValue<double>(value);
            }
        }

        public double SailPrice
        {
            get { return GetValue<double>(); }
            set
            {
                SetValue<double>(value);
            }
        }

        public string ItemDescription
        {
            get { return GetValue<string>(); }
            set
            {
                SetValue<string>(value);
            }
        }

    }
}
