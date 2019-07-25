﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiceHashMiner.Configs.Data;

namespace NHM.Wpf.ViewModels.Settings
{
    public class GeneralSettingsVM : SettingsBaseVM
    {
        // Combo box lists
        public IReadOnlyList<string> CurrencyOptions { get; }
        public IEnumerable<string> LanguageOptions => Translations.GetAvailableLanguagesNames();

        // TODO lang binding to config requires some arch changes
        public int SelectedLangIndex
        {
            get => Translations.GetCurrentIndex();
            set
            {
                var code = Translations.GetLanguageCodeFromIndex(value);
                Translations.SelectedLanguage = code;
            }
        }

        public GeneralSettingsVM(GeneralConfig confObj)
            : base(confObj, "General")
        {
            CurrencyOptions = new List<string>
            {
                "AUD",
                "BGN",
                "BRL",
                "CAD",
                "CHF",
                "CNY",
                "CZK",
                "DKK",
                "EUR",
                "GBP",
                "HKD",
                "HRK",
                "HUF",
                "IDR",
                "ILS",
                "INR",
                "JPY",
                "KRW",
                "MXN",
                "MYR",
                "NOK",
                "NZD",
                "PHP",
                "PLN",
                "RON",
                "RUB",
                "SEK",
                "SGD",
                "THB",
                "TRY",
                "USD",
                "ZAR"
            };
        }
    }
}
