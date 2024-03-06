namespace HouseRentingSystem.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequiredErrorMessage = "The {0} field is required.";

        public const string LengthErrorMessage = "The field {0} must be between {2} and {1} characters long.";

        public const string PhoneExistsErrorMessage = "Phone number already exists. Enter another one.";

        public const string HasRentsErrorMessage = "You should have no rents to become an agent.";

        public const string PriceErrorMessage = "Price per month must be a positive nnumber and less than {2} leva.";
    }
}
