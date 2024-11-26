namespace CustomTypesSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomDataTypes dataTypes = new CustomDataTypes();
            dataTypes.IntegerNumber = 10;
            dataTypes.LongNumber = 20L;
            dataTypes.DecimalNumber = 20M;
            dataTypes.FloatNumber = 15.0f;
            dataTypes.DoubleNumber = 20d;
            dataTypes.CharType = 'm';
            dataTypes.BoolType = true;
            dataTypes.additionOfIntegerAndDouble(dataTypes.IntegerNumber, dataTypes.DoubleNumber); 
        }
    }

    class CustomDataTypes
    {
        int integerNumber;
        long longNumber;
        decimal decimalNumber;
        float floatNumber;
        double doubleNumber;
        char charType;
        bool boolType;
        string stringType = "Hello There";

        public CustomDataTypes() {

            Console.WriteLine("Here starts the constructor...");
        }

        public int IntegerNumber
        {
            get
            {
                return integerNumber;
            }
            set
            {
                integerNumber = value;
            }
        }

        public long LongNumber
        {
            get
            {
                return longNumber;
            }
            set
            {
                longNumber = value;
            }
        }
        public decimal DecimalNumber
        {
            get
            {
                return decimalNumber;
            }
            set
            {
                decimalNumber = value;
            }
        }
        public float FloatNumber
        {
            get
            {
                return floatNumber;
            }
            set
            {
                floatNumber = value;
            }
        }

        public double DoubleNumber
        {
            get
            {
                return doubleNumber;
            }
            set
            {
                doubleNumber = value;
            }
        }
        public char CharType
        {
            get
            {
                return charType;
            }

            set
            {

                charType = value;

            }
        }

        public bool BoolType
        {
            get
            {
                return boolType;
            }
            set
            {
                boolType = value;
            }
        }

        public void additionOfIntegerAndDouble(int integerNumber , double doubleNumber)
        {
            double answer = integerNumber + doubleNumber;
            Console.WriteLine($"if you add {integerNumber} and {doubleNumber} you get {answer}");
        }

    }
}
