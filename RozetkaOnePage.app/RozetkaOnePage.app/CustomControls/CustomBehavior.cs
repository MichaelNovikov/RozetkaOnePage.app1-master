using RozetkaOnePage.app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RozetkaOnePage.app.CustomControls
{
    class CustomBehavior : Behavior<Label>
    {
        public int Id { get; set; }


        protected override void OnAttachedTo(Label label)
        {
            label.PropertyChanged += OnEntryTextChanged;
            base.OnAttachedTo(label);
        }

        protected override void OnDetachingFrom(Label label)
        {
            label.PropertyChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(label);
        }

        void OnEntryTextChanged(object sender, PropertyChangedEventArgs args)
        {
            //((Label)sender).Text = GetUserById(Id); /*.GetDescription();*/
        }
    }
}
