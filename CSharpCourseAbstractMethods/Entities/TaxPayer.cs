namespace CSharpCourseAbstractMethods.Entities {
    public abstract class TaxPayer {

        public string Name { get; set; }
        public double YearlyIncome { get; set; }

        public abstract double taxCalc();

        protected TaxPayer(string name, double yearlyIncome) {
            Name = name;
            YearlyIncome = yearlyIncome;
        }
    }
}
