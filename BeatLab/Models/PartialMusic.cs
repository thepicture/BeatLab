﻿using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BeatLab
{
    public partial class Music : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Name_music))
                    if (string.IsNullOrWhiteSpace(Name_music))
                        return "Введите название трека";
                //if (columnName == nameof(Price_Music))
                //    if (Price_Music.LastOrDefault() != null || Price_Music.Last().Price <= 0)
                //        return "Введите корректную цену";
                return null;
            }
        }

        public string Error
        {
            get
            {
                StringBuilder errors = new StringBuilder();
                foreach (var property in GetType().GetProperties(System.Reflection.BindingFlags.Public))
                    if (this[property.Name] != null)
                        errors.AppendLine(this[property.Name]);
                return errors.ToString();
            }
        }
    }
}