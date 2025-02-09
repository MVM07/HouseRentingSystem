namespace HouseRentingSystem.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequiredMessage = "The {0} field is required.";

        public const string LengthMessage = "The field {0} must be between {2} and {1} characters long.";

        public const string PhoneExists = "Phone number already exists.";

        public const string HasRents = "You should have no rents to become an agent.";

        public const string AllowedRentRange = "Price per month must be positive number and less than {2} leva.";
    }
}
