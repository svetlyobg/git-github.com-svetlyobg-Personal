namespace TeamProjectBankAccount
{
    public class Person
    {
        public string
            username, password, firstName, balance;
        public int age;

        private string
            middleName, lastName, fullName, city, balanceCurrency, email, lastDraw;
        private double balanceValue;


        public Person(string username, string password, string firstName, string balance)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.balance = balance;
        }

        public string Username => this.username;
        public string Password => this.password;
        public string FirstName => this.firstName;
        public string MiddleName => this.middleName;
        public string LastName => this.lastName;
        public string FullName => this.fullName;
        public int Age => this.age;
        public string Email => this.email;
        public string City => this.city;
        public double BalanceValue => this.balanceValue;
        public string BalanceCurrency => this.balanceCurrency;
        public string Balance => this.balance;
        public string LastDraw => this.lastDraw;

        public string GetPersonInfo()
        {

            return $"\nYour name is {this.firstName} and your balance is {this.balance}";
        }

    }
}