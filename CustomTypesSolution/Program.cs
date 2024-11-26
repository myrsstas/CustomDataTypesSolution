
/* Ασκηση 1.6: 
Δημιουργήστε ένα console application το οποίο θα περιέχει ένα custom type με όνομα “CustomDataTypes”,
το οποίο θα περιέχει properties με όλα τα primitive types. Όταν το app τρέξει, θα δείξει στην κονσόλα τις τιμές
από όλα τα properties. Επίσης, θα περιλαμβάνει και μια μέθοδο η οποία θα προσθέτει 2 ακέραιους και θα επιστρέφει 
το αποτέλεσμά της.
 */

namespace CustomTypesSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDataTypes dataTypes = new CustomDataTypes
            {
                IntegerNumber = 10,
                LongNumber = 20L,
                DecimalNumber = 20M,
                FloatNumber = 15.0f,
                DoubleNumber = 20d,
                CharType = 'm',
                BoolType = true,
            };

            Console.WriteLine($@"
                       Integer : {dataTypes.IntegerNumber}
                       Long : {dataTypes.LongNumber}
                       Decimal : {dataTypes.DecimalNumber}
                       Float : {dataTypes.FloatNumber}
                       Double : {dataTypes.DoubleNumber}
                       Char : {dataTypes.CharType}
                       Bool : {dataTypes.BoolType}
                       ");
           
            dataTypes.ΑdditionOfIntegerAndDouble(dataTypes.IntegerNumber, dataTypes.DoubleNumber); 
        }
    }

    class CustomDataTypes
    {
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

        public int IntegerNumber { get; set; }

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

        public void ΑdditionOfIntegerAndDouble(int integerNumber , double doubleNumber) //methods should be Pascal Casing
        {
            double answer = integerNumber + doubleNumber;
            Console.WriteLine($"if you add {integerNumber} and {doubleNumber} you get {answer}");
        }

    }
}
