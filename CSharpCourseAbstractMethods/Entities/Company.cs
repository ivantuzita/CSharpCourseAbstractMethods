namespace CSharpCourseAbstractMethods.Entities {
    public class Company : TaxPayer {

        public int NumEmployees { get; set; }

        public Company(string name, double yearlyIncome, int numEmployees) : base(name, yearlyIncome) {
            NumEmployees = numEmployees;
        }

        public override double taxCalc() {
            switch (NumEmployees > 10) {
                case true:
                    return base.YearlyIncome * 0.14;
                case false:
                    return base.YearlyIncome * 0.16;
            }
        }
    }
}
