using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FieldValidatorAPI
{
    public delegate bool RequiredValidDel(string fieldValid);
    public delegate bool StringLengthValidDel(string fieldValid, int min, int max);
    public delegate bool DateValidDel(string fieldValid, out DateTime validDateTime);
    public delegate bool PatternMatchValidDel(string fieldValid, string pattern);
    public delegate bool CompareFieldsValidDel(string fieldValid, string fieldValCompare);
    public class CommonFieldValidatorFunctions
    {
        private static RequiredValidDel _requiredValidDel;
        private static StringLengthValidDel _stringLengthValidDel;
        private static DateValidDel _dateValidDel;
        private static PatternMatchValidDel _patternMatchValidDel;
        private static CompareFieldsValidDel _compareFieldsValidDel;

        public static RequiredValidDel RequiredFieldValidDel
        {
            get
            {
                if (_requiredValidDel == null)
                    _requiredValidDel = new RequiredValidDel(RequiredFieldValid);
                return _requiredValidDel;
            }

        }
        public static StringLengthValidDel StringLengthFieldValidDel
        {
            get
            {
                if (_stringLengthValidDel == null)
                    _stringLengthValidDel = new StringLengthValidDel(StringLengthFieldValid);
                return _stringLengthValidDel;
            }

        }
        public static DateValidDel DateFieldValidDel
        {
            get
            {
                if (_dateValidDel == null)
                    _dateValidDel = new DateValidDel(DateFieldValid);

                return _dateValidDel;


            }
        }
        public static PatternMatchValidDel PatternMatchFieldValidDel
        {
            get
            {
                if (_patternMatchValidDel == null)
                    _patternMatchValidDel = new PatternMatchValidDel(PatternMatchFieldValid);
                return _patternMatchValidDel;
            }
        }
        public static CompareFieldsValidDel FieldsCompareValidDel
        {
            get
            {
                if (_compareFieldsValidDel == null)
                    _compareFieldsValidDel = new CompareFieldsValidDel(FieldComparisonValid);
                return _compareFieldsValidDel;
            }
        }
        private static bool RequiredFieldValid(string fieldVal)
        {
            if (!string.IsNullOrEmpty(fieldVal))
            {
                return true;
            }
            return false;
        }
        private static bool StringLengthFieldValid(string fieldVal, int min, int max)
        {
            if(fieldVal.Length >= min && fieldVal.Length <= max ){
                return true;

            }
            return false;
            

        }
        private static bool DateFieldValid(string dateTime, out DateTime validDateTime)
        {
            if(DateTime.TryParse(dateTime, out validDateTime)) //TryParse is a safe way to convert a string into another data type — like int, double, DateTime, etc. — without throwing an error if the string is invalid.
            {
                return true;
            }
            return false;
        }
        private static bool PatternMatchFieldValid(string pattern, string fieldVal)
        {
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(fieldVal))
            {
                return true;
            }
            return false;
        }
        private static bool FieldComparisonValid(string field1, string field2)
        {
            return field1.Equals(field2); //case-senstive
        }



    }

}

