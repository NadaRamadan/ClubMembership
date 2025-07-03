using ClubMembership.Data;
using ClubMembership.FieldValidators;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubMembership.Views;

namespace ClubMembership
{
    public class Factory
    {
        public static Views.IView GetMainViewObject()
        {
            ILogin login = new LoginUser();
            IRegister register = new RegisterUser();
            IFieldValidator userRegistrationValidator = new UserRegistrationValidator(register);
            userRegistrationValidator.InitializeValidatorDelegates();

            Views.IView registerView = new UserRegistrationView(register, userRegistrationValidator);
            Views.IView loginView = new UserLoginView(login);
            Views.IView mainView = new MainView(registerView, loginView);

            return mainView;

        }
    }
}
