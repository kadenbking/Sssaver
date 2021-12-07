using System;
using System.Collections.ObjectModel;
using Sssaver.Models;

namespace Sssaver.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public SavingsPlan SavingsPlan { get; set; }

        public decimal TodaysSavingsAmount { get; set; }

        public string CurrentProgressBounds { get; set; }
        
        

        public HomeViewModel()    
        {
            // if no savingsPlan is passed into the constructor,
            // then create one. This is for demo purposes.
            SavingsPlan = new SavingsPlan()
            {
                Days = 30,
                Name = "Fibonacci Plan",
                CurrentSavingsAmount = 54,
                TotalSavingsAmount = 144
            };

            // Today's Savings Amount should be extracted from
            // the SavingsChallenges list in the SavingsPlan.
            

            // The SavingsHistory should be loaded from the
            // SavingsChallenges list in the SavingsPlan.
            

        }
    }
}
