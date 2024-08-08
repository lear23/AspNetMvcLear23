using AspNetMvcLear23.Models;

namespace AspNetMvcLear23.ViewModels
{
    public class AccountDetailsViewModel
    {

        public DetailsBasicViewModel BasicInfo { get; set; } = new DetailsBasicViewModel();

        public AddressViewModel AddressModel { get; set; } = new AddressViewModel();

        public ProfileModel ProfileInfo {  get; set; } = new ProfileModel();
    }
}
