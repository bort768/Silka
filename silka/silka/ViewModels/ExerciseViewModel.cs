using silka.Models;
using silka.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Core;

namespace silka.ViewModels
{
    

    public class ExerciseViewModel : BindableObject     
    { 
        public INavigation Navigation { get; set; }

        public ObservableCollection<Exercise> Exercises { get; private set; } = new ObservableCollection<Exercise>();

        bool isRefreshing;
        const int RefreshDuration = 2;
        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set
            {
                isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand RefreshCommand => new Command(async () => await RefreshDataAsync());

        public ICommand OnClicked => new Command(async () => await GoToCountdownTimer());


        async Task GoToCountdownTimer()
        {
            var route = $"{nameof(CountdownTimerPage)}";
            await Shell.Current.GoToAsync(route);
        }

        public ExerciseViewModel(INavigation navigation)
        {
            AddExercise();
            Navigation = navigation;
        }
   
    
        async Task RefreshDataAsync()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(RefreshDuration));
            //GetNextPageOfData();
            IsRefreshing = false;
        }

        void AddExercise()
        {
            Exercises.Add(new Exercise
            {
                Name = "Ćwiczenie na klatke",
                Image = "Nr_21_chest.png",
                Muscle_Parties =  new string[] { "Klatka", "Triceps" }
            });

            Exercises.Add(new Exercise
            {
                Name = "Ćwiczenie na plecy",
                Image = "Nr_10_Back.png",
                Muscle_Parties = new string[] {"Mięsień najszerszy grzbietu"}
            });

            Exercises.Add(new Exercise
            {
                Name = "Ćwiczenie na barki",
                Image = "Nr_15_Shoulders.png",
                Muscle_Parties = new string[] {"Mięsień naramienny"}
            });

            Exercises.Add(new Exercise
            {
                Name = "Ćwiczenie na biceps",
                Image = "Nr_22_Biceps.png",
                Muscle_Parties = new string[] { }
            });

            Exercises.Add(new Exercise
            {
                Name = "Ćwiczenie na triceps",
                Image = "Nr_23_Triceps.png",
                Muscle_Parties = new string[] { }
            });

            Exercises.Add(new Exercise
            {
                Name = "Ćwiczenie na nogi",
                Image = "Nr_77_legs.png",
                Muscle_Parties = new string[] { }
            });

            Exercises.Add(new Exercise
            {
                Name = "Ćwiczenie na brzuch",
                Image = "Nr_11_Abs.png",
                Muscle_Parties = new string[] { }
            });

            Exercises.Add(new Exercise
            {
                Name = "Ćwiczenie na dolne plecy",
                Image = "Nr_10_LowerBack.png",
                Muscle_Parties = new string[] { }
            });

        }
    }
}

