using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.JavaScript;

namespace ElectronicAdsBoard.Contracts.User;

public class CreateUserDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Login { get; set; }
    public string Pasword { get; set; }
    public DateTime Birthday { get; set; }
    public string Phonenumber { get; set; }
}