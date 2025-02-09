namespace HouseRentingSystem.Infrastructure.Data.Constants
{
    public static class DataConstants
    {
        //Category
        public const int CategoryNameMaxLength = 50;

        //Agent
        public const int AgentPhoneNumberMinLength = 7;
        public const int AgentPhoneNumberMaxLength = 15;

        //House
        public const int HouseTitleMinLength = 10;
        public const int HouseTitleMaxLength = 50;

        public const int HouseAddressMinLength = 30;
        public const int HouseAddressMaxLength = 150;

        public const int HouseDescriptionMinLength = 50;
        public const int HouseDescriptionMaxLength = 500;

        public const string HouseRentMinValue = "0.00";
        public const string HouseRentMaxValue = "2000.00";
    }
}
