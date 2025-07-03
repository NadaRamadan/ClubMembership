using ClubMembership.FieldValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubMembership.Views
{
    public interface IView
    {
        void RunView();
        IFieldValidator FieldValidator { get; }
    }
}