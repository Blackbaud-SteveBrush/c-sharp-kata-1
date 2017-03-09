namespace Kata1
{
  public class Player {

    // Using properties, instead of fields:
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Player(string firstName, string lastName) {
      // Properties and member methods should be Pascal case.
      FirstName = firstName;
      LastName = lastName;
    }

    public string GetFullName() {
      return $"{FirstName} {LastName}";
    }
  }
}
