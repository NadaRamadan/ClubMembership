using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FieldValidatorAPI;

using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using ClubMembership.Data;

namespace ClubMembership.FieldValidators
{
    public class UserRegistrationValidator 
    {

        const int FirstName_Min_Length = 2;
        const int FirstName_Max_Length = 100;
        const int LastName_Min_Length = 2;
        const int LastName_Max_Length = 100;

        delegate bool EmailExistsDel(string email);

        RequiredValidDel _requiredValidDel = null;
        StringLengthValidDel _stringLenthValidDel = null;
        DateValidDel _dateValidDel = null;
        PatternMatchValidDel _patternMatchValidDel = null;
        CompareFieldsValidDel _compareFieldsValidDel = null;

        EmailExistsDel _emailExistsDel = null;


        string[] _fieldArray = null;
        IRegister _register = null;

        public string[] FieldArray
        {

            get
            {
                if (_fieldArray == null)
                {
                    _fieldArray = new string[Enum.GetValues(typeof(FieldConstants.UserRegistrationField)).Length];
                }
                return _fieldArray;
            }

        }

    }
}
