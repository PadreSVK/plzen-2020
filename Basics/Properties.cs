using System;

namespace Basics
{
    // ReSharper disable ArrangeAccessorOwnerBody
    // ReSharper disable ConvertToAutoProperty
    public class Properties : ISample
    {
        public void Run()
        {
            Console.WriteLine(NameWithBackingField);
            Console.WriteLine(NameWithBackingField2);
            var properties = new Properties()
            {
                NameWithDefaultValue = "Karol"
            };
        }

        private string nameWithBackingField;
        public string NameWithBackingField
        {
            get => nameWithBackingField;
            set => nameWithBackingField = value;
        }

        private string nameWithBackingField2;
        public string NameWithBackingField2
        {
            get { return nameWithBackingField2; }
            set { nameWithBackingField2 = value; }
        }

        public string Name { get; set; }

        public string NameWithDefaultValue { get; set; } = "Albert";
        public string NameWithDefaultInitValue { get; init; } = "Albert";


        public Properties()
        {
            NameWithDefaultInitValue = "test";
        }

        public void TryUpdateValueInNameWithDefaultInitValue()
        {
            //this.NameWithDefaultInitValue = "aaa";
        }
    }
}


