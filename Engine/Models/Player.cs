using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private int experiencePoints;
        private string name;
        private string characterClass;
        private int hitPoints;
        private int level;
        private int gold;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string CharacterClass
        {
            get { return characterClass; }
            set
            {
                if (characterClass != value)
                {
                    characterClass = value;
                    OnPropertyChanged(nameof(CharacterClass));
                }
            }
        }

        public int HitPoints
        {
            get { return hitPoints; }
            set
            {
                if (hitPoints != value)
                {
                    hitPoints = value;
                    OnPropertyChanged(nameof(HitPoints));
                }
            }
        }

        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set
            {
                if (experiencePoints != value)
                {
                    experiencePoints = value;
                    OnPropertyChanged(nameof(ExperiencePoints));
                }
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (level != value)
                {
                    level = value;
                    OnPropertyChanged(nameof(Level));
                }
            }
        }

        public int Gold
        {
            get { return gold; }
            set
            {
                if (gold != value)
                {
                    gold = value;
                    OnPropertyChanged(nameof(Gold));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
