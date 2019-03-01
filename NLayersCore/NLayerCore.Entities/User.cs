namespace NLayerCore.Entities
{
    public class User
    {
        public string Id { get; set;}
        public string Username { get; set;}
        public string PasswordHash { get; set;}
        public string PasswordSalt { get; set;}
        public string Gender { get; set;}
        public string DateOfBirth { get; set;}
        public string KnownAs { get; set;}
        public string Created { get; set;}
        public string LastActive { get; set;}
        public string Introduction { get; set;}
        public string LookingFor { get; set;}
        public string Interests { get; set;}
        public string City { get; set;}
        public string Country { get; set;}
        public string Email { get; set;}
        public string EmailConfirmed { get; set;}
        public string PhoneNumber { get; set;}
        public string PhoneConfirmed { get; set;}

    }
}