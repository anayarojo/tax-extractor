﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace TaxExtractor.Models
{
    public class SelectableViewModel : INotifyPropertyChanged
    {
        private bool _isSelected;
        private bool _isHover;
        private string _name;
        private string _description;
        private char _code;
        private double _numeric;
        private string _food;
        private List<SelectableViewModel> _parent;

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                //if (_parent != null && value) _parent.ForEach(x => x.IsSelected = false);

                if (_isSelected == value) return;
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        public bool IsHover
        {
            get { return _isHover; }
            set
            {
                if (_isHover == value) return;
                _isHover = value;
                OnPropertyChanged();
            }
        }

        public char Code
        {
            get { return _code; }
            set
            {
                if (_code == value) return;
                _code = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (_description == value) return;
                _description = value;
                OnPropertyChanged();
            }
        }

        public double Numeric
        {
            get { return _numeric; }
            set
            {
                if (_numeric == value) return;
                _numeric = value;
                OnPropertyChanged();
            }
        }

        public string Food
        {
            get { return _food; }
            set
            {
                if (_food == value) return;
                _food = value;
                OnPropertyChanged();
            }
        }

        public List<SelectableViewModel> Parent
        {
            get { return _parent; }
            set
            {
                if (_parent == value) return;
                _parent = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
