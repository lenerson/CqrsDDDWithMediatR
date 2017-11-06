namespace CqrsDDDWithMediatR.Domain.Commands.User
{
    public sealed class RegisterUserCommand : UserCommand
    {
        public RegisterUserCommand(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
