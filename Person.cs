public class Person {
    private string _firstName;
    private string _lastName;

    public Person() {}
    public Person(string firstName, string lastName) {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FirstName {get; set;}
    public string LastName {get; set;}
}