namespace CSharpCourseAbstractMethods.Entities {
    public class Person : TaxPayer {

        public double HealthSpendings { get; set; }

        public Person(string name, double yearlyIncome, double healthSpendings) : base(name, yearlyIncome) {
            HealthSpendings = healthSpendings;
        }

        public override double taxCalc() {
            switch (base.YearlyIncome >= 20000) {
                case true:
                    return ((base.YearlyIncome * 0.25) - (HealthSpendings * 0.5));
                case false:
                    return ((base.YearlyIncome * 0.15) - (HealthSpendings * 0.5));
            }
        }


    }
}
