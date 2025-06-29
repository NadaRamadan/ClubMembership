using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMembership.FieldValidators
{
    public delegate bool FieldValidatorDel(int fieldIndex, string fieldName, string[] fieldArray, out string fieldInvalidMessage);
    public interface  IFieldValidator
    {
        void  InitializeValidatorDelegates();
        string[] fieldArray {  get;  }
        FieldValidatorDel ValidatorDel { get; }

    }
}
